using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float spawnCounter;
   [SerializeField] float spawnTime = .3f;
    [SerializeField] float xOffset =19f;
    [SerializeField] float yOffset =14f;

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

        if(spawnCounter <= 0)
        {
            SetSpawnLocation();
            SpawnEnemy();

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
                spawnPoint = new Vector2(transform.position.x + xOffset, Random.Range(transform.position.y +yOffset, transform.position.y - yOffset));
                break; 
            //Spawn From Left
            case 2:
                spawnPoint = new Vector2(transform.position.x - xOffset, Random.Range(transform.position.y + yOffset, transform.position.y - yOffset));
                break;                
            //Spawn From Top
            case 3:
                spawnPoint = new Vector2(Random.Range(transform.position.x -xOffset, transform.position.x+xOffset), transform.position.y +yOffset);
                break; 
            //Spawn From Bottom
            case 4:
                spawnPoint = new Vector2(Random.Range(transform.position.x - xOffset, transform.position.x + xOffset), transform.position.y - yOffset);
                break;
        }
        spawnCounter = spawnTime;
    }

    void SpawnEnemy()
    {

        GameObject newEnemy = TierOneEnemy.instance.GetPooledObject();

        if (newEnemy == null)
        {
            return;
        }
        else
        {
            newEnemy.transform.position = spawnPoint;
            newEnemy.SetActive(true);
        }
    }
}
