using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    GameObject[] InventorySlots = new GameObject[3];
    Dictionary <string, bool> stackable = new Dictionary<string, bool>();
    // Start is called before the first frame update
    void Start()
    {
        stackable.Add("", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
