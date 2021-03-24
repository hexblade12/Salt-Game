using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfastItem8 : ItemBase
{
    public override void saltCount()
    {
        itemSaltCount = 8;
        Debug.Log("Item8");
        base.saltCount();
    }
}
