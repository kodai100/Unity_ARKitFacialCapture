# ARKit Facial Controller / Recorder

![thumbnail](https://github.com/ProjectBLUE-000/Unity_ARKitFacialCapture/blob/master/Thumbnails/thumbnail.gif)

## ZigSim Controller
We can control character's blendshape with [ZigSim](https://zig-project.com/) OSC signals.

### ARKit Facial Control script
First, we have to register mappings between ARKit's blendshape and Character's blendshapes.
Attatch a ARKitFacialControl.cs to arbitrary object.

![ARKitFacialControl](https://github.com/ProjectBLUE-000/Unity_ARKitFacialCapture/blob/master/Thumbnails/ARKitFacialControl.png)

And next, set a SkinnedMeshRenderer component you want to drive with ARKit and push update button.
Then in the Blend Shape Mappting folding field, you should set all blendshape mappings and strength with each pulldown and float field.

### ZigSim Facial Control script
Second, we have to attatch a ZigSimFacialControl.cs to arbitrary object to communicate with ZigSim using OSC.

![ZigSimFacialControl](https://github.com/ProjectBLUE-000/Unity_ARKitFacialCapture/blob/master/Thumbnails/ZigSimFacialControl.png)

Set a open port number and ARKit Facial Control created in previous section.
Text is for debbung use.

Finally we can drive with character's blendshape with ZigSim.
More information must be found in RecorderScene.unity.

## Recorder
ZigSimFacialControl.cs has a recording functionality.
To record your facial expression, simply call Record Start/Stop function externally.

In the sample scene, I called these functions with uGUI button components.
![Record](https://github.com/ProjectBLUE-000/Unity_ARKitFacialCapture/blob/master/Thumbnails/Record.png)

Recorded file (.byte) will be generated in user's Desktop when stop recording.

## Player
We can drive facial expression with recorded data.

First, we need ARKitFacialControl component described in [ARKit Facial Control script section](# ARKit Facial Control script).

![Player](https://github.com/ProjectBLUE-000/Unity_ARKitFacialCapture/blob/master/Thumbnails/Player.png)

Attatch a FaceRecordDataReader.cs and fill Facial Control field with ARKitFacialControl component we created.
And add recorded bytes files to your unity project, we can put these asset in Asset field.

Once you chosed bytes file you want to playback, drag drop this GameObject to your timeline.
Control Track will be automatically created and we can playback with moving timeline cursor.

![Timeline](https://github.com/ProjectBLUE-000/Unity_ARKitFacialCapture/blob/master/Thumbnails/Timeline.png)

# LICENSE
This project is distributed as [MIT License](https://github.com/ProjectBLUE-000/Unity_ARKitFacialCapture/blob/master/LICENSE.md).

But we use some package in this project, so please see each licence.md files.

* OSC : [https://github.com/nobnak/unity-osc](https://github.com/nobnak/unity-osc)
* UniRx : [https://github.com/neuecc/UniRx](https://github.com/neuecc/UniRx)
* ZeroFormatter : [https://github.com/neuecc/ZeroFormatter](https://github.com/neuecc/ZeroFormatter)
* Sloth Model : [https://github.com/Unity-Technologies/arfoundation-samples](https://github.com/Unity-Technologies/arfoundation-samples)