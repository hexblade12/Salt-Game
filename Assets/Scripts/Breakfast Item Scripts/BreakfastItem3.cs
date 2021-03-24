using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfastItem3 : ItemBase
{
    public override void saltCount()
    {
        itemSaltCount = 3;
        Debug.Log("Item3");
        base.saltCount();
    }
}
