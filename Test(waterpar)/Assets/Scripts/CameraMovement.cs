using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float RotationX;
    float RotationY;

    PlayerMovement PM;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PM = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        float mousX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mousY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        RotationX -= mousY;
        RotationY += mousX;

        RotationX = Mathf.Clamp(RotationX, -90f, 90f);

        transform.rotation = Quaternion.Euler(RotationX, RotationY, 0);
       
        orientation.rotation = Quaternion.Euler(0, RotationY, 0);
    }
}
