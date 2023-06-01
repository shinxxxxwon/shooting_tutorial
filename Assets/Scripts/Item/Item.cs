using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{

    void Start()
    {
        DestroyAfterTime();
    }

    public abstract void DestroyAfterTime();
    public abstract void ApplyItem();

    public void DestroyThis()
    {
        Destroy(gameObject);
    }

    //충돌 체크
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("Player"))
        {
            ApplyItem();
        }
    }

    public void GetOpacity()
    {
        Color32 color = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Color32(color.r, color.g, color.b, 60);
    }
}

