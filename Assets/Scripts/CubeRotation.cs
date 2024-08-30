using DG.Tweening;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _rotation;

    private LoopType _loopType = LoopType.Yoyo;
    private RotateMode _rotateMode = RotateMode.FastBeyond360;
    private int _loop = -1;

    private void Start()
    {
        transform.DORotate(_rotation, _duration, _rotateMode).SetLoops(_loop, _loopType);
    }
}
