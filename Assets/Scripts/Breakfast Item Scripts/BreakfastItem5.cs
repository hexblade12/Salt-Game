using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfastItem5 : ItemBase
{
    public override void saltCount()
    {
        itemSaltCount = 5;
        Debug.Log("Item5");
        base.saltCount();
    }
}
