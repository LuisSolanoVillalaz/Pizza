using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void playsound(AudioClip sound){
        source.PlayOneShot(sound);
    }
}
