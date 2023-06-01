using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
   protected float health = 50.0f;
   protected float Speed = 1000.0f;

     public float Health
    {
        get{ return health; }
    }

   public void TakeDamage(int damage)
   {
        health -= damage;
        Debug.Log("Enemy health : " + health);

        if(health <= 0)
        {
            Die();
            
        }
   }

   public void TakeDamage(float damage)
   {
        health -= (health * damage);
        Debug.Log("Enemy health : " + health);

        if(health <= 0)
        {
            Die();
        }
   }



    //충돌 감지 메서드(충돌이 시작할때 한번 실행)
    public void OnCollisionEnter2D(Collision2D coll)
    {
        //총알과 충돌했을 때(Tag 이름으로 gameObject 확인)
        if(coll.gameObject.CompareTag("Bullet"))
        {
            //Enemy 체력 감소
            TakeDamage(10);
            //충돌시 총알 소멸 (coll은 충돌 대상의 gameObject를 가져온다.)
            coll.gameObject.SetActive(false);
        }

    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public virtual void Move()
    {

    }
}
