using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeObject : ClickableObject
{

    [SerializeField] GameModeManager.GameMode gameMode;

    private void Awake() {
        OnCollisionClicked += OnClick_Action;
    }

    private void OnClick_Action(object sender, EventArgs e){
        GameModeManager.Instance.SetGameMode(gameMode);
    }
}
