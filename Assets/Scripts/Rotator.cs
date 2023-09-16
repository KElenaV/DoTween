using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration = 2;

    private float angleY = 360;

    private void Start()
    {
        transform.DORotate(new Vector3(0, angleY, 0), _duration, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Restart)
            .SetEase(Ease.Linear);
    }
}
