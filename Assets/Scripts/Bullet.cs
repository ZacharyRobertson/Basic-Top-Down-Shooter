using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private AudioSource audi;
    // Use this for initialization
    void Start()
    {
        audi = GetComponent<AudioSource>();
        audi.pitch = Random.Range(0.1f, 3f);
        Destroy(gameObject, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward);
    }
}
