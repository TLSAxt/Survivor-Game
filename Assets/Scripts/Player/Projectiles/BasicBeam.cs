using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBeam : MonoBehaviour
{

    [SerializeField] float fireDelayCount;
    [SerializeField] float fireDelayTime = .2f;
    
    [SerializeField] float speed = 50;   
   
    [SerializeField] GameObject projectile;

    GameObject target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FindClosestEnemy();
        fireDelayCount -= Time.deltaTime;
       
        if (target != null)
        {           

            Vector2 direction = target.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

            if (fireDelayCount <= 0)
            {
                Instantiate(projectile, transform.position, transform.rotation);
                fireDelayCount = fireDelayTime;
            }

            if (!target.activeInHierarchy)
            {
                target = null;
            }
        }


    }


    void FindClosestEnemy()
    {
        float distanceToClosestEnemy = Mathf.Infinity;
        EnemyMovement closestEnemy = null;
        EnemyMovement[] allEnemies = GameObject.FindObjectsOfType<EnemyMovement>();

        foreach (var currentEnemy in allEnemies)
        {
            float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;

            if (distanceToEnemy < distanceToClosestEnemy)
            {
                distanceToClosestEnemy = distanceToEnemy;
                closestEnemy = currentEnemy;
                target = closestEnemy.gameObject;
            }
        }

        if(target!= null)
        Debug.DrawLine(this.transform.position, target.transform.position);
    }

}
