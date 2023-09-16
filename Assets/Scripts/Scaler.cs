using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scale = 0.5f;
    [SerializeField] private float _duration = 1;

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
