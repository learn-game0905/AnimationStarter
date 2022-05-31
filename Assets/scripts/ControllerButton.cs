using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ControllerButton : MonoBehaviour
{
    public Button btnClick;

    public GameObject popUp;
    // Start is called before the first frame update
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
        if (btnClick.IsActive())
        {
            
            popUp.SetActive(true);
            Sequence sequence = DOTween.Sequence();

            sequence.Append(popUp.transform.DOScale(Vector3.one, 1f));
        }
        else
        {
            transform.DOPunchRotation(new Vector3(360 , 0 ,0) , 1f);
        }
    }
}
