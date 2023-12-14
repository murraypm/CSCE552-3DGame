using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class woodHolder : MonoBehaviour
{
    public static int amountOfWood;
    [SerializeField] private AudioSource choppingSound;
    public TextMeshProUGUI woodCount;
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

    public void removeWood(int amount)
    {
        amountOfWood = amountOfWood - amount;
        woodCount.text = "Wood: " + amountOfWood.ToString();
    }

    public int getWood()
    {
        return amountOfWood;
    }
}
