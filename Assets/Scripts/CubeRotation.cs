using DG.Tweening;
using UnityEngine;

public class CubeRotation : BaseAnimation
{
    [SerializeField] private Vector3 _rotation;
    private RotateMode _rotateMode = RotateMode.FastBeyond360;

    protected override void StartAnimation()
    {
        transform.DORotate(_rotation, _duration, _rotateMode).SetLoops(_loop, _loopType);
    }

    private void Start()
    {
        StartAnimation();
    }
}