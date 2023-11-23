using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingController : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    private void Start()
    {
        StartCoroutine(LoadAsync());
    }
    IEnumerator LoadAsync()
    {
        AsyncOperation loadAsync = SceneManager.LoadSceneAsync("MenuScene");
        loadAsync.allowSceneActivation = false;
        while (!loadAsync.isDone)
        {
            slider.value = loadAsync.progress;
            if (loadAsync.progress >= .9f && !loadAsync.allowSceneActivation)
            {
                yield return new WaitForSeconds(1.2f);
                loadAsync.allowSceneActivation = true;
            }
            yield return null;

        }
    }
}
