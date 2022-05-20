using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Walls
{
    public class DoorBarrier : MonoBehaviour
    {
        [SerializeField] private GameObject doorObject;
        [SerializeField] private GameObject info;
        private bool hingleCheckVelosity;

        private void LateUpdate()
        {
            LogicDoor();
        }

        private void OnTriggerEnter(Collider player)
        {
            if (player.CompareTag("Gamer"))
            {
                hingleCheckVelosity = true;
                info.SetActive(true);
            }
        }

        private void OnTriggerExit(Collider playerExit)
        {
            if (playerExit.CompareTag("Gamer"))
            {
                info.SetActive(false);
            }
        }

        private void LogicDoor()
        {
            if (hingleCheckVelosity)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    doorObject.GetComponent<Rigidbody>().isKinematic = false;
                }
            }
        }
    }
}
