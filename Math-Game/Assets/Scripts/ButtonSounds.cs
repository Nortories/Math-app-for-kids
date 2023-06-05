using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, sfx2, sfx3;

    public void Sound1()
    {
        src.clip = sfx1;
        src.Play();
    }
    public void Sound2()
    {
        src.clip = sfx2;
        src.Play();
    }
    public void Sound3()
    {
        src.clip = sfx3;
        src.Play();
    }
}
