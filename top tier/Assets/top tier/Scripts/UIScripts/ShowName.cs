using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : InformationController
{
    private TextMeshProUGUI m_TextMeshProUGUI;

    private void Start()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
        if (PlayerName != "")
            m_TextMeshProUGUI.text = PlayerName;
        else
            m_TextMeshProUGUI.text = "username";
    }
}
