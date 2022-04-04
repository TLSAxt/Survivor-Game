using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolderSpawner : MonoBehaviour
{
    float spawnCounter;
    [SerializeField] float spawnTime = 5f;
    [SerializeField] float xOffset = 19f;
    [SerializeField] float yOffset = 14f;

    [SerializeField] GameObject[] itemHolders;

    int itemHolderToSpawn = 0;

    Vector2 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = spawnPoint;

        SetSpawnTime();

        if (spawnCounter <= 0)
        {
            SetSpawnLocation();
            SpawnHolder();

        }


        Debug.DrawRay(spawnPoint, Vector2.up);
    }

    void SetSpawnTime()
    {
        spawnCounter -= Time.deltaTime;
    }

    void SetSpawnLocation()
    {

        int randomNumber = Random.Range(1, 5);

        switch (randomNumber)
        {
            //Spawn From Right
            case 1:
                spawnPoint = new Vector2(transform.position.x + xOffset, Random.Range(transform.position.y + yOffset, transform.position.y - yOffset));
                break;
            //Spawn From Left
            case 2:
                spawnPoint = new Vector2(transform.position.x - xOffset, Random.Range(transform.position.y + yOffset, transform.position.y - yOffset));
                break;
            //Spawn From Top
            case 3:
                spawnPoint = new Vector2(Random.Range(transform.position.x - xOffset, transform.position.x + xOffset), transform.position.y + yOffset);
                break;
            //Spawn From Bottom
            case 4:
                spawnPoint = new Vector2(Random.Range(transform.position.x - xOffset, transform.position.x + xOffset), transform.position.y - yOffset);
                break;
        }
        spawnCounter = spawnTime;
    }

    void SpawnHolder()
    {


        if (itemHolderToSpawn >= itemHolders.Length)
        {
            itemHolderToSpawn = 0;
        }

        if (GameManager.minutes < 2)
        {
            if (itemHolderToSpawn < 3)
            {
                if (!itemHolders[itemHolderToSpawn].activeInHierarchy)
                {
                    itemHolders[itemHolderToSpawn].transform.position = spawnPoint;
                    itemHolders[itemHolderToSpawn].SetActive(true);
                    SetSpawnLocation();
                }
            }
        }

        if (GameManager.minutes >= 2 && GameManager.minutes < 5)
        {
            if (itemHolderToSpawn < 6)
            {
                if (!itemHolders[itemHolderToSpawn].activeInHierarchy)
                {
                    itemHolders[itemHolderToSpawn].transform.position = spawnPoint;
                    itemHolders[itemHolderToSpawn].SetActive(true);
                    SetSpawnLocation();
                }
            }
        }

        if (GameManager.minutes >= 5 && GameManager.minutes < 8)
        {
            if (itemHolderToSpawn < 8)
            {
                if (!itemHolders[itemHolderToSpawn].activeInHierarchy)
                {
                    itemHolders[itemHolderToSpawn].transform.position = spawnPoint;
                    itemHolders[itemHolderToSpawn].SetActive(true);
                    SetSpawnLocation();
                }
            }
        }

        if (GameManager.minutes >= 8)
        {
            if (!itemHolders[itemHolderToSpawn].activeInHierarchy)
            {
                itemHolders[itemHolderToSpawn].transform.position = spawnPoint;
                itemHolders[itemHolderToSpawn].SetActive(true);
                SetSpawnLocation();
            }
        }

        itemHolderToSpawn++;
    }
}
