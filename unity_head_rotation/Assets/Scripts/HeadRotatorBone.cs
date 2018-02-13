using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotatorBone : MonoBehaviour {

	//Quaternion rotation = Quaternion.identity;
	// Radians to degree
	//float Rad2Degree = 180 / Mathf.PI;

	// Bone rotate vector
	public Vector3 rot = new Vector3(20, 30, 10);
	Animator anim;

	//  Bone stuff
	//Transform head;

	//  !!! Head bone rotation approach !!!
	void Start () {
		// get attached Animator controller
		anim = GetComponent<Animator>();
		//head = anim.GetBoneTransform(HumanBodyBones.Head);
	}

	// Thanks to ZayedUpal: https://stackoverflow.com/a/48754113/3399066
	// OnAnimatorIK() is called by the Animator Component immediately before it updates its internal IK system.
	// This callback can be used to set the positions of the IK goals and their respective weights.
	// https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnAnimatorIK.html
	void OnAnimatorIK (int layerIndex) {
		print ("OnAnimatorIK - running");
		// Convert bone rotate vector to Quaternion and rotate head bone
		anim.SetBoneLocalRotation(HumanBodyBones.Head, Quaternion.Euler(rot));
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
