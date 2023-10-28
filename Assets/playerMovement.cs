using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    float moveSpeed;
    float hor, ver;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal") * moveSpeed;
        ver = Input.GetAxis("Vertical") * moveSpeed;

        //rb.velocity = new Vector3(hor, rb.velocity.y, ver).normalized * moveSpeed;
        rb.velocity = new Vector3(hor, rb.velocity.y, ver);

        if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector3(hor, 5, ver);
        }
        
    }
}
