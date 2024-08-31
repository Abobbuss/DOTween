using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : BaseAnimation
{
    [SerializeField] private Color _changerColor;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        StartAnimation();
    }

    protected override void StartAnimation()
    {
        _renderer.material.DOColor(_changerColor, _duration).SetLoops(_loop, _loopType);
    }
}