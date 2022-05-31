using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ControllerButton : MonoBehaviour
{
    public Button btnClick;

    public GameObject popUp;
    
    private int coinQuantity;
    private int gemQuantity;
    
    public Text coin;
    public Text gem;
    public Slider coinSlider;
    public Slider gemSlider;
    
    void Start()
    {

        if (btnClick != null)
        {
            btnClick = GetComponent<Button>();
            btnClick.onClick.AddListener(ButtonAnimation);
        }
        transform.DOScale(Vector3.one * 1.4f, 1f).SetLoops(-1, LoopType.Yoyo);
    }

    private void ButtonAnimation()
    {
        coinQuantity = Random.Range(1000, 6000);
        gemQuantity = Random.Range(20, 100);
        Sequence sequence = DOTween.Sequence();

        sequence.Append(popUp.transform.DOScale(Vector3.one, 1f));
        sequence.AppendCallback(() =>
        {
            coin.DOText(coinQuantity.ToString(), 3f, false, ScrambleMode.Numerals, "0123456789").From("0");
            coinSlider.DOValue(coinQuantity, 1f);

            gem.DOText(gemQuantity.ToString(), 3f, false, ScrambleMode.Numerals, "0123456789").From("0");
            gemSlider.DOValue(gemQuantity, 2f);  
        });
    }
}
