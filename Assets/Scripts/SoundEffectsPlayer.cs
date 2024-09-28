using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource Src;
    public AudioClip sfx1, sfx2, sfx3;

    public void Button1()
    {
        Src.clip = sfx1;
        Src.Play();
    }
    public void Button2()
    {
        Src.clip = sfx2;
        Src.Play();
    }
    public void Button3()
    {
        Src.clip = sfx3;
        Src.Play();
    }
}
