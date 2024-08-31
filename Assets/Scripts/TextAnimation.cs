using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextAnimation : BaseAnimation
{
    [SerializeField] private Text _text;

    private new LoopType _loopType = LoopType.Restart;
    private string _changeText = "Замена";
    private string _addText = "Добавление";
    private bool _rechText = true;
    private ScrambleMode _scrambleMode = ScrambleMode.All;

    private void Start()
    {
        StartAnimation();
    }

    protected override void StartAnimation()
    {
        Sequence textSequence = DOTween.Sequence();

        textSequence.Append(_text.DOText(_changeText, _duration));
        textSequence.Append(_text.DOText(_addText, _duration).SetRelative());
        textSequence.Append(_text.DOText(_text.text, _duration, _rechText, _scrambleMode));
        textSequence.SetLoops(_loop, _loopType);
    }
}
