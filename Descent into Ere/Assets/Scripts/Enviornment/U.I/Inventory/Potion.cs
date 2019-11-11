﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour {

    public Animator health;

    public GameObject potion;

    public void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
				PlayerHealth.Heal (health);
				Inventory.NumberOfItems--;
				Inventory.NumberOfPotions--;
			if (Inventory.NumberOfPotions <= 0) {
				potion.SetActive (false);
			}
        }
    }
}
