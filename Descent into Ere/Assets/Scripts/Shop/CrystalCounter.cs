﻿using System;
using UnityEngine;
using System.Collections.Generic;

public class CrystalCounter: MonoBehaviour{
	public GameObject[] FirstDidget;
	public GameObject[] SecondDidget;
	public static int FirstDigt;
	public static  int SecndDigt;
	public static int ThirdDiget;

	void Start(){
		//First Didget Deactivation, At least the ones not needed on Scene Load
		foreach (var firstNumber in FirstDidget) {
			for (var i = 0; i < FirstDidget.Length; i++) {
				FirstDidget [i].SetActive (false);
			}
		}
		//When Changing Scenes Disabling the Numbers that aren't needed
		foreach (var secondNumber in SecondDidget) {
			for(var i = 0; i < SecondDidget.Length; i++){
				SecondDidget [i].SetActive (false);
			}
		}
	}
	void Update(){
		if (SecndDigt <= 9) {
			
		}
		//Setting the Numbers
		if (ThirdDiget >= 9) {
			ThirdDiget = 0;
			SecndDigt++;
		}
		if (SecndDigt >= 9) {
			SecndDigt = 0;
			FirstDigt++;
		}
		if (FirstDigt >= 9) {
			ThirdDiget = 9;
		}
		if (FirstDigt < 1) {
			SecondDidget [ThirdDiget].SetActive (true);

		}
	}
}