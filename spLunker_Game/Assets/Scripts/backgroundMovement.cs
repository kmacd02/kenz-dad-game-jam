using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//The goal of this script is to make it so the background tilemap moves with the camera, so there is never an area without a background.


public class backgroundMovement : MonoBehaviour
{
    //public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Transform camTransform = Camera.main.transform;
        //Vector3 forwardMovement = camTransform.forward * Input.GetAxis("Vertical");
        //Vector3 horizontalMovement = camTransform.right * Input.GetAxis("Horizontal");
        //Vector3 movement = Vector3.ClampMagnitude(forwardMovement + horizontalMovement, 1);
        //transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
