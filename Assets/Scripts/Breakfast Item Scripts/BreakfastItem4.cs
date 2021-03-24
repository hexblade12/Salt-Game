using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfastItem4 : ItemBase
{
    public override void saltCount()
    {
        itemSaltCount = 4;
        Debug.Log("Item4");
        base.saltCount();
    }
}
