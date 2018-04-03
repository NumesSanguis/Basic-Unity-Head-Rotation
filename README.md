# NEWER APPROACH
This project served as a way to connect Python with Unity 3D. However, in my current project (https://github.com/NumesSanguis/FACSvatar) I switched to ZeroMQ for this, which is more stable and more robust than the code found here. So I would recommend looking at that code.

# Basic-Unity-Head-Rotation
Moving a humanoid head in Unity 3D by scripting. Both by head bone rotation (Bone scene) and muscle values (Muscle scene).

# Run instructions
1) Start up Unity and open this project
2) Select Bone or Muscle scene
3) Run :)

# Notes
- Don't add an animator when manipulating the muscle values through a script (or maybe move muscle code out of void Start()?)
- When empty animator added, fetus position (same as all muscle values 0): https://answers.unity.com/questions/1436768/empty-animator-changes-humanoid-pose-on-play.html#

# Repo sources
- Humanoid model: Manuel Bastioni Lab / MB (Blender plugin, http://www.manuelbastioni.com/index.php) 
- MB forum with Unity tut links: https://blenderartists.org/forum/showthread.php?391401-Addon-Manuel-Bastioni-Lab-turns-Blender-in-a-laboratory-for-3d-humanoids-creation/page55

# Interesting resources
- Question that motivated this repo: https://stackoverflow.com/questions/48740511/unity-3d-move-humanoid-head-muscles-using-script
- Simlar question as me: https://answers.unity.com/questions/824628/can-we-using-script-to-moving-the-muscles-in-unity.html?childToView=1467462#
- Quaternion.Euler: https://docs.unity3d.com/ScriptReference/Quaternion.Euler.html
- Unity Human Pose: https://forum.unity.com/threads/move-humanoid-muscles.379500/
- Unity Human Pose 2: https://forum.unity.com/threads/update-humanoid-muscle.375036/
- Humanoid rigging muscles: https://docs.unity3d.com/Manual/MuscleDefinitions.html
- Unity rotate head bone: https://forum.unity.com/threads/head-bone-wont-rotate-via-script.442351/
- Unity docs - Human Pose Handler: https://docs.unity3d.com/ScriptReference/HumanPoseHandler.html
- Unity docs - Human Trait: https://docs.unity3d.com/ScriptReference/HumanTrait.html
- Unity docs - Human Bone: https://docs.unity3d.com/ScriptReference/HumanBone.html
- Unity docs - Bone Local Rotation: https://docs.unity3d.com/ScriptReference/Animator.SetBoneLocalRotation.html
- Unity docs - Animator.OnAnimatorIK: https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnAnimatorIK.html
- Unity docs - Animator.SetIKPosition: https://docs.unity3d.com/ScriptReference/Animator.SetIKPosition.html
- Rotate bone during animation: https://answers.unity.com/questions/126368/how-to-rotate-a-bone-during-an-animation.html
- InstantVR (didn't try): https://assetstore.unity.com/packages/tools/animation/instantvr-free-23011

