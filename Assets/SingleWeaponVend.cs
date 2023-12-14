using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleWeaponVend : MonoBehaviour
{
    public GameObject woodHolder;
    public GameObject stoneHolder;
    public GameObject InventoryManager;
    public GameObject SingleWeaponPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyWeapon()
    {
        if (woodHolder.GetComponent<woodHolder>().getWood() >= 3 && stoneHolder.GetComponent<stoneHolder>().getStone() >= 2)
        {
            if (InventoryManager.GetComponent<InventoryManager>().AddItem(Instantiate(SingleWeaponPrefab)))
            {
                woodHolder.GetComponent<woodHolder>().removeWood(3);
                stoneHolder.GetComponent<stoneHolder>().removeStone(2);
            }
        }
    }
}
