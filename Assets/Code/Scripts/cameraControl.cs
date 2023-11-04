using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    float mouseX = 0.0f;
    float rotX = 0.0f;
    public float sensitivity = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        rotX += mouseX * sensitivity * Time.deltaTime;

        this.transform.rotation = Quaternion.Euler(0.0f, rotX, 0.0f);
    }
}
