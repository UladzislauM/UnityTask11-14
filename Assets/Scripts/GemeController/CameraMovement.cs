using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Walls
{
    public class CameraMovement : MonoBehaviour
    {
        [SerializeField] private Transform playerTransform;
        [SerializeField, Range(0, 10)] private float speedRotation;
        [SerializeField] private GameObject parentObject;
        private InputController inputController;
        private Vector3 offset;
        private float angle;

        private void Awake()
        {
            inputController = parentObject.GetComponent<InputController>();
            offset = transform.position - playerTransform.position;
        }

        private void LateUpdate()
        {
            FloatingCamera();
        }

        private void FloatingCamera()
        {
            transform.position = playerTransform.position + offset;
            transform.LookAt(playerTransform.position + Vector3.up * 0.5f);
            angle -= inputController.horisontal * speedRotation * Time.deltaTime * 60f;
            transform.RotateAround(playerTransform.position, Vector3.up, -angle);
        }
    }
}
