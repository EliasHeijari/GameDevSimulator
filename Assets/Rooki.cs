using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooki : ClickableObject
{
    [SerializeField] private AudioSource audioSource; 
    private void Start() {
        OnCollisionClicked += CollisionClicked_Action;
    }

    private void CollisionClicked_Action(object sender, EventArgs e){
        if (PlayerPrefsData.Cigarettes >= 1){
            PlayerPrefsData.Cigarettes = -1;
            if (!audioSource.isPlaying)
                audioSource.Play();
            Player.Instance.Vitutus -= 0.05f;
        }
    }
}
