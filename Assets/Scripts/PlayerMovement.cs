using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forwardForce = 1500f;
    public float sideForce = 25f;
    public Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World!");
        //rigidBody.useGravity = false;
        //rigidBody.AddForce(0, )
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D)){
            rigidBody.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);       
        }

        if (Input.GetKey(KeyCode.A)){
            rigidBody.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
