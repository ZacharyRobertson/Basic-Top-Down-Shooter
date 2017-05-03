using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rigid;
    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rigid.AddForce(1, 0, -2);
    }

    void OnCollisionEnter(Collision hit)
    {
        if(hit.collider.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }


}
