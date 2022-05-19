﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour {

	private GameObject player;  

	private void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	private void LateUpdate () {
		transform.LookAt(player.transform);
	}
}
