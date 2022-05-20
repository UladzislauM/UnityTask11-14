using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSetActive : MonoBehaviour
{
    [SerializeField] private GameObject objectsSetActive;

    private void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("Gamer"))
        {
            objectsSetActive.SetActive(true);
        }
    }
}
