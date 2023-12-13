using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winlosetrigger : MonoBehaviour
{
    [SerializeField] private Animator BG;
    private bool doLose = true;
    private bool doWin = true;
    //public bool isLose;
    // Start is called before the first frame update
    void Start()
    {
        BG = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if(BG != null)
        {
            if (WinLoseManager.isWin && doWin)
            {
                doWin = false;
                BG.SetTrigger("Win");
            }
            if (WinLoseManager.isLose && doLose)
            {
                doLose = false;
                BG.SetTrigger("Lose");
            }

        }
    }
}
