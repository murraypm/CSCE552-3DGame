using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class stoneHolder : MonoBehaviour
{
    public static int amountOfStone;
    [SerializeField] private AudioSource miningSound;
    public TextMeshProUGUI stoneCount;
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

    public void removeStone(int amount)
    {
        amountOfStone = amountOfStone - amount;
        stoneCount.text = "Stone: " + amountOfStone.ToString();
    }

    public int getStone()
    {
        return amountOfStone;
    }
}
