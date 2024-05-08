using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GS1_Handheld_App.Properties;
using System.IO.Ports;
using System.Threading;
using System.Deployment;

namespace GS1_Handheld_App
{
    public partial class Form1 : Form
    {

        int IndexCount = 0;
        public Form1()
        {
            //ethernetIPforSLCMicroCom1.IPAddress = Settings.Default.PLC_IP;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ethernetIPforSLCMicroCom1.IPAddress = Settings.Default.PLC_IP;

            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                this.Text += " - " + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();


            try
            {
                if (ethernetIPforSLCMicroCom1 != null)
                {
                    var result = ethernetIPforSLCMicroCom1.Read("B3:0/0");
                    if (result != null) cboxConnected.Checked = true;
                }
            }
            catch { };

            foreach (string port in SerialPort.GetPortNames())
            {
                cbPort.Items.Add(port);
            }

            if (cbPort.Items.Count > 0) cbPort.SelectedIndex = 0;
            cbBaud.SelectedIndex = 0;
            cbStart.SelectedIndex = 0;
            cbStop.SelectedIndex = 0;

            GetSettings();
            tmrCheckHome.Start();

            if (ethernetIPforSLCMicroCom1.Read("B3:1/10") == "False")
            {
                btnHaltAir.BackColor = Color.Red;
                btnHaltAir.Text = "Halt Pnuematics";
            }
            MessageBox.Show("Check if the slider is  to the end of the axis before pressing the connect button", 
                "Motion Slider", MessageBoxButtons.OK);
            MotionSerialPort.BaudRate = Convert.ToInt32(cbBaud.Text);
            MotionSerialPort.PortName = cbPort.SelectedItem.ToString();
            MotionSerialPort.DataBits = Convert.ToInt32(cbStart.Text);
            if (cbStop.Text == "1")
                MotionSerialPort.StopBits = System.IO.Ports.StopBits.One;
            else
                MotionSerialPort.StopBits = System.IO.Ports.StopBits.Two;
            MotionSerialPort.Open();
            MotionSerialPort.DiscardInBuffer();
            MotionSerialPort.DiscardOutBuffer();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            MotionSerialPort.Write("ABS\n");
            MotionSerialPort.Write("X-27\n");
            if (MotionSerialPort.IsOpen) try { MotionSerialPort.Close(); } catch { }
            if (ValveSerialPort1.IsOpen) try { ValveSerialPort1.Close(); } catch { }
        }

        #region Cross threading
        delegate void UpdateStatusD(string data);
        private void UpdateStatus(string data)
        {
            if(lboxStatus.InvokeRequired)
            {

            }
            else
            {
                if (lboxStatus.Items.Count == 0)
                    lboxStatus.Items.Add(data);
                else
                    lboxStatus.Items.Insert(0, data);
            }
        }

        delegate void UpdateHomePosD(bool state);
        private void UpdateHomePos(bool state)
        {
            if(rbAtHome.InvokeRequired)
            {
                UpdateHomePosD d = new UpdateHomePosD(UpdateHomePos);
                rbAtHome.Invoke(d, new object[] { state });
            }
            else
            {
                rbAtHome.Checked = state;
            }
        }

        #endregion

        #region My functions

        private void GetSettings()
        {
            txtPLC_IP.Text = Settings.Default.PLC_IP;
            cbPort.Text = Settings.Default.CommPort;
            txtMoveToLoc.Text = Settings.Default.MovToLoc;
            txtHomeOffset.Text = Settings.Default.HomeOffset;
            nudCards.Value = Settings.Default.NoCards;
            nudCycles.Value = Settings.Default.NoCycles;
        }

        private void SaveSettings()
        {
            Settings.Default.PLC_IP = txtPLC_IP.Text;
            Settings.Default.CommPort = cbPort.Text;
            Settings.Default.MovToLoc = txtMoveToLoc.Text;
            Settings.Default.HomeOffset = txtHomeOffset.Text;
            Settings.Default.NoCycles = nudCycles.Value;
            Settings.Default.NoCards = nudCycles.Value;

            Settings.Default.Save();
        }
        #endregion


