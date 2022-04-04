using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] int damage;
    PlayerHealth playerHealth;


    // Start is called before the first frame update
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {       
        if (collision.CompareTag("Player"))
        {

            playerHealth.TakeHealth(damage);


        }
    }
}
