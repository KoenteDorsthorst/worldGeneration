using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // float speed = 0.2F;

    int movementSpeed = 5;

    private void Start()
    {
        
    }

    void Update()
    {


        float x = 5 * Input.GetAxis("Mouse X");
        transform.Rotate(0, x, 0);


        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");


        //Vector3 movement = new Vector3(h, 0, v) * speed;
        //transform.position += movement.x * Vector3.forward;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * movementSpeed;
        }


    }
}
