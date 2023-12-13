using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wallHealth : MonoBehaviour
{
    public Slider HPfill;
    [SerializeField] private AudioSource wallDamage;
    [SerializeField] private WinLoseManager _winManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetWallHealth(int health)
    {
        HPfill.value = health;
    }

    public void DamageWall(int health)
    {
        wallDamage.Play();
        HPfill.value -= health;
        if(HPfill.value <= 0)
        {
            _winManager.Lose();
            //lose screen
        }
    }
}
