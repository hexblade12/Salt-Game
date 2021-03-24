using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfastItem10 : ItemBase
{
    public override void saltCount()
    {
        itemSaltCount = 10;
        Debug.Log("Item10");
        base.saltCount();
    }
}
