using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementSounds : MonoBehaviour
{
    [SerializeField] private AudioSource walking;
    [SerializeField] private AudioSource running;
    private bool moving = false;
    // Start is called before the first frame update
    void Start()
    {
        running.enabled = false;
        walking.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        moving = (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D));

        if (Input.GetKey(KeyCode.LeftControl) && moving)
        {
            running.enabled = true;
            walking.enabled = false;
        }
        else if (moving)
        {
            running.enabled = false;
            walking.enabled = true;
        }
        else
        {
            walking.enabled = false;
        }
    }
}
