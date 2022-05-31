using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ClosePopUp : MonoBehaviour
{
    public Button btnClose;

    public GameObject popUp;
    public Slider coinSlider;
    public Slider gemSlider;

    void Start()
    {
        btnClose = GetComponent<Button>();
        btnClose.onClick.AddListener(ClosePopup);
    }

    private void ClosePopup()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOScale(new Vector3(1.2f , 1.2f , 1.2f) , 0.2f));
        sequence.Append(transform.DOScale(new Vector3(1f , 1f , 1f) , 0.2f));
        sequence.Append(popUp.transform.DOScale(Vector3.zero, 1f));
        coinSlider.value = 1000;
        gemSlider.value = 20;
        
        
    }
}
