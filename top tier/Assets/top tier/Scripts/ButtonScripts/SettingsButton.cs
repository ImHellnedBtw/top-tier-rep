using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButton : ButtonBase
{
    public override void React()
    {
        base.React();
        SceneManager.LoadScene("SettingsScene");
    }
}
