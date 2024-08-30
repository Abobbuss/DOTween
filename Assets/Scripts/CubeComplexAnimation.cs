using DG.Tweening;
using UnityEngine;

public class CubeComplexAnimation : MonoBehaviour
{
    [SerializeField] private Vector3 _move;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;

    private LoopType _loopType = LoopType.Yoyo;
    private RotateMode _rotateMode = RotateMode.FastBeyond360;
    private int _loop = -1;

    private void Start()
    {
        transform.DOMove(_move, _duration).SetLoops(_loop, _loopType);
        transform.DORotate(_rotation, _duration, _rotateMode).SetLoops(_loop, _loopType);
        transform.DOScale(_scale, _duration).SetLoops(_loop, _loopType);
    }
}
