using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public CharacterController controller;

    public float speed = 12;
    public float maxSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        x = x.Remap(0,1,0,z);

        Debug.Log(x);

        transform.Rotate(0f,x,0f);

        
        Vector3 move = new Vector3(0f,0f,0f);

        if (z * speed > maxSpeed)
        {
            move = transform.forward * maxSpeed;
        }else{
            move = transform.forward * z;
        }
        
        controller.Move(move * Time.deltaTime);
    }

}
