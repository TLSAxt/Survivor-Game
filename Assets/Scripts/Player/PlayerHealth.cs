using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int health;
    public int maxHealth = 10;
    public float healthFraction;

    float damageCounter;
    [SerializeField] float damageTime = .5f;

    bool died;

    // Start is called before the first frame update
    void Start()
    {
        died = false;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 && !died)
        {
            Die();
        }
        SetInvulnerability();
      
    }

    void SetInvulnerability()
    {
        damageCounter -= Time.deltaTime; 
        //Change Sprite Appearance
    }

    public void RecieveHealth(int healthToRecieve)
    {
        health += healthToRecieve;

        if (health >= maxHealth)
        {
            health = maxHealth;
        }

        healthFraction = (float)health / (float)maxHealth;
    }

    public void TakeHealth(int damageToTake)
    {
        if (damageCounter <= 0)
        {
            Debug.Log(damageToTake + " damage Taken at " + Time.timeSinceLevelLoad + " seconds.");
            health -= damageToTake;
            damageCounter = damageTime;
        }

        if (health <= 0)
        {
            health = 0;
        }

        healthFraction = (float)health / (float)maxHealth;
    }
    void Die()
    {
        died = true;
        //Things that when the player dies
        Debug.Log("You Died!!!!");
    }
}
