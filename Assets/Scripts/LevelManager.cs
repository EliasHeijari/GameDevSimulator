using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    [SerializeField] private bool dontDestroyOnLoad = true;
    [SerializeField] private string MainModeScene = "MainScene";
    [SerializeField] private string EnergyDrinkModeScene = "EnergyDrinkScene";
    [SerializeField] private string ComputerModeScene = "ComputerScene";
    [SerializeField] private string SmokingModeScene = "SmokingScene";
    private void Start() { 
        if (Instance != null && Instance != this){
            Destroy(gameObject);
        }
        else{
            Instance = this;
        }
        if (dontDestroyOnLoad){
            DontDestroyOnLoad(this.gameObject);
        } 
    }

    public void LoadGameModeScene(GameModeManager.GameMode gameMode){
        switch (gameMode){
            case GameModeManager.GameMode.MainMode:
                SceneManager.LoadScene(MainModeScene);
                break;
            case GameModeManager.GameMode.EnergyDrinkMode:
                SceneManager.LoadScene(EnergyDrinkModeScene);
                break;
            case GameModeManager.GameMode.ComputerMode:
                SceneManager.LoadScene(ComputerModeScene);
                break;
            case GameModeManager.GameMode.SmokingMode:
                SceneManager.LoadScene(SmokingModeScene);
                break;

        }
    }
    public void LoadActiveScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
