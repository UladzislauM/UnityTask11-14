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

            if (triggerEnter.GetComponent<Rigidbody>() && triggerEnter.GetComponent<Controller>())
            {
                triggerEnter.GetComponent<Rigidbody>().isKinematic = true;
                triggerEnter.GetComponent<Animator>().enabled = true;
                triggerEnter.transform.rotation = Quaternion.Euler(0, 0, 0);
                gameManager.particalExplosion.gameObject.SetActive(true);
            }
        }
    }
}
