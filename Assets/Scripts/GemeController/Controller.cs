using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Walls
{
    public class Controller : MonoBehaviour
    {
        [SerializeField, Range(0, 50)] private float speedRotation;
        [SerializeField, Range(0, 20)] private float speed;
        [SerializeField, Range(0, 20)] private float speedDown;
        [SerializeField, Range(0, 20)] private float jampForse;
        private InputController inputController;
        private Rigidbody playerRigidbody;
        private bool isGrounded;
        private bool stopRun;

        private void Awake()
        {
            inputController = gameObject.GetComponent<InputController>();
            playerRigidbody = GetComponent<Rigidbody>();
            isGrounded = true;
            stopRun = true;
        }

        private void LateUpdate()
        {
            MoveBehindCamera(inputController.movementUp, inputController.movementRight);
            PressPKey();
        }

        public void MoveBehindCamera(Vector3 movementUp, Vector3 movementRight)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                playerRigidbody.AddForce(movementUp * speed *
                    Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                playerRigidbody.AddForce(-movementUp * speedDown *
                    Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                playerRigidbody.AddForce(movementRight * speed / 2 *
                    Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                playerRigidbody.AddForce(-movementRight * speed / 2 *
                    Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetAxis("Jump") > 0)
            {
                if (isGrounded)
                {
                    playerRigidbody.AddForce(Vector3.up * jampForse, ForceMode.Impulse);
                }
            }
        }

        private void OnCollisionStay(Collision collision)
        {
            if (collision.gameObject.tag == "ground")
            {
                isGrounded = true;
            }
        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.tag == "ground")
            {
                isGrounded = false;
            }
        }

        public void PressPKey()
        {
            if (stopRun)
            {
                if (Input.GetKeyDown(KeyCode.X))
                {
                   gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    stopRun = false;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.X))
                {
                    gameObject.GetComponent<Rigidbody>().isKinematic = false;
                    stopRun = true;
                }
            }
        }
    }
}
