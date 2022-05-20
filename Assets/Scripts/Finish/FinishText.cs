using UnityEngine;

public class FinishText : MonoBehaviour
{
    [SerializeField] private Transform textObject;

    private void Update()
    {
        transform.LookAt(textObject);
        transform.Rotate(0, 180, 0);
    }
}
