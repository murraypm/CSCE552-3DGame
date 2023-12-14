using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private const int INVENTORY_SIZE = 3;
    public GameObject[] inventory = new GameObject[INVENTORY_SIZE];
    int[] amount = new int[3];
    Dictionary<string, int> stackLimit = new Dictionary<string, int>();
    public GameObject[] sprites = new GameObject[INVENTORY_SIZE];
    // Start is called before the first frame update
    private void Awake()
    {
        for (int i = 0; i < INVENTORY_SIZE; i++)
        {
            inventory[i] = null;
        }

        // TODO: define object's stack limit here
    }

    private void Update()
    {
        for (int i =0; i < inventory.Length; i++)
        {
            if (inventory[i] != null && !sprites[i].activeSelf)
            {
                sprites[i].SetActive(true);
            } else if (inventory[i] == null && sprites[i].activeSelf)
            {
                sprites[i].SetActive(false);
            }
        }
    }

    public bool AddItem(GameObject item)
    {
        if (stackLimit[item.tag] > 1)
        {
            for (int i = 0; i < INVENTORY_SIZE; i++)
            {
                if (inventory[i] == item && amount[i] < stackLimit[item.tag]) {
                    amount[i]++;
                    return true;
                }
            }
        } else
        {
            for (int i = 0; i < INVENTORY_SIZE; i++)
            {
                if (inventory[i] == null)
                {
                    inventory[i] = item;
                    return true;
                }
            }
        }
        return false;
    }
}
