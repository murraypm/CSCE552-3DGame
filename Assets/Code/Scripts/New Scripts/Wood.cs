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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        ///gui.GetComponent<resourceManager>().woodUp();
        Debug.Log("WoodInteracted!");
        //woodUp();
    }
}
