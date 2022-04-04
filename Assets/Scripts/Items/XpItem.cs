using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XpItem : MonoBehaviour
{
    [SerializeField] float xpToGive = 10;
    [SerializeField] PlayerXpManager xpManger;

    private void Start()
    {
        xpManger = FindObjectOfType<PlayerXpManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            xpManger.GiveXp(xpToGive);
            gameObject.SetActive(false);
        }
    }
}
