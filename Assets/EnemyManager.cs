using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float speed = 1.0f;
    //public GameObject HPGui;
    public int health = 5;
    Transform nearestWall = null;

    // Start is called before the first frame update 
    void Start()
    {
        float minDistance = Mathf.Infinity;
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Wall"))
        {
            if (Vector3.Distance(go.transform.position, transform.position) < minDistance)
            {
                minDistance = Vector3.Distance(go.transform.position, transform.position);
                nearestWall = go.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, nearestWall.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            GameObject.Find("HPGUI").GetComponent<wallHealth>().DamageWall(4);
            gameObject.GetComponent<Rigidbody>().AddForce(collision.GetContact(0).normal * 5, ForceMode.Impulse);
        }
    }
}
