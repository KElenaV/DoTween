using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("Welcome", 3));
        sequence.Append(_text.DOText(", my friend!", 3).SetRelative().SetDelay(1));
        sequence.Append(_text.DOText("Are you ready?", 3, true, ScrambleMode.All).SetDelay(1));
    }
}
