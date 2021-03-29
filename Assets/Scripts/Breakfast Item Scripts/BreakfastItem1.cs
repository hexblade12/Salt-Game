using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfastItem1 : ItemBase
{
    public override void saltCount()
    {
        itemSaltCount = 50;
        Debug.Log("Item1");
        base.saltCount();
    }
}
