using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public AudioSource musicSource;

    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;

    Animator catAnim;

    private void Start() {
        catAnim = GetComponent<Animator>();
    }

    private void Update() {
        
        // Music Clip One and Walking Animation
        if(Input.GetKeyDown(KeyCode.W)){
            musicSource.clip = musicClipOne;
            musicSource.Play();

            catAnim.SetInteger("State", 1);
        }

        if(Input.GetKeyUp(KeyCode.W)){
            musicSource.Stop();

            catAnim.SetInteger("State", 0);
        }

        // Music Clip Two and Running Animation
        if(Input.GetKeyDown(KeyCode.R)){
            musicSource.clip = musicClipTwo;
            musicSource.Play();

            catAnim.SetInteger("State", 2);
        }

        if(Input.GetKeyUp(KeyCode.R)){
            musicSource.Stop();

            catAnim.SetInteger("State", 0);
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
