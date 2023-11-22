using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sliderevent : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void setMusic(float music)
    {
        audioMixer.SetFloat("music", music);
    }
    public void setSound(float sound)
    {
        audioMixer.SetFloat("music", sound);
    }
}