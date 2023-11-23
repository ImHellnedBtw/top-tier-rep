using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.Networking;

public class ShowAvatar : InformationController
{
    private RawImage avatar;
    private Texture defaultTexture;
    private string path;
    void Start()
    {
        avatar = GetComponent<RawImage>();
        defaultTexture = GetComponent<RawImage>().texture;
        UpdateImage();
    }
    public void UpdateImage()
    {
        if (PlayerAvatar != null)
            avatar.texture = PlayerAvatar;
        else
            avatar.texture = defaultTexture;
    }
    public void SetDefault()
    {
        PlayerAvatar = null;
        UpdateImage();
    }
    public void OpenExplorer()
    {
#if UNITY_EDITOR
        path = EditorUtility.OpenFilePanel("Owerwrite with png", "", "png");
#endif
        GetImage();
    }

    public void GetImage()
    {
        if (path != null)
            StartCoroutine(SetImage(path));
    }

    IEnumerator SetImage(string path)
    {
        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(path))
        {
            yield return uwr.SendWebRequest();
            if(uwr.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                var urwTexture = DownloadHandlerTexture.GetContent(uwr);
                PlayerAvatar = urwTexture;
                UpdateImage();
            }
        }
    }
}
