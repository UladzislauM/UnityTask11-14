using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Walls
{
    public class DownGroundPlaneTrigger : MonoBehaviour
    {
        [SerializeField] private GameObject gameManagetParant;
        private GameManager gameManager;

        private void Awake()
        {
            gameManager = gameManagetParant.GetComponent<GameManager>();
        }

        private void OnTriggerEnter(Collider triggerEnter)
        {
            if (triggerEnter.GetComponent<Controller>())
            {
                gameManager.deathScreen.gameObject.SetActive(true);
                gameManager.interfaceUI.gameObject.SetActive(false);
                triggerEnter.GetComponent<Controller>().enabled = false;
            }

            if (triggerEnter.GetComponent<Rigidbody>())
            {
                triggerEnter.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
    }
}
