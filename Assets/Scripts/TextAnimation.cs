using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour
{
    [SerializeField] private Text _text;

    private LoopType _loopType = LoopType.Restart;
    private int _loop = -1;
    private string _changeText = "Замена";
    private string _addText = "Добавление";
    private float _duration = 3f;
    private bool _rechText = true;
    private ScrambleMode _scrambleMode = ScrambleMode.All;

    private void Start()
    {
        Sequence textSequence = DOTween.Sequence();

        textSequence.Append(_text.DOText(_changeText, _duration));
        textSequence.Append(_text.DOText(_addText, _duration).SetRelative());
        textSequence.Append(_text.DOText(_text.text, _duration, _rechText, _scrambleMode));
        textSequence.SetLoops(_loop, _loopType);
    }
}
