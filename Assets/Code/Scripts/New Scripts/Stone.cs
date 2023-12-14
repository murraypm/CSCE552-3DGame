using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stone : MonoBehaviour
{
    //public GameObject gui;
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI stoneCount;
    [SerializeField] private stoneHolder _stone;
    [SerializeField] private GameObject stone;
    [SerializeField] private int durability = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact()
    {
        _stone.addStone();
        durability--;
        if (durability <= 0)
        {
            stone.SetActive(false);
        }
        stoneCount.text = "Stone: " + stoneHolder.amountOfStone.ToString();
        //Debug.Log("StoneInteracted!");
    }
}
