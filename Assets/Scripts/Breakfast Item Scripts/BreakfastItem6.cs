using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfastItem6 : ItemBase
{
    public override void saltCount()
    {
        itemSaltCount = 6;
        Debug.Log("Item6");
        base.saltCount();
    }
}
