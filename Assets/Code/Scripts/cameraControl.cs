using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    float mouseX = 0.0f;
    float mouseY = 0.0f;
    float rotX = 0.0f;
    float rotY = 0.0f;
    public float sensitivity = 10.0f;
    public GameObject CameraObject;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        //print(mouseX);
        //print(mouseY);
        rotX += mouseX * sensitivity * Time.deltaTime;
        rotY += mouseY * sensitivity * Time.deltaTime;
        rotY = Mathf.Clamp(rotY, -90.0f, 90.0f);

        this.transform.rotation = Quaternion.Euler(0.0f, rotX, 0.0f);
        CameraObject.transform.rotation = Quaternion.Euler(-rotY, rotX, 0.0f);
    }
}
