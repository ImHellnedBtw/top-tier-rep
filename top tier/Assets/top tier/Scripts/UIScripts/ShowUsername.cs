using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShowUsername : InformationController
{
    private InputField inputField;

    public void Start()
    {
        inputField = gameObject.GetComponent<InputField>();
        ChangeVisual();
        inputField.onEndEdit.AddListener(Save);
    }

    private void Save(string arg0)
    {
        PlayerName = arg0;
        ChangeVisual();
    }
    public void ChangeVisual()
    {
        if (PlayerName != "")
            inputField.placeholder.gameObject.GetComponent<Text>().text = PlayerName;
        else
            inputField.placeholder.GetComponent<Text>().text = "username";
    }
}
