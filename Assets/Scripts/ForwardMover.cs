using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    private void Update()
    {
        transform.Translate(new Vector3(0, 0, _speed) * Time.deltaTime);
    }
}
