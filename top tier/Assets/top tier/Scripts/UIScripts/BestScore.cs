using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScore : InformationController
{
    private TextMeshProUGUI m_TextMeshProUGUI;

    private void Start()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
        m_TextMeshProUGUI.text = new string( "Best score: " + BestScore.ToString());
    }
}
