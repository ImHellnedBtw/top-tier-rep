using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDirection : MonoBehaviour
{
    int change;
    [SerializeField]
    float speed;
    private IDoable doable;
    private void Start()
    {
        change = 1;
        doable = BackgroundOperation.backgroundOperator.GetComponent<IDoable>();
    }
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * change);
        if(Input.GetMouseButtonDown(0) || Input.touchCount <0) 
        {
            change *= -1;
            doable.Use(2);
        }
    }
}
