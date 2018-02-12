using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotator : MonoBehaviour {

	//   Human muscle stuff
	HumanPoseHandler humanPoseHandler;
	HumanPose humanPose;
	Animator anim;

	//Quaternion rotation = Quaternion.identity;

	// Maybe indexes to muscles?
	//NeckDownUp = 6,
	//NeckLeftRight = 7,
	//NeckTurn = 8,
	//HeadDownUp = 9,
	//HeadTilt = 10,
	//HeadTurn = 11,


	//   Bone stuff
	Transform head;

	// Radians to degree
	//float Rad2Degree = 180 / Mathf.PI;


	//   !!! Human Pose approach !!!
	void Start () {
		// https://forum.unity.com/threads/humanposehandler.430354/

		// get attached Animator controller
		anim = GetComponent<Animator>();

		// get human pose handler
		humanPoseHandler = new HumanPoseHandler(anim.avatar, transform);
		// get human pose
		humanPose = new HumanPose();

		// reference pose to pose handler
		humanPoseHandler.GetHumanPose(ref humanPose);

		// reset all muscles to 0
		//for (int i = 0; i < humanPose.muscles.Length; i++)
		//{
		//	//Debug.Log (humanPose.muscles [i]);
		//	humanPose.muscles[i] = 0;
		//}

		// set a specific musle; 9 is head?
		humanPose.muscles [9] = 0.8f;

		// use pose information to actually set the pose; doesn't work so far
		humanPoseHandler.SetHumanPose(ref humanPose);

		//head = anim.GetBoneTransform(HumanBodyBones.Head);
		//Debug.Log (head);
	}
	
	// Update is called once per frame
	void Update () {
		humanPoseHandler.SetHumanPose(ref humanPose);
	}


	//   !!! Head bone rotation approach !!!
	//void Start () {
	//  // https://docs.unity3d.com/ScriptReference/Quaternion.Euler.html
	//	Quaternion rotation = Quaternion.Euler(new Vector3(20, 30, 10));
	//	Debug.Log ("" + rotation[0] + ", " + rotation[1] + ", " + rotation[2] + ", " + rotation[3]);
	//
	//	head = anim.GetBoneTransform(HumanBodyBones.Head);
	//	head.Rotate (rotation);
	//
	//	anim.SetBoneLocalRotation(HumanBodyBones.Head, rotation);
	//}
}
