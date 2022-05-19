using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	private void Update()
    {
        print("H :- " + CrossPlatformInputManager.GetAxis("Horizontal")); 
        print("V :- " + CrossPlatformInputManager.GetAxis("Vertical")); 
    }
}
