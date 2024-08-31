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
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mousX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mousY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
    }
}