        #region Motion Slider


        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Setting the acceleration and Feeder rate 
                MotionSerialPort.Write("ALLDRVON\n");
                MotionSerialPort.Write("ACC40000\n");
                MotionSerialPort.Write("F40000\n");

                btnConnect.Enabled = false;
                btnFwd.Enabled = true;
                btnBack.Enabled = true;
                btnMove.Enabled = true;
                btnHome.Enabled = true;
                btnRun.Enabled = true;
                UpdateStatus("TMC connection successful");
                
                string acc = MotionSerialPort.ReadExisting();
                MotionSerialPort.WriteLine("ACC?");
                Thread.Sleep(100);
                acc = MotionSerialPort.ReadExisting();
                listBox1.Items.Add(acc);
                MotionSerialPort.WriteLine("F?");
                Thread.Sleep(100);
                acc = MotionSerialPort.ReadExisting();
                listBox1.Items.Add(acc);
                MotionSerialPort.DiscardInBuffer();
               
                
                MotionSerialPort.Write("ALLDRVON\n");
                MotionSerialPort.Write("XHOME\n");
                MotionSerialPort.Write("ABS\n");
                Thread.Sleep(100);
                // Setting X27 as its home where the suction cups land on the motion slider 
                MotionSerialPort.Write("X27\n");
                Thread.Sleep(1000);
                //MotionSerialPort.Write("XHOME\n");
                MotionSerialPort.DiscardInBuffer();
                MotionSerialPort.Write("XHOME\n");
                //MotionSerialPort.Write("ALLDRVOFF\n");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateStatus("Starting homing...");
                
                MotionSerialPort.Write("ALLDRVON\n");
                MotionSerialPort.Write("ABS\n");
                MotionSerialPort.Write("X0\n");

                UpdateStatus("Homed");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnFwd_Click(object sender, EventArgs e)
        {
            UpdateStatus("Jogging 0.5 forward");
            MotionSerialPort.DiscardInBuffer();
            MotionSerialPort.WriteLine("ALLDRVON\n");
            MotionSerialPort.WriteLine("REL\n");
            MotionSerialPort.WriteLine("REL\n");
            Thread.Sleep(1000);
            MotionSerialPort.WriteLine("X50\n");
            //MotionSerialPort.WriteLine("ABS\n");

            MotionSerialPort.DiscardInBuffer();
            MotionSerialPort.WriteLine("X?");
            Thread.Sleep(250);
            string xposition = MotionSerialPort.ReadLine();
            xposition = MotionSerialPort.ReadLine();
            textBox1.Text = xposition;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UpdateStatus("Jogging 0.5 backards");
            MotionSerialPort.DiscardInBuffer();
            MotionSerialPort.Write("ALLDRVON\n");
            Thread.Sleep(100);
            MotionSerialPort.WriteLine("REL\n");
            Thread.Sleep(1000);
            MotionSerialPort.Write("X-50\n");
            MotionSerialPort.Write("ABS\n");
            MotionSerialPort.DiscardInBuffer();
            MotionSerialPort.WriteLine("X?");
            string xposition = MotionSerialPort.ReadLine();
            xposition = MotionSerialPort.ReadLine();
            textBox1.Text = xposition;

        }

        private void btnMove_Click(object sender, EventArgs e)
        {


            if (txtMoveToLoc.Text == "")
            {
                UpdateStatus("Invalid move requested");
                MessageBox.Show("Please enter a location to move to");
                return;
            }

            UpdateStatus("Moving by " + txtMoveToLoc.Text);
            float xvalue = float.Parse(txtMoveToLoc.Text);
            MotionSerialPort.WriteLine("ALLDRVON\n");
            MotionSerialPort.WriteLine("REL");
            MotionSerialPort.Write("X" + xvalue + "\n");
            MotionSerialPort.WriteLine("ABS");
            MotionSerialPort.DiscardInBuffer();
            MotionSerialPort.WriteLine("X?");
            //xposition = MotionSerialPort.ReadLine();
            //xposition = MotionSerialPort.ReadLine();
            //xposition = MotionSerialPort.ReadLine();
            string xposition = MotionSerialPort.ReadLine();
            xposition = MotionSerialPort.ReadLine();
            textBox1.Text = xposition;


        }

