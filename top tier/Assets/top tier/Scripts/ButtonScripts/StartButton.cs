using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : ButtonBase
{
    public override void React()
    {
        base.React();
        SceneManager.LoadScene("GameScene");
    }
}
