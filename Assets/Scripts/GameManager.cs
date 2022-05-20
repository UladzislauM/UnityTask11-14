using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Walls
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GameObject runnerBall;
        [SerializeField] private GameObject _firstScreen;
        [SerializeField] private GameObject _deathScreen;
        [SerializeField] private GameObject _buttonsOnPlayScreen;
        [SerializeField] private GameObject _interfaceUI;
        [SerializeField] private GameObject _pauseScreen;
        private GameObject _currentScreen;
       

        public GameObject deathScreen { get { return _deathScreen; } set { _deathScreen = value; } }
        public GameObject interfaceUI { get { return _interfaceUI; } set { _interfaceUI = value; } }

        private void Start()
        {
            _currentScreen = _firstScreen;
        }

        public void ChangeState(GameObject state)
        {
            if (_currentScreen != null)
            {
                _currentScreen.SetActive(false);
                state.SetActive(true);
                _currentScreen = state;
            }
        }

        public void StateMachine(int sceneNum)
        {
            SceneManager.LoadScene(sceneNum);
        }

        public void Reset()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            _buttonsOnPlayScreen.SetActive(true);
            _pauseScreen.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
        public void PauseGame()
        {
            _buttonsOnPlayScreen.SetActive(false);
            _pauseScreen.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        public void ResumeGame()
        {
            _buttonsOnPlayScreen.SetActive(true);
            _pauseScreen.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
       
    }
}
