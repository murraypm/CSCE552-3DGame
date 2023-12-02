using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    public float interactDistance = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] playerRangeArray = Physics.OverlapSphere(transform.position, interactDistance);
            foreach (Collider collider in playerRangeArray)
            {
                if(collider.TryGetComponent(out B interactWithCube)){
                    interactWithCube.Interact();
                }
                if (collider.TryGetComponent(out C interactWithWood))
                {
                    interactWithWood.Interact();
                }
                if (collider.TryGetComponent(out D interactWithStone))
                {
                    interactWithStone.Interact();
                }
            }
        }
    }

    public B GetInteractable()
    {
        Collider[] playerRangeArray = Physics.OverlapSphere(transform.position, interactDistance);
        foreach (Collider collider in playerRangeArray)
        {
            if (collider.TryGetComponent(out B interactWithCube))
            {
                return interactWithCube;
            }

        }
        return null;
    }

    /*public C GetInteractable()
    {
        Collider[] playerRangeArray = Physics.OverlapSphere(transform.position, interactDistance);
        foreach (Collider collider in playerRangeArray)
        {
            if (collider.TryGetComponent(out C interactWithWood))
            {
                return interactWithWood;
            }

        }
        return null;
    }*/
}
