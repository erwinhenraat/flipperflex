using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geluidje : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    [SerializeField] AudioSource source;

    public void PlaySound()
    {
        source.PlayOneShot(clip);
    }
}
