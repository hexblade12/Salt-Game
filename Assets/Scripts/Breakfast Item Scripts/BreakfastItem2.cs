using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfastItem2 : ItemBase
{
    public override void saltCount()
    {
        itemSaltCount = 2;
        Debug.Log("Item2");
        base.saltCount();
    }
}
