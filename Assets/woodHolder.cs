using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodHolder : MonoBehaviour
{
    public static int amountOfWood;
    [SerializeField] private AudioSource choppingSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addWood()
    {
        choppingSound.Play();
        amountOfWood++;
    }
}
