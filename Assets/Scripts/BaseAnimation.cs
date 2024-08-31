using DG.Tweening;
using UnityEngine;

public abstract class BaseAnimation : MonoBehaviour
{
    [SerializeField] protected float _duration;
    protected LoopType _loopType = LoopType.Yoyo;
    protected int _loop = -1;

    protected virtual void StartAnimation() { }
}

