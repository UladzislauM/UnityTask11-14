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
            if (player.GetComponent<Rigidbody>())
            {
                hingleCheckVelosity = true;
                info.SetActive(true);
            }
        }

        private void OnTriggerExit(Collider playerExit)
        {
            if (playerExit.GetComponent<Rigidbody>())
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
