using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    PlayerHealth playerHealth;

    public int healthBonus = 1;


    
    void Awake()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(playerHealth.health < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.health = playerHealth.health + healthBonus;
        }
    }
}
