using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("함수명", 시간) : 일정 시간 후 함수 실행
        Invoke("DestroySelf", 2.0f);
    }

    void DestroySelf()
    {
         Destroy(gameObject);
    }
}
