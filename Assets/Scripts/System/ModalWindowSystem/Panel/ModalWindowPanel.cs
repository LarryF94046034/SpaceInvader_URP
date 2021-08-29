using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ModalWindowPanel : MonoBehaviour
{
    [Header("Header")]
    [SerializeField]
    private Transform _headerArea;
    [SerializeField]
    private TextMeshProUGUI _titleField;
    [Header("Content")]
    [SerializeField]
    private Transform _contentArea;
    [SerializeField]
    private Transform _verticalLayoutArea;
    [SerializeField]
    private Image _heroImage;
    [SerializeField]
    private TextMeshProUGUI _heroText;
    [Space()]
    [SerializeField]
    private Transform _horizontalLayoutArea;
    [SerializeField]
    private Transform _iconContainer;
    [SerializeField]
    private Image _iconImage;
    [SerializeField]
    private TextMeshProUGUI _iconText;
    [Header("Footer")]
    [SerializeField]
    private Transform _footerArea;
    [SerializeField]
    private Button confirmButton;
    [SerializeField]
    private Button declineButton;
    [SerializeField]
    private Button alternateButton;


    // private Action onConfirmAction;
    // private Action onCancelAction;
    // private Action onAlternateAction;
    private Action onConfirmCallback;
    private Action onDeclineCallback;
    private Action onAlternateCallback;

    public void Close()
    {

    }
    public void Confirm()
    {
        //onConfirmAction?.Invoke();
        onConfirmCallback?.Invoke();
        Close();
    }
    public void Cancel()
    {
        //onCancelAction?.Invoke();
        onDeclineCallback?.Invoke();
        Close();
    }
    public void Alternate()
    {
        //onAlternateAction?.Invoke();
        onAlternateCallback?.Invoke();
        Close();
    }

    public void ShowAsHero(string title,Sprite imageToShow,string message,Action confirmAction,Action declineAction,Action alternateAction=null)
    {
        _horizontalLayoutArea.gameObject.SetActive(true);

        //Hide the header if there is no title
        bool hasTitle=string.IsNullOrEmpty(title);
        _headerArea.gameObject.SetActive(hasTitle);
        _titleField.text=title;

        _heroImage.sprite=imageToShow;
        _heroText.text=message;

        onConfirmCallback=confirmAction;
        onDeclineCallback=confirmAction;

        bool hasAlternate=(alternateAction!=null);
        alternateButton.gameObject.SetActive(hasAlternate);
        onAlternateCallback=alternateAction;
    }

    public void ShowAsHero(string title,Sprite imageToShow,string message,Action confirmAction)
    {
        //ShowAsHero(title,imageToShow,message,"Continue","",confirmAction);
    }

}
