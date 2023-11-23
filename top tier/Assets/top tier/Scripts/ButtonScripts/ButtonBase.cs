using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonBase : MonoBehaviour ,IClickable
{
    private string ButtonName;
    private Button button;
    private IDoable doable;

    private void Start()
    {
        ButtonName = this.gameObject.name;
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        doable = BackgroundOperation.backgroundOperator.GetComponent<IDoable>();
    }

    public void Click()
    {
        React();
    }

    public virtual void React()
    {
        doable.Use(0);
    }
}
