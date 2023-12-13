using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject timeController;
    public DateTime time;
    private int day;
    Random rand;
    float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        time = timeController.GetComponent<TimeController>().time;
        day = timeController.GetComponent<TimeController>().startDay;
        rand = new Random();
    }

    // Update is called once per frame
    void Update()
    {
        time = timeController.GetComponent<TimeController>().time;
        day = timeController.GetComponent<TimeController>().startDay;
        //print(time.Hour);
        if (time.Hour == 19 && time.Minute == 0 && timer > 3.0f)
        {
            //print("test");
            //print(day);
            // Maybe consider changing so sides are picked randomly
            switch (day)
            {
                case 0:
                    print("test");
                    spawnEnemies(5, 0);
                    break;
                case 1:
                    spawnEnemies(5, 0);
                    spawnEnemies(5, 1);
                    break;
                case 2:
                    spawnEnemies(5, 0);
                    spawnEnemies(5, 1);
                    spawnEnemies(5, 2);
                    break;
                case 3:
                    spawnEnemies(10, 0);
                    spawnEnemies(5, 1);
                    spawnEnemies(5, 2);
                    spawnEnemies(5, 3);
                    break;
                case 4:
                    spawnEnemies(13, 0);
                    spawnEnemies(13, 1);
                    spawnEnemies(12, 2);
                    spawnEnemies(12, 3);
                    break;
                default:
                    break;
            }
            timer = 0.0f;
        }
        timer += Time.deltaTime;
    }

    private void spawnEnemies(int numEnemies, int direction)
    {
        if (direction == 0 || direction == 2)
        {
            for (int i = 0; i < numEnemies; i++)
            {
                Instantiate(enemy, new Vector3(-5 + rand.Next(-15, 15), 1, 27), Quaternion.identity);
            }
        } else if (direction == 1 || direction == 3)
        {
            for (int i = 0; i < numEnemies; i++)
            {
                Instantiate(enemy, new Vector3(-28, 1, 5 + rand.Next(-15, 15)), Quaternion.identity);
            }
        }
    }
}
