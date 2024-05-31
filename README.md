When a cigarette pack enters the camera frame in this project, it plays the video 'Why People Still Smoke' published by Forbes immediately above the pack.
During this time, if the button on the screen is clicked, it redirects to https://github.com/HuseyinBugraEKEN.
All these AR tech functions are provided with objects created through Vuforia.
**Please be advised that some of the images below may be disturbing.**



First, let's connect Vuforia with Unity. Click on 'Add Vuforia Engine to a Unity Project or upgrade to the latest version' to download it. 
Drag the downloaded file into your 3D Unity project and import it. 

Delete the Camera object and add the 'Vuforia Engine >> ARCamera' object instead.

In Vuforia, go to the target manager section and create a 'Generate Database'.
Add the image that should display the video when detected by the camera.
Upload the Database.

![Screenshot 2024-05-31 at 02 11 16](https://github.com/HuseyinBugraEKEN/AR-Project-vuforia/assets/133043999/679e8633-78db-4205-ad31-4d1132f2bbd9)

In Vuforia, go to the 'Licenses' section and click on 'Get Basic' to create a license key.
Enter a name for the license. Then click on the created license and copy the key.

![Screenshot 2024-05-31 at 02 11 08](https://github.com/HuseyinBugraEKEN/AR-Project-vuforia/assets/133043999/4d0050e9-4f47-41e7-ac46-7a8cc7209ee5)

Return to Unity, select the created ARCamera object, click on 'Open Vuforia Engine configuration' in the inspector window, 
and paste the copied key into the 'App License Key' field

![Screenshot 2024-05-31 at 02 48 41](https://github.com/HuseyinBugraEKEN/AR-Project-vuforia/assets/133043999/dd862343-14d9-4d16-86a2-41ad230ada64)

Import the Vuforia Database you downloaded into Unity. Then create a 'Vuforia Engine >> ImageTarget' object.
In the Inspector window of the ImageTarget object, ensure that you have placed the image in the 'Image Target Behaviour'.

![Screenshot 2024-05-31 at 00 05 34](https://github.com/HuseyinBugraEKEN/AR-Project-vuforia/assets/133043999/df0429c8-12d7-4360-a067-e5a69876708e)

Create a '3D Object >> Plane' object hierarchically inside the ImageTarget object.

![Screenshot 2024-05-31 at 02 51 38](https://github.com/HuseyinBugraEKEN/AR-Project-vuforia/assets/133043999/600560b4-3af0-46a1-8ba6-cfada5f3b5bc)

In the Inspector window of the created plane object, ensure you have placed the video to be played in the Video Player and uncheck the Play On Awake box. If the Audio Output Mode is different, change it to Audio Source.

![Screenshot 2024-05-31 at 00 06 36](https://github.com/HuseyinBugraEKEN/AR-Project-vuforia/assets/133043999/03f10ad7-878a-4802-8c71-919ac9906a0b)

Create a VideoController.cs file as shown in the Example Asset and drag it onto the ImageTarget object. Create a ButtonUrl1.cs file as shown in the Example Asset and drag it onto the ImageTarget object.
You can customize here which webpage the button will redirect to when clicked.

![Screenshot 2024-05-31 at 00 05 51](https://github.com/HuseyinBugraEKEN/AR-Project-vuforia/assets/133043999/04bd7694-408d-4c71-a2ff-ed0c3b9f14b9)

Hierarchically, create a 'UI >> Button' object inside the ImageTarget object.

![Screenshot 2024-05-31 at 02 57 42](https://github.com/HuseyinBugraEKEN/AR-Project-vuforia/assets/133043999/b04046a5-45fd-41fd-bcda-d408a0821591)

After making the necessary position adjustments, click on '+' under 'On Click()' in the Inspector window of the Button and make the following adjustments.

![Screenshot 2024-05-31 at 02 59 30](https://github.com/HuseyinBugraEKEN/AR-Project-vuforia/assets/133043999/ff6dbf4b-86c6-405c-bbcb-16e7508c665b)

You can run the code. Good luck!


![ARproject-Vuforia](https://github.com/HuseyinBugraEKEN/AR-Project-vuforia/assets/133043999/acea3c0b-0605-42e3-934b-61258c8aab91)


