using UnityEngine;

public class CarSelectAnim : MonoBehaviour
{
    private Vector3 initialPosition;
    [SerializeField] private Vector3 finalPosition;

    private void Awake()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, finalPosition, 0.1f);
    }

    private void OnDisable()
    {
        transform.position = initialPosition;
    }
}
