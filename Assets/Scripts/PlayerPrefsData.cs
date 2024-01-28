using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsData : MonoBehaviour
{
    public static PlayerPrefsData Instance;
    [SerializeField] private bool dontDestroyOnLoad = true;
    private void Start() {
        if (Instance != null && Instance != this){
            Destroy(gameObject);
        }
        else{
            Instance = this;
        }
        if (dontDestroyOnLoad)
            DontDestroyOnLoad(this.gameObject);
    }
    public static float Money {
        get {
            return PlayerPrefs.GetFloat("Money");
        }
        set{
            if (PlayerPrefs.HasKey("Money"))
                PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money") + value);
            else PlayerPrefs.SetFloat("Money", value);
        }
    }

    public static int Cigarettes {
        get {
            return PlayerPrefs.GetInt("Cigarettes");
        }
        set {
            if (PlayerPrefs.HasKey("Cigarettes")){
                PlayerPrefs.SetInt("Cigarettes",PlayerPrefs.GetInt("Cigarettes") + value);
            }
            else PlayerPrefs.SetInt("Cigarettes", value);
        }
    }

}
