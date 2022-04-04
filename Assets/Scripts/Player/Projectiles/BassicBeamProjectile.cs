using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BassicBeamProjectile : MonoBehaviour
{
    [SerializeField] float speed;
  
    int damage = 2;
    public int minDamage = 4;
    public int maxDamage = 10;
    public int damageModifier = 1;    
    
    private void OnEnable()
    {
        damage = Random.Range(minDamage, maxDamage) * damageModifier;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); 
    } 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeHealth(damage);
            gameObject.SetActive(false);
        }             
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
