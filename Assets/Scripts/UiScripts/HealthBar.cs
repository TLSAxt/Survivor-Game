using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] PlayerHealth playerHealth;
    [SerializeField] Image healthFillImage;
    [SerializeField] SpriteRenderer healthFillSprite;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthFillImage != null)
        {
            
            healthFillImage.fillAmount = playerHealth.healthFraction;
        }

        if(healthFillSprite != null)
        {
            healthFillSprite.transform.localScale = new Vector2( playerHealth.healthFraction, healthFillSprite.transform.localScale.y) ;
        }
    }
}
