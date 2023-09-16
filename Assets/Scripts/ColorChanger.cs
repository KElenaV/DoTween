using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration = 1;

    private Material _material;

    private void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
        _material.DOColor(_targetColor, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
