using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prevPlayerMovement : MonoBehaviour
{
    public KeyCode jumpKey = KeyCode.Space;
    public KeyCode sprintKey = KeyCode.LeftControl;
    public KeyCode forwardKey = KeyCode.W;
    Rigidbody rb;
    public float moveSpeed = 10.0f;
    public float jumpForce = 5.0f;
    private float hor, ver;
    private bool onGround = true;

    [SerializeField] private AudioSource WalkingSoundEffect;
    [SerializeField] private AudioSource RunningSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(sprintKey))
        {
            RunningSoundEffect.Play();
            Debug.Log("Running");
            moveSpeed = 20.0f;
        } else if(hor+ver == 0)
        {
        }
        else
        {
            WalkingSoundEffect.Play();
            Debug.Log("Walking");
            moveSpeed = 10.0f;
        }

        this.transform.position += (transform.forward * ver + transform.right * hor).normalized * moveSpeed * Time.deltaTime;

        if (Input.GetKey(jumpKey) && onGround)
        {
            //stop running / walking sound
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }
    }
    private void OnCollisionEnter(Collision check)
    {
        if (check.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }

    private void OnCollisionExit(Collision check)
    {
        if (check.gameObject.CompareTag("Ground"))
        {
            onGround = false;
        }
    }
}
