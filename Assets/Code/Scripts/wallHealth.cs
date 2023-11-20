using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wallHealth : MonoBehaviour
{
    public Slider HPfill;

    public void SetWallHealth(int health)
    {
        HPfill.value = health;
    }
}
