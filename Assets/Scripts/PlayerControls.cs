using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float maxSpeed = 5f;
    public GameObject bullet;

    private Rigidbody myRigi;

    // Use this for initialization
    void Start()
    {
        myRigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        StartCoroutine(Shoot());
    }
    void Movement()
    {
        //Make our character access the horizontal and vertical axis keys (direction buttons + WASD)
        float inputHoriz = Input.GetAxis("Horizontal");
        float inputVert = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(inputHoriz, 0, inputVert);

        if (myRigi.velocity.magnitude < maxSpeed)
        {
            myRigi.AddForce(force * moveSpeed);
        }
        
    }
    IEnumerator Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, transform.rotation);
            
            yield return new WaitForSeconds(0.2f);
        }
    }

    void OnCollisionEnter(Collision hit)
    {
        if(hit.collider.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
