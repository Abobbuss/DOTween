using DG.Tweening;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _distantMove;

    private LoopType _loopType = LoopType.Yoyo;
    private int _loop = -1;

    private void Start()
    {
        transform.DOMove(_distantMove, _duration).SetLoops(_loop, _loopType);
    }
}
