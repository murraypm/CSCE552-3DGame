using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractCue : MonoBehaviour
{
    [SerializeField] private GameObject icholder;
    [SerializeField] private A interaction;

    void Update()
    {
        if(interaction.GetInteractable() != null)
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    void Show()
    {
        icholder.SetActive(true);
    }

    void Hide()
    {
        icholder.SetActive(false);
    }
}
