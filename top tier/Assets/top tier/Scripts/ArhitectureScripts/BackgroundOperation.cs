using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundOperation : MonoBehaviour, IDoable
{
    [HideInInspector] public static GameObject backgroundOperator;
    [HideInInspector] public static AudioSource _AudioSource;
    public List<AudioClip> clipList;
    private void Awake()
    {
        if(backgroundOperator == null )
        {
            backgroundOperator = this.gameObject;
            _AudioSource = GetComponent<AudioSource>();
            DontDestroyOnLoad(backgroundOperator);
            return;
        }
        Destroy(this.gameObject);
    }
    public void Use(int audioNumber)
    {
        PlaySound(audioNumber);
    }

    private void PlaySound(int _audioNumber)
    {
        _AudioSource.PlayOneShot(clipList[_audioNumber]);
    }
    private void Update()
    {
        if (_AudioSource.isPlaying == false)
        {
            PlaySound(1);
        }
        {
            
        }
    }
}
