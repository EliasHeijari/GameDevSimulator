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
        DontDestroyOnLoad(this.gameObject);
    }

    public enum GameMode{
        MainMode,
        EnergyDrinkMode,
        SmokingMode,
        LightHeadMode,
        ComputerMode
    }

    private GameMode currentGameMode;
    public GameMode gameMode {
        get{
            return currentGameMode;  
        }
        set{
            currentGameMode = value;
            LevelManager.Instance.LoadGameModeScene(currentGameMode);
        }
    }

    public void SetGameMode(GameMode gameMode){
        this.gameMode = gameMode;
    }
    public void SetGameMode(string gameMode){
        switch (gameMode){
            case "MainMode":
                this.gameMode = GameMode.MainMode;
                break;
            case "EnergyDrinkMode":
                this.gameMode = GameMode.EnergyDrinkMode;
                break;
            case "SmokingMode":
                this.gameMode = GameMode.SmokingMode;
                break;
            case "LightHeadMode":
                this.gameMode = GameMode.LightHeadMode;
                break;
            case "ComputerMode":
                this.gameMode = GameMode.ComputerMode;
                break;

            default:
                Debug.LogError("Invalid String For GameMode");
                break;
        }
    }

}
