using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Walls
{
    public class FinishToFirst : MonoBehaviour
    {
        [SerializeField] private GameObject particalSystem;
        [SerializeField] private GameObject runner;
        [SerializeField] private GameObject winText;

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Rigidbody>())
            {
                particalSystem.SetActive(true);
                runner.GetComponent<Rigidbody>().isKinematic = true;
                winText.SetActive(true);
            }
        }
    }
}
