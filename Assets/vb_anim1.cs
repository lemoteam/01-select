﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim1 : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObj;
	public Animator cubeAni;

	// Use this for initialization
	void Start () {
		vbBtnObj = GameObject.Find("selectSphere");
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		cubeAni.GetComponent<Animator>();
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb) {
		cubeAni.Play("sphere_animation");
		Debug.Log("Btn pressed");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		cubeAni.Play("none");
		Debug.Log("Btn released");
	} 

	// Update is called once per frame
	void Update () {
		
	}
}
