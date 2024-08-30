using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _changerColor;
    [SerializeField] private float _duration;

    private LoopType _loopType = LoopType.Yoyo;
    private int _loop = -1;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    void Start()
    {
        _renderer.material.DOColor(_changerColor, _duration).SetLoops(_loop, _loopType);
    }
}
