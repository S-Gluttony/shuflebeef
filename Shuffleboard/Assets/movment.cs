using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    public int point = 0;
    private Rigidbody rigidbody;
    public float speed = 0;
    public float leftspeed;
    public float rightspeed;
    public GameObject blueStone;
    private bool canSpawnblue = true;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, leftspeed));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, rightspeed));
        }

        if (Input.GetKey(KeyCode.Space))
        { 

            if (transform.position.x > 20)
            {
                rigidbody.AddForce(new Vector3(speed, 0, 0));
            }
        }

        if (Input.GetKey(KeyCode.P) && canSpawnblue)
        {
            Instantiate(blueStone);

            canSpawnblue = false;   
            
        }


    }

    
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            point++;
            print(point);
        }

        if (other.CompareTag("remove"))
        {
            print(0);

        }
    }
    private void OnTriggerEnter(Collision collision)
    {

       
    }

}
