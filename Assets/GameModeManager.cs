using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeManager : MonoBehaviour
{
    public static GameModeManager Instance;

    private void Start() {
        if (Instance != null && Instance != this){
            Destroy(gameObject);
        }
        else{
            Instance = this;
        }
    }

    public enum GameMode{
        MainMode,
        EnergyDrinkMode,
        SmokingMode,
        LightHeadMode,
        ComputerMode
    }

    public GameMode gameMode;

    public void SetGameMode(GameMode gameMode){
        this.gameMode = gameMode;
    }
}
