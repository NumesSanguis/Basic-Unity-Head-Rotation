using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotatorMuscle : MonoBehaviour {

	//   Human muscle stuff
	HumanPoseHandler humanPoseHandler;
	HumanPose humanPose;
	Animator anim;

	// Indexes to muscles
	// 9: Neck Nod Down-Up min: -40 max: 40
	// 10: Neck Tilt Left-Right min: -40 max: 40
	// 11: Neck Turn Left-Right min: -40 max: 40
	// 12: Head Nod Down-Up min: -40 max: 40
	// 13: Head Tilt Left-Right min: -40 max: 40
	// 14: Head Turn Left-Right min: -40 max: 40


	//   Bone stuff
	Transform head;

	// Muscle name and index lookup (See in Debug Log)
	void LookUpMuscleIndex() {
		string[] muscleName = HumanTrait.MuscleName;
		int i = 0;
		while (i < HumanTrait.MuscleCount)
		{
			Debug.Log(i + ": " + muscleName[i] +
				" min: " + HumanTrait.GetMuscleDefaultMin(i) + " max: " + HumanTrait.GetMuscleDefaultMax(i));
			i++;
		}
	}

	// Set character in fetus position
	void ResetMuscles() {
		// reset all muscles to 0
		for (int i = 0; i < humanPose.muscles.Length; i++)
		{
			//Debug.Log (humanPose.muscles [i]);
			humanPose.muscles[i] = 0;
		}
	}


	//   !!! Human Pose approach !!!
	void Start () {
		// https://forum.unity.com/threads/humanposehandler.430354/

		// get attached Animator controller
		anim = GetComponent<Animator>();

		// run this if you want the indexes to muscles on your character
		LookUpMuscleIndex();

		// TODO keeping body above plane
		//Vector3 current_position = transform.position;

		// get human pose handler
		humanPoseHandler = new HumanPoseHandler(anim.avatar, transform);
		// get human pose
		humanPose = new HumanPose();

		// TODO keeping body above plane
		//humanPose.bodyPosition = current_position;

		// reference pose to pose handler
		humanPoseHandler.GetHumanPose(ref humanPose);

		// set a specific musle; 9: Neck Nod Down-Up
        humanPose.muscles[9] = -20f; 
        Debug.Log(humanPose.muscles[9]);

        // use pose information to actually set the pose; doesn't work so far
        humanPoseHandler.SetHumanPose(ref humanPose);
    }

    // Update is called once per frame
    void Update () {
		//humanPoseHandler.SetHumanPose(ref humanPose);
	}
}
