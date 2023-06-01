using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Item
{
    public override void DestroyAfterTime()
    {
        Invoke("DestroyThis", 5.0f);
        Invoke("GetOpacity", 3.0f);
    }
    public override void ApplyItem()
    {
        DestroyThis();
    }
}
