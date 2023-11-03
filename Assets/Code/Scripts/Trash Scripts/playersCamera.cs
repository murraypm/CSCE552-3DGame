using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playersCamera : MonoBehaviour
{
    public Vector2 turn;
    public float sens = 0.5f;
    public Vector3 deltaMove;
    public float speed = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        turn.y += Input.GetAxis("Mouse Y") * sens;
        turn.x += Input.GetAxis("Mouse X") * sens;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        deltaMove = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
        transform.Translate(deltaMove);
    }
}
