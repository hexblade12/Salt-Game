using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public static float totalHealth = 100;
    ///float healthChange;
    float healthBarLength = 1;
    public Image bar;
    
    public void HealthChange()
    {
        //test for total health
        totalHealth -= 5;
        //Changes the base 100 total health to fit the pixel length
        healthBarLength = totalHealth/100;
        //Changes the size of the health bar (Works)
        bar.transform.localScale = new Vector2 (healthBarLength, 1);
        // moves the bar over a bit so it doesn't move as much (WIP)
        //bar.transform.position = new Vector2(bar.transform.position.x+0.15f, bar.transform.position.y);
        
    }
}
