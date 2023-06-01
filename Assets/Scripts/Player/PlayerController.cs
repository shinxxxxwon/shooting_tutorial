using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* gameObject & transform & Vector

        bool bIsHidden = true;
        bool bIsDead = false;

        //gameObject -> 해당 스크립트가 부착된 게임 오브젝트
        gameObject.SetActive(bIsHidden); //object를 Hidden

        //Vector : 크기와 방향을 갖는 물리값 (x, y, z 좌표)\
        //Vector2 : (x, y)
        //Vector3 : (x, y, z)
        transform.position = Vector2.one; //(1, 1)

        Vector2 pos = transform.position;   //pos에 현재 게임 오브젝트의 좌표값 저장
        pos.x += 3; //(4,1)
        transform.position = pos;

        */

    }

    public float speed = 0.002f;
    public float bulletSpeed = 150;
    public GameObject BulletPrefab;
    public GameObject Gun;

    void Update()
    {
        // Input.GetKey() : 키보드의 입력을 받는 메서드
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed, 0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed, 0);
        } 
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(BulletPrefab);

            Vector3 bulletStartPosition = Gun.transform.position;
            bulletStartPosition.y += 0.3f;
             bullet.transform.position = bulletStartPosition;

            bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);
            
        }

        
    }

}
