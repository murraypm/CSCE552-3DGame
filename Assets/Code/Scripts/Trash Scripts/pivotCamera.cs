using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform cameraPosition;
    public float pLerp = .02f;
    public float rLerp = .01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, cameraPosition.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, cameraPosition.rotation, rLerp);
    }
}
