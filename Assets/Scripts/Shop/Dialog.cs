using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI contentText;
    public ShopManager shopManager;

    private void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
    }

    public virtual void Show(bool isShow)
    {
        gameObject.SetActive(isShow);
    }

    public virtual void UpdateDialog(string title, string content)
    {
        if (titleText)
            titleText.text = title;

        if (contentText)
            contentText.text = content;
    }

    public virtual void UpdateDialog()
    {

    }

    public virtual void Close()
    {
        gameObject.SetActive(false);
    }
}
