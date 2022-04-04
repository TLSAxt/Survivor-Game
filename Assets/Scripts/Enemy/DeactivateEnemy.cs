using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateEnemy : MonoBehaviour
{

    EnemySpawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        spawner = FindObjectOfType<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > spawner.transform.position.x + 40)
        {
            gameObject.SetActive(false);
        }

        if (transform.position.x < spawner.transform.position.x - 40)
        {
            gameObject.SetActive(false);
        }

        if (transform.position.y < spawner.transform.position.y - 30)
        {
            gameObject.SetActive(false);
        }

        if (transform.position.y > spawner.transform.position.y + 30)
        {
            gameObject.SetActive(false);
        }
    }
}
