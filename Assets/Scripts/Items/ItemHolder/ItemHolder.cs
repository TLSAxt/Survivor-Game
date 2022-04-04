using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    [SerializeField] GameObject[] itemsToSpawn;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerProjectile"))
        {
            RollRandom();
        }
    }

    void RollRandom()
    {
        int randomNumber = Random.Range(0, 100);

        if (randomNumber >= 40)
        {
            if (itemsToSpawn[0] != null)
            {
                Instantiate(itemsToSpawn[0], transform.position, Quaternion.identity);
            }
        }
        if (randomNumber >= 20 && randomNumber < 40)
        {
            if (itemsToSpawn[1] != null)
            {
                Instantiate(itemsToSpawn[1], transform.position, Quaternion.identity);
            }
        }

        if (randomNumber >= 10 && randomNumber < 20)
        {
            if (itemsToSpawn[2] != null)
            {
                Instantiate(itemsToSpawn[2], transform.position, Quaternion.identity);
            }
        }

        if (randomNumber >= 5 && randomNumber < 10)
        {
            if (itemsToSpawn[3] != null)
            {
                Instantiate(itemsToSpawn[3], transform.position, Quaternion.identity);
            }
        }
        if (randomNumber >= 0 && randomNumber < 5)
        {
            if (itemsToSpawn[4] != null)
            {
                Instantiate(itemsToSpawn[4], transform.position, Quaternion.identity);
            }
        }

        gameObject.SetActive(false);
    }
}
