using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mimicCameraRotation : MonoBehaviour
{

    public GameObject obj;


    // Update is called once per frame
    void Update()
    {
        transform.rotation = obj.transform.rotation;
    }
}
