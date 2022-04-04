using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUpItem : MonoBehaviour
{
    [SerializeField] float healthToGive = 2;

    [SerializeField] PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            healthToGive = playerHealth.maxHealth * .25f;
            playerHealth.RecieveHealth((int)healthToGive);

            gameObject.SetActive(false);
        }
    }
}
