using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _distance = -5;
    [SerializeField] private float _duration = 1;

    private void Start()
    {
        Vector3 startPosition = transform.position;
        float xPosition = startPosition.x;
        float yPosition = startPosition.y;

        transform.DOMove(new Vector3(xPosition, yPosition, _distance), _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
