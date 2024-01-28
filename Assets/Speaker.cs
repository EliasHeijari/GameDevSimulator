using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaker : ClickableObject
{
    [SerializeField] AudioSource speakerAudioSource;
    private void Start() {
        speakerAudioSource = GetComponent<AudioSource>();
        OnCollisionClicked += SpeakerClicked_Action;
    }

    private void SpeakerClicked_Action(object sender, EventArgs e){
        if (speakerAudioSource.isPlaying)
            speakerAudioSource.Pause();
        else speakerAudioSource.Play();
    }
}
