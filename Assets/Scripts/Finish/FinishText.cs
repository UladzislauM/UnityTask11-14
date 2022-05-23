using UnityEngine;

public class FinishText : MonoBehaviour
{
    [SerializeField] private Transform textObject;

    private void FixedUpdate()
    {
        transform.LookAt(textObject);
        transform.Rotate(0, 180, 0);
    }
}
