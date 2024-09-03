using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;

    public Transform orientation;

    float verticalInput;
    public float horizontalInput;
    float UpInput;

    public Vector3 moveDirection;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        MoveInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MoveInput()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");
        
        if (Input.GetKey(KeyCode.Space))
        {
            UpInput = 1;
            
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            UpInput = -1;
            
        }
        else 
        {
            UpInput = 0;
            
        }
        
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput + orientation.up * UpInput;

        transform.position += moveDirection.normalized * playerSpeed * Time.deltaTime;
    }
}
