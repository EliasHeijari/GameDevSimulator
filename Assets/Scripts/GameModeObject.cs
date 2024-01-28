using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeObject : ClickableObject
{

    [SerializeField] GameModeManager.GameMode gameMode;
    [SerializeField] float timeUntilChangeMode = 0f;
    [SerializeField] private AudioSource audioSource;
    private void Awake() {
        OnCollisionClicked += OnClick_Action;
    }

    private void OnClick_Action(object sender, EventArgs e){
        StartCoroutine(SetGameModeAfterTime(timeUntilChangeMode));
    }

    IEnumerator SetGameModeAfterTime(float time){
        if (audioSource != null)
            audioSource.Play();
        yield return new WaitForSeconds(time);
        GameModeManager.Instance.SetGameMode(gameMode);
    }
}
