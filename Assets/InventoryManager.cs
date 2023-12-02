using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private const int INVENTORY_SIZE = 3;
    GameObject[] inventory = new GameObject[INVENTORY_SIZE];
    int[] amount = new int[3];
    Dictionary<GameObject, int> stackLimit = new Dictionary<GameObject, int>();
    // Start is called before the first frame update
    private void Awake()
    {
        for (int i = 0; i < INVENTORY_SIZE; i++)
        {
            inventory[i] = null;
        }
        // TODO: define object's stack limit here
    }

    public bool AddItem(GameObject item)
    {
        if (stackLimit[item] > 1)
        {
            for (int i = 0; i < INVENTORY_SIZE; i++)
            {
                if (inventory[i] == item && amount[i] < stackLimit[item]) {
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
