using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Walls
{
    public class BonusScript : MonoBehaviour
    {
        [SerializeField] private GameObject bonus;
        [SerializeField] private GameManager gameManager;

        private void Start()
        {
            gameManager = gameManager.GetComponent<GameManager>();
        }

        private void OnTriggerEnter(Collider Gammer)
        {
            if (Gammer.GetComponent<Controller>())
            {
                bonus.SetActive(true);
                Destroy(bonus, 3f);
                Destroy(gameObject, 0.2f);
                gameManager.bonusPlus++;
                Debug.Log("eee");
            }
        }
    }
}
