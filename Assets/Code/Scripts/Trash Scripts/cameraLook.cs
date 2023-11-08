using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLook : MonoBehaviour
{
    public float CameraSpeed = 120.0f;
    public GameObject FollowObj;
    
    Vector3 FollowPos;
    public float lowerClampAngle = -80.0f;
    public float upperClampAngle = 80.0f;
    public float sensitivity = 100.0f;
    public GameObject CameraObj;
    public GameObject PlayerObj;
   
    public float camDistX;
    public float camDistY;
    public float camDistZ;
    
    public float mouseX;
    public float mouseY;
    float smoothX;
    float smoothY;
    
    public float rotX = 0.0f;
    public float rotY = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 rotation = transform.localRotation.eulerAngles;
        rotX = rotation.x;
        rotY = rotation.y;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        //mouseY = Input.GetAxis("Mouse Y");

        rotX += mouseX * sensitivity * Time.deltaTime;
        //rotY += mouseY * sensitivity * Time.deltaTime;

        //rotY = Mathf.Clamp(rotY, lowerClampAngle, upperClampAngle);
        Quaternion localRotation = Quaternion.Euler(0.0f, rotX, 0.0f);
        PlayerObj.transform.rotation = localRotation;
        //transform.rotation = localRotation;
    }

    void LateUpdate()
    {
        // CameraMove();
    }

    void CameraMove()
    {
        Transform focus = FollowObj.transform;

        float speed = CameraSpeed * Time.deltaTime;
        //Vector3.MoveTowards( <starting vect> , <ending vect>, <how fast> )
        transform.position = Vector3.MoveTowards(transform.position, focus.position, speed);
    }
}
