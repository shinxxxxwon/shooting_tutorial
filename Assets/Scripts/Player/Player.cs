using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float health = 100.0f;

   public void TakeDamage(float damage)
   {
        health -= damage;
        Debug.Log("Player health : " + health);

        if(health <= 0)
        {
            Die();
        }
   }

    public float Health
    {
        get{ return health; }
    }

    //충돌 감지 메서드(충돌이 시작할때 한번 실행)
    public void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("Enemy"))
        {
            //Player 체력 감소
            TakeDamage(10);
            Destroy(coll.gameObject);
        }

    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
