﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class PlayerHealth : MonoBehaviour
{
    //Variables for health and number of hearts
    public int health;
    public int numOfHearts;

    //Links the hearts to the script
    public SpriteRenderer[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        /*Makes sure the player's health
         * Doesn't exceed the number of hearts
         */
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }


        for (int i = 0; i < hearts.Length; i++)
        {
            /* Makes the game display a full heart
             * when the player is at full health
             */
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            /* Makes the game display an empty heart
             * when the player takes damage
             */
            else
            {
                hearts[i].sprite = emptyHeart;

            }

            /* Makes sure the health displayed
             * Isn't greater that the number of hearts
             */
            if(i < numOfHearts){
                hearts[i].enabled = true;
            }else{
                hearts[i].enabled = false;
            }
        }
    }
}