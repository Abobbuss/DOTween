using DG.Tweening;
using UnityEngine;

public class SphereMovement : BaseAnimation
{
    [SerializeField] private Vector3 _distantMove;

    private void Start()
    {
        StartAnimation();
    }

    protected override void StartAnimation()
    {
        transform.DOMove(_distantMove, _duration).SetLoops(_loop, _loopType);
    }
}
