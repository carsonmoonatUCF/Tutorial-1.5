using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource musicSource;

    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;

    private void Update() {
        
        // Music Clip One
        if(Input.GetKeyDown(KeyCode.W)){
            musicSource.clip = musicClipOne;
            musicSource.Play();
        }

        if(Input.GetKeyUp(KeyCode.W)){
            musicSource.Stop();
        }

        // Music Clip Two
        if(Input.GetKeyDown(KeyCode.R)){
            musicSource.clip = musicClipTwo;
            musicSource.Play();
        }

        if(Input.GetKeyUp(KeyCode.R)){
            musicSource.Stop();
        }

        // Looping
        if(Input.GetKeyDown(KeyCode.L)){
            musicSource.loop = true;
        }

        if(Input.GetKeyUp(KeyCode.L)){
            musicSource.loop = false;
        }
    }
}
