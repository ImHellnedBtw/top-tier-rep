using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraImage : MonoBehaviour
{
    WebCamTexture webCamTexture;
    Texture _texture;
    bool enable;
    void Start()
    {
        webCamTexture = new WebCamTexture();
        GetComponent<RawImage>().material.mainTexture = webCamTexture;
    }
    public void TurnOff()
    {
        if (enable == true)
        {
            enable = false;
            webCamTexture.Stop();
        }
    }
    public void TurnOn()
    {
        if (enable == false)
        {
            enable = true;
            webCamTexture.Play();
        }
    }
    public void Save()
    {
        _texture = GetComponent<RawImage>().material.mainTexture;
        InformationController.PlayerAvatar = _texture;
    }
}
