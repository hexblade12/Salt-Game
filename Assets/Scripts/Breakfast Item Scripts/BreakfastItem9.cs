using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfastItem9 : ItemBase
{
    public override void saltCount()
    {
        itemSaltCount = 9;
        Debug.Log("Item9");
        base.saltCount();
    }
}
