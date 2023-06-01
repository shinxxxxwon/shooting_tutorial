using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : Item
{
     public override void DestroyAfterTime()
    {
        Invoke("DestroyThis", 3.0f);
        Invoke("GetOpacity", 1.5f);
    }

    
    public override void ApplyItem()
    {
        GameObject player = GameObject.Find("Player");
        PlayerController playerController = player.GetComponent<PlayerController>();
        playerController.speed *= 2.0f;

        DestroyThis();
    }

}
