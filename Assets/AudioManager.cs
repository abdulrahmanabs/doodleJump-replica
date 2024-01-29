using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private void Awake() {
        Instance=this;
    }
    AudioSource audioSource;
    void Start()=>audioSource=GetComponent<AudioSource>();
    public void PlaySound(AudioClip clip){
        audioSource.PlayOneShot(clip);
    }
}
