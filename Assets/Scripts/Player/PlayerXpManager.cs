using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerXpManager : MonoBehaviour
{
    float currentXp = 0;
    [SerializeField] float maxXp = 83;
    public float xpModifier = 1;
    public int level = 1;
    bool isLevelingUp;

    [SerializeField] Image xpFillBar;

    // Update is called once per frame
    void Update()
    {
        SetFillAmount();
    }

    void SetFillAmount()
    {
        xpFillBar.fillAmount = currentXp / maxXp;

        if (currentXp >= maxXp)
        {
            isLevelingUp = true;
            LevelUp();
        }
    }

    void LevelUp()
    {
        float xpOverage= currentXp - maxXp;
      
        if (isLevelingUp)
        {
            maxXp = maxXp * 1.3015f;
            currentXp = xpOverage;
            level++;
            isLevelingUp = false;   
        }        
    }

    public void GiveXp(float xpToGive)
    {
        xpToGive = xpToGive * xpModifier;

        currentXp += xpToGive;
       
    }
}
