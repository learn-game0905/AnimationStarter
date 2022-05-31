using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ClosePopUp : MonoBehaviour
{
    public Button btnClose;

    public GameObject popUp;
    // Start is called before the first frame update
    void Start()
    {
        btnClose = GetComponent<Button>();
        btnClose.onClick.AddListener(ClosePopup);
    }

    private void ClosePopup()
    {
        popUp.transform.DOScale(Vector3.zero, 1f);
        popUp.SetActive(false);
    }
}
