using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TierOneEnemy : MonoBehaviour
{
    public static TierOneEnemy instance;
    public GameObject prefab;
    public List<GameObject> pooledObjects;

    public int objectsInPool = 20;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < objectsInPool; i++)
        {
            GameObject instantiatedObject = Instantiate(prefab);
            instantiatedObject.SetActive(false);
            pooledObjects.Add(instantiatedObject);
        }

    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
