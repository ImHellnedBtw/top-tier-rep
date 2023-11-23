using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LastScore : InformationController
{
    private TextMeshProUGUI m_TextMeshProUGUI;

    private void Start()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
        m_TextMeshProUGUI.text = new string("Last score: " + LastScore.ToString());
    }
}