        #endregion



        

        private void btnUp_Click(object sender, EventArgs e)
        {
            UpdateStatus("Manual up");
            try
            {
                ethernetIPforSLCMicroCom1.Write("B3:0/0", "True"); //up

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            UpdateStatus("Manual down");
            try
            {
                ethernetIPforSLCMicroCom1.Write("B3:0/1", "True"); //down
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            UpdateStatus("Manual left");
            try
            {
                ethernetIPforSLCMicroCom1.Write("B3:0/2", "True"); //Left

                //ethernetIPforSLCMicroCom1.Write("B3:0/2", "False"); //Left
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            UpdateStatus("Manual right");
            try
            {
                ethernetIPforSLCMicroCom1.Write("B3:0/3", "True"); //right

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVacuum_Click(object sender, EventArgs e)
        {
            UpdateStatus("Toggle vacuum");
            try
            {
                if(ethernetIPforSLCMicroCom1.Read("B3:0/4")=="False")
                    ethernetIPforSLCMicroCom1.Write("B3:0/4", "True"); //vacuum
                else
                    ethernetIPforSLCMicroCom1.Write("B3:0/4", "False"); //vacuum

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (btnRun.Text == "Run Test")
            {
                btnRun.Text = "Abort Test";
                backgroundRunTest.RunWorkerAsync();
            }
            else
            {
                btnRun.Text = "Run Test";
                backgroundRunTest.CancelAsync();
            }
        }

        private void backgroundRunTest_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateBack(false);
            UpdateFwd(false);
            UpdateLeft(false);
            UpdateRight(false);
            UpdateUp(false);
            UpdateDown(false);
            UpdateHomed(false);
            UpdateVacuum(false);
            UpdateMove(false);
            SetProgress((int)nudCycles.Value * (int)nudCards.Value + (7* (int)nudCycles.Value));
            btnHome.PerformClick();
            int Count = 0;

            //Not sure if this works need to change
            Thread.Sleep(1000);
            while (Convert.ToBoolean(ethernetIPforSLCMicroCom1.Read("I:0/9")) == false)
                Thread.Sleep(500);

            ethernetIPforSLCMicroCom1.Write("B3:1/2", "true"); //Index cards

            //wait for PLC to finish
            Thread.Sleep(1000);
            while (Convert.ToBoolean(ethernetIPforSLCMicroCom1.Read("B3:1/3")) == false)
            {
                Thread.Sleep(500);
            }

            //untill here
            ethernetIPforSLCMicroCom1.Write("B3:1/2", "false");
            ethernetIPforSLCMicroCom1.Write("B3:1/3", "false");
            for (int j = 0; j < (int)nudCards.Value + 7; j++)
            {
                UpdateStatus("Card " + j.ToString() + " being processed...");
                MotionSerialPort.DiscardInBuffer();
                MotionSerialPort.Write("ALLDRVON\n");
                MotionSerialPort.Write("ABS\n");
                MotionSerialPort.Write("X0\n");
                for (int i = 0; i < (int)nudCycles.Value; i++)
                {
                    //for (int j = 0; j < (int)nudCards.Value; j++)
                    //{
                    //    System.Threading.Thread.Sleep(250);
                    //    Count++;
                    //    UpdateProgress(Count);
                    //}
                    MotionSerialPort.Write("X400\n");
                    Thread.Sleep(2000);
                    Count++;
                    UpdateProgress(Count);
                    MotionSerialPort.Write("X850\n");
                    Thread.Sleep(500);
                    if(btnRun.Text== "Run Test")
                    {
                        break;
                    }
                     
                }
                MotionSerialPort.Write("X0\n");
                MotionSerialPort.Write("WAIT\n");
                MotionSerialPort.Write("ALLDRVOFF\n");
                Thread.Sleep(1000);
                while (Convert.ToBoolean(ethernetIPforSLCMicroCom1.Read("I:0/9")) == false)
                    Thread.Sleep(500);

                ethernetIPforSLCMicroCom1.Write("B3:1/2", "true"); //Index cards

                //wait for PLC to finish
                Thread.Sleep(1000);
                while (Convert.ToBoolean(ethernetIPforSLCMicroCom1.Read("B3:1/3")) == false)
                {
                    Thread.Sleep(500);
                }
                if (btnRun.Text == "Run Test")
                {
                    break;
                }


            }
        }

        private void backgroundRunTest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateBack(true);
            UpdateFwd(true);
            UpdateLeft(true);
            UpdateRight(true);
            UpdateUp(true);
            UpdateDown(true);
            UpdateHomed(true);
            UpdateVacuum(true);
            UpdateMove(true);
            UpdateRun("Run Test");
            btnHome.PerformClick();
        }

        #region Crossthreading
        delegate void SetProgressD(int data);
        private void SetProgress(int data)
        {
            if (progressRun.InvokeRequired)
            {
                SetProgressD d = new SetProgressD(SetProgress);
                progressRun.Invoke(d, new object[] { data });
            }
            else
            {
                progressRun.Maximum = data;
                progressRun.Value = 0;
                this.Refresh();
            }
        }

        delegate void UpdateProgressD(int data);
        private void UpdateProgress(int data)
        {
            if (progressRun.InvokeRequired)
            {
                UpdateProgressD d = new UpdateProgressD(UpdateProgress);
                progressRun.Invoke(d, new object[] { data });
            }
            else
            {
                progressRun.Value = data;
            }
        }

        delegate void UpdateVacuumD(bool state);
        private void UpdateVacuum(bool state)
        {
            if (btnVacuum.InvokeRequired)
            {
                UpdateVacuumD d = new UpdateVacuumD(UpdateVacuum);
                btnVacuum.Invoke(d, new object[] { state });
            }
            else
            {
                btnVacuum.Enabled = state;
            }
        }

        delegate void UpdateUpD(bool state);
        private void UpdateUp(bool state)
        {
            if (btnUp.InvokeRequired)
            {
                UpdateUpD d = new UpdateUpD(UpdateUp);
                btnUp.Invoke(d, new object[] { state });
            }
            else
            {
                btnUp.Enabled = state;
            }
        }

        delegate void UpdateDownD(bool state);
        private void UpdateDown(bool state)
        {
            if (btnDown.InvokeRequired)
            {
                UpdateDownD d = new UpdateDownD(UpdateDown);
                btnDown.Invoke(d, new object[] { state });
            }
            else
            {
                btnDown.Enabled = state;
            }
        }

        delegate void UpdateHomedD(bool state);
        private void UpdateHomed(bool state)
        {
            if (btnHome.InvokeRequired)
            {
                UpdateHomedD d = new UpdateHomedD(UpdateHomed);
                btnHome.Invoke(d, new object[] { state });
            }
            else
            {
                btnHome.Enabled = state;
            }
        }

        delegate void UpdateFwddD(bool state);
        private void UpdateFwd(bool state)
        {
            if(btnFwd.InvokeRequired)
            {
                UpdateFwddD d = new UpdateFwddD(UpdateFwd);
                btnFwd.Invoke(d, new object[] { state});
            }
            else
            {
                btnFwd.Enabled = state;
            }
        }

        delegate void UpdateBackD(bool state);
        private void UpdateBack(bool state)
        {
            if (btnBack.InvokeRequired)
            {
                UpdateBackD d = new UpdateBackD(UpdateBack);
                btnBack.Invoke(d, new object[] { state });
            }
            else
            {
                btnBack.Enabled = state;   
            }
        }

        delegate void UpdateLeftD(bool state);
        private void UpdateLeft(bool state)
        {
            if (btnLeft.InvokeRequired)
            {
                UpdateLeftD d = new UpdateLeftD(UpdateLeft);
                btnLeft.Invoke(d, new object[] { state });
            }
            else
            {
                btnLeft.Enabled = state;
            }
        }

        delegate void UpdateRightD(bool state);
        private void UpdateRight(bool state)
        {
            if (btnRight.InvokeRequired)
            {
                UpdateRightD d = new UpdateRightD(UpdateRight);
                btnRight.Invoke(d, new object[] { state });
            }
            else
            {
                btnRight.Enabled = state;
            }
        }

        delegate void UpdateMoveD(bool state);
        private void UpdateMove(bool state)
        {
            if (btnMove.InvokeRequired)
            {
                UpdateMoveD d = new UpdateMoveD(UpdateMove);
                btnMove.Invoke(d, new object[] { state });
            }
            else
            {
                btnMove.Enabled = state;
            }
        }
        
        delegate void UpdateRunD(string data);
        private void UpdateRun(string data)
        {
            if (btnRun.InvokeRequired)
            {
                UpdateRunD d = new UpdateRunD(UpdateRun);
                btnRun.Invoke(d, new object[] { data });
            }
            else
            {
                btnRun.Text = data;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ethernetIPforSLCMicroCom1.Write("O:0/2", "False"); //Left
            ethernetIPforSLCMicroCom1.Write("O:0/3", "False"); //right
            ethernetIPforSLCMicroCom1.Write("O:0/0", "False"); //right
            ethernetIPforSLCMicroCom1.Write("O:0/1", "False"); //right
            ethernetIPforSLCMicroCom1.Write("B3:0", "0"); //right
            ethernetIPforSLCMicroCom1.Write("B3:1", "0"); //right
            ethernetIPforSLCMicroCom1.Write("B3:2", "0"); //right
            progressRun.Value = 0;
            IndexCount = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IndexCount += 1;
            UpdateStatus("Index count = " + IndexCount.ToString());
            ethernetIPforSLCMicroCom1.Write("B3:1/2", "true"); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnHaltAir.Text == "Halt Pnuematics")
            {
                ethernetIPforSLCMicroCom1.Write("B3:1/10", "true"); //estop
                btnHaltAir.Text = "Enable Pnuematics";
                btnHaltAir.BackColor = SystemColors.Control;
                //MotionSerialPort.Write(Convert.ToChar(3) + "\n");
            }
            else
            {
                btnHaltAir.Text = "Halt Pnuematics";
                btnHaltAir.BackColor = Color.Red;
                ethernetIPforSLCMicroCom1.Write("B3:1/10", "false"); //estop
                UpdateBack(true);
                UpdateFwd(true);
                UpdateLeft(true);
                UpdateRight(true);
                UpdateUp(true);
                UpdateDown(true);
                UpdateHomed(true);
                UpdateVacuum(true);
                UpdateMove(true);
                UpdateRun("Run Test");
            }
        }

        private void tmrCheckHome_Tick(object sender, EventArgs e)
        {
            //Thread.Sleep(100);
            UpdateHomePos(Convert.ToBoolean(ethernetIPforSLCMicroCom1.Read("I:0/9")));
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            ethernetIPforSLCMicroCom1.Write("B3:0/9", "true");
            System.Threading.Thread.Sleep(1000);
            ethernetIPforSLCMicroCom1.Write("B3:0/9", "false");
        }

        private void Repeat10Times_Click(object sender, EventArgs e)
        {
            MotionSerialPort.Write("X0\n");
            for (int i = 0; i <10; i++)
            {
                Thread.Sleep(100);
                MotionSerialPort.Write("X400\n");
                Thread.Sleep(4000);
                MotionSerialPort.Write("X850\n");
                Thread.Sleep(1000);

            }

            MotionSerialPort.Write("X0\n");
        }
    }
}


//while(xposition.Contains("X AXIS MOTOR FAILED\r"))
//{
//    MotionSerialPort.DiscardInBuffer();
//    MotionSerialPort.Write("X-10\n");
//    xposition = MotionSerialPort.ReadExisting();
//    //xposition = MotionSerialPort.ReadLine();
//}

//Thread.Sleep(1000);
//while (xposition != "All drives turned ON.\r")
//{
//    MotionSerialPort.DiscardInBuffer();
//    MotionSerialPort.Write("ALLDRVON\n");
//    xposition = MotionSerialPort.ReadLine();
//    xposition = MotionSerialPort.ReadLine();
//}
//Turn Relative mode on as it is in position 0 relative to the axis.
