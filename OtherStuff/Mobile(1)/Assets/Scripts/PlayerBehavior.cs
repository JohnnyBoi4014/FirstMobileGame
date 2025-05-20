using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehavior : MonoBehaviour
{

    /// <summary>
    /// A reference to the RigidBody component TEST 1
    /// </summary>
    private Rigidbody rb;

    // SET SPEED TO THIS WHEN TESTING NORMAL GAME 
    [Tooltip("How fast the ball moves left/right manually")]
    public float dodgeSpeed = 5;

    // SET SPEED TO THIS WHEN TESTING NEW ADDITION
    //public float dodgeSpeed = 7.5f;

    [Tooltip("How fast the ball moves forward automatically")]
    [Range(0,10)]
    public float rollSpeed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /*
    
    // Update is called once per frame
    void Update()
    {
        //var horizontalSpeed = Input.GetAxis("Horizontal") * dodgeSpeed;

        //rb.AddForce(horizontalSpeed, 0, rollSpeed);
    }

    */

    /// <summary>
    /// prime place to put physics calc happening over a period of time
    /// </summary>
    void FixedUpdate()
    {
        var horizontalSpeed = Input.GetAxis("Horizontal") * dodgeSpeed;

        rb.AddForce(horizontalSpeed, 0, rollSpeed);
    }
}
