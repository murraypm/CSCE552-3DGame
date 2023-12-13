using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoneHolder : MonoBehaviour
{
    public static int amountOfStone;
    [SerializeField] private AudioSource miningSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addStone()
    {
        miningSound.Play();
        amountOfStone++;
    }
}
