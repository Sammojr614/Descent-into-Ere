﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {
void OnMouseDown(){
	if(Input.GetMouseButtonDown(0)){
		Application.Quit();
	}
}
}