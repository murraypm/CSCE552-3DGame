using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Wood : MonoBehaviour
{
    //public GameObject gui;
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI woodCount;
    [SerializeField] private woodHolder _wood;
    [SerializeField] private GameObject wood;
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
        _wood.addWood();
        durability--;
        if (durability <= 0)
        {
            wood.SetActive(false);
        }
        woodCount.text = "Wood: " + woodHolder.amountOfWood.ToString();
    }
}
