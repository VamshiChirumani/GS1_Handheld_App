This is a **Desktop Application developed with .Net Framework**

This application can only be run on AdvancedHMI cpu's as it has many internal plugin's that support access to multiple serial ports at the same time.

![image](https://github.com/VamshiChirumani/GS1_Handheld_App/assets/92098361/b6cc0266-e81d-462c-92af-7cd963df10ac)

This is a controller rig for a handheld scanner station that has 8 Handheld scanners attached to it.
A slider moves below these scanners that has 8 slots to place 8 AutoId tags on it.
the slider moves for a limited number of times during the test so that each scanner scans each Id for a particular number of times.

This application controls the moment of the slider.
The slider is connected to a Thompson controller that accepts serial communication. This application sends instructions to the controller.
Along with that a PLC logic is also written for changing the cards on the slots.
with the help of the logic 8 cards in all the slots are moved to the next slot.

**User Manual for HandHeld App**

![image](https://github.com/VamshiChirumani/GS1_Handheld_App/assets/92098361/36945569-2ec0-4f19-b3a6-b91d0ff26a7b)

We can connect to the slider by giving the port number and baud rate.
After connecting to the slider we can move the slider forward, backward and also a Home position is set.
When Home is pressed it goes and stops below the rail for changing its cards.

When run test is clicked the sliders waits until it gets cards. After getting its cards it moves below the slider for the number of times mentioned in cycle.

This process goes on untill all the cards are scanned by all the scanners.
