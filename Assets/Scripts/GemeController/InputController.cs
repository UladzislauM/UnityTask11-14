using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Walls
{
    [RequireComponent(typeof(Rigidbody))]

    public class InputController : MonoBehaviour
    {
        [SerializeField] private GameObject mainCamera;
        private Vector3 _movementUp;
        private Vector3 _movementRight;
        private float _vertical;
        private float _horisontal;

        public Vector3 movementUp { get { return _movementUp; } set { _movementUp = value; } }
        public Vector3 movementRight { get { return _movementRight; } set { _movementRight = value; } }
        public float vertical { get { return _vertical; } set { _vertical = value; } }
        public float horisontal { get { return _horisontal; } set { _horisontal = value;} }

        private void LateUpdate()
        {
            vertical = Input.GetAxis(GlobalStringVaribals.VerticalAxis);
            horisontal = Input.GetAxis(GlobalStringVaribals.HorisontalAxis);

            movementUp = Vector3.ProjectOnPlane(mainCamera.transform.forward, Vector3.up).normalized;
            movementRight = mainCamera.transform.right;
        }
    }
}
