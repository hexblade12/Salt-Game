using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakfastItem7 : ItemBase
{
    public override void saltCount()
    {
        itemSaltCount = 7;
        Debug.Log("Item7");
        base.saltCount();
    }
}
