using DG.Tweening;
using UnityEngine;

public class CapsuleScaling : BaseAnimation
{
    [SerializeField] private Vector3 _scale;

    protected override void StartAnimation()
    {
        transform.DOScale(_scale, _duration).SetLoops(_loop, _loopType);
    }

    private void Start()
    {
        StartAnimation();
    }
}