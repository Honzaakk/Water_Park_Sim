using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    public Transform camerapos;

    //PlayerMovement PM;
    //Animator anim;
    private void Start()
    {
        //PM = FindObjectOfType<PlayerMovement>();
        //anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = camerapos.position;
        //if (PM.horizontalInput == -1)
        //{
            //anim.SetBool("GoingLeft", true);
            
        //}
        //else if (PM.horizontalInput == 1)
        //{
            //.SetBool("GoingRight", true);
            
        //}
        //if (PM.horizontalInput == 0)
        //{
            //anim.SetBool("GoingLeft", false);
            //anim.SetBool("GoingRight", false);
            
        //}

        
    }
}
