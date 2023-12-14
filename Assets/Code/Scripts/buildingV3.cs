using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingV3 : MonoBehaviour
{
    public GameObject buildModel;
    public Transform PlayerRaycast;

    public Transform PlayerBuilt;
    public GameObject invUI;
    public GameObject InventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Build(buildModel);
        }
        if (Input.GetMouseButtonDown(1))
        {
            DestroyBuild();
        }
    }

    void Build(GameObject bm)
    {
        if (InventoryManager.GetComponent<InventoryManager>().inventory[invUI.GetComponent<InventoryControl>().selectedSlot] == null)
        {
            return;
        }
        if (Physics.Raycast(PlayerRaycast.position, PlayerRaycast.forward, out RaycastHit hitinfo))
        {
            //Debug.Log(hitInfo.transform.name);
            if(hitinfo.transform.tag == "Build")
            {
                Vector3 placePosition = new Vector3(Mathf.RoundToInt(hitinfo.point.x), Mathf.RoundToInt(hitinfo.point.y), Mathf.RoundToInt(hitinfo.point.z));
                Instantiate(bm, placePosition, Quaternion.identity, PlayerBuilt);
                DestroyImmediate(InventoryManager.GetComponent<InventoryManager>().inventory[invUI.GetComponent<InventoryControl>().selectedSlot], true);
            }
            //Vector3 placePosition = new Vector3(Mathf.RoundToInt(hitinfo.point.x), Mathf.RoundToInt(hitinfo.point.y), Mathf.RoundToInt(hitinfo.point.z));
            //Instantiate(bm, placePosition, Quaternion.identity);
        }
        //Physics.Raycast(PlayerRaycast.position, PlayerRaycast.forward, out RaycastHit hitinfo)
    }

    void DestroyBuild()
    {
        if(Physics.Raycast(PlayerRaycast.position, PlayerRaycast.forward, out RaycastHit hitinfo))
        {
            if(hitinfo.transform.tag == "Break")
            {
                Destroy(hitinfo.transform.gameObject);
            }
        }
    }

}
