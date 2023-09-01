using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    [SerializeField] AudioClip _clip;
    public AudioSource _audioSource;

    public void Play()
    {
        _audioSource.PlayOneShot(_clip);
    }
}
