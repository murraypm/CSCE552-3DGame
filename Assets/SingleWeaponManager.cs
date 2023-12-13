using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleWeaponManager : MonoBehaviour
{
    public float attackCoolDown = 2.0f;
    public int attackDamage = 2;
    float currentCoolDown = 0.0f;
    bool onCoolDown = false;
    List<GameObject> enemiesInReach = new List<GameObject>();
    //public LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //lineRenderer = this.GetComponentInChildren<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Clean up this logic it's a mess and can definitely be optimized
        if (enemiesInReach.Count > 0)
        {
            //lineRenderer.SetPosition(0, this.transform.position);
            //lineRenderer.SetPosition(1, enemiesInReach[0].transform.position);
        }
        if (!onCoolDown && enemiesInReach.Count > 0)
        {
            onCoolDown = true;
            currentCoolDown = 0.0f;
            GameObject enemy = enemiesInReach[0];
            EnemyManager enemyManager = enemy.GetComponent<EnemyManager>();
            enemyManager.health -= attackDamage;
            print("Enemy hit");
            if (enemyManager.health < 0.0)
            {
                enemiesInReach.Remove(enemy);
                Destroy(enemy);
            }
        } else if (currentCoolDown < 2.0f)
        {
            currentCoolDown += Time.deltaTime;
        } else if (currentCoolDown >= attackCoolDown)
        {
            onCoolDown = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!enemiesInReach.Contains(other.gameObject) && other.tag == "Enemy")
        {
            enemiesInReach.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (enemiesInReach.Contains(other.gameObject) && other.tag == "Enemy")
        {
            enemiesInReach.Remove(other.gameObject);
        }
    }
}
