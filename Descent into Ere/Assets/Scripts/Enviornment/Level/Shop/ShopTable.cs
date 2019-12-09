﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopTable : MonoBehaviour {
	public GameObject PressUp;
	public static int amountOfPlayerCurrency;
	public static bool ShopContainsPotion;
	public static string NameOfItem;
	public static int CostOfItem;
	public static int NumberOfItems;
	DbManager dataManager = DbManager.Instance;

	void Start(){
		PressUp.SetActive(false);
	}
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("Player")){
			PressUp.SetActive(true);
		}
		
	}
	void OnTriggerExit2D(Collider2D collider){
		if(collider.CompareTag("Player")){
			PressUp.SetActive(false);
		}
	}
	
}
