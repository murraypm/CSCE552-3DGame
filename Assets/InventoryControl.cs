using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{
    float input = 0.0f;
    int selectedSlot = 0;
    public GameObject[] slots = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Mouse ScrollWheel");
        if (input > 0.0f)
        {
            slots[selectedSlot].SetActive(false);
            if (selectedSlot == 0)
            {
                selectedSlot = 2;
            } else
            {
                selectedSlot--;
            }
            slots[selectedSlot].SetActive(true);

        } else if (input < 0.0f)
        {
            slots[selectedSlot].SetActive(false);
            if (selectedSlot == 2)
            {
                selectedSlot = 0;
            }
            else
            {
                selectedSlot++;
            }
            slots[selectedSlot].SetActive(true);
        }
    }
}
