using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Run : MonoBehaviour
{
    [SerializeField] private Vector3[] points;
    [SerializeField] private float speed;
    private Rigidbody objectRigidbody;
    private Vector3 purpose;
    private bool forward;
    private int nowPoint;

    private void Start()
    {
        purpose = points[0];
        nowPoint = 0;
        forward = true;
        objectRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Going();

        objectRigidbody.MovePosition(Vector3.MoveTowards(transform.position, purpose, Time.deltaTime * speed));
    }

    private void Going()
    {
        if (transform.position == purpose)
        {
            if (purpose == points[points.Length - 1])
            {
                forward = false;
            }

            if (forward)
            {
                purpose = points[++nowPoint];
            }
            else
            {
                purpose = points[--nowPoint];
                forward = true;
            }
        }
    }
}
