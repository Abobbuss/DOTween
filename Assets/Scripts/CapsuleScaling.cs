using DG.Tweening;
using UnityEngine;

public class CapsuleScaling : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _scale;

    private LoopType _loopType = LoopType.Yoyo;
    private int _loop = -1;

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetLoops(_loop, _loopType);
    }
}
