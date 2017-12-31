using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {
    public AudioSource carSound;
    public AudioSource carCrash;

    public AudioSource source;
    public AudioClip btnClick;
    public AudioClip btnHover;
    public AudioClip Toggle_BtnSound;

    public void Onhover()
    {
        source.PlayOneShot(btnHover);

    }

    public void Onclick()
    {
        source.PlayOneShot(btnClick);

    }

    public void OnToggle()
    {
        source.PlayOneShot(Toggle_BtnSound);

    }

}
