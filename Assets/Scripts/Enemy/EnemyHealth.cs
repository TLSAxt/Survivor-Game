using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 10f;

    [SerializeField] GameObject xpPrefab;

    private void OnEnable()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Add Death Effect

        int randomNumber = Random.Range(0, 100);
        if(randomNumber >= 30)
        {
            //will call pooled object later
            Instantiate(xpPrefab, transform.position, Quaternion.identity);
        }
        
        gameObject.SetActive(false);
    }

    public void TakeHealth(float damage)
    {
        health -= damage;
    }
}
