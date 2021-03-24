using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    public float itemSaltCount;

    public virtual void saltCount()
    {
        //Subtracts salt from health
        HealthBar.totalHealth -= itemSaltCount;
        //I think it would be a good idea to call the nezt panel from in here
    }

}
