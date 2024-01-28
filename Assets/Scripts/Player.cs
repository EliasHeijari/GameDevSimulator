using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Instance;
    [SerializeField] private Image VitutusMeter;

    private float vitutus;
    public float Vitutus {
        get {
            return vitutus;
        }
        set { 
            vitutus = value;
            if (vitutus <= 0) vitutus = 0;
            VitutusMeter.fillAmount = vitutus;
        }
    }

    private void Start() {
        if (Instance != null && Instance != this){
           Destroy(gameObject);
        }
        else{
             Instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        Vitutus = 0.1f; // when game starts vitutus
    }     
}
