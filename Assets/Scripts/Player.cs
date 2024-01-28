using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Instance;
    [SerializeField] private Image VitutusMeter;
    [SerializeField] private AudioSource playerAudioSource;
    private float vitutus;
    private bool isGameOver = false;
    public float Vitutus {
        get {
            return vitutus;
        }
        set { 
            vitutus = value;
            if (vitutus <= 0) vitutus = 0;
            VitutusMeter.fillAmount = vitutus;
            if (vitutus >= 0.99f && !isGameOver)
            {
                isGameOver = true;
                StartCoroutine(EndGame());
            }
        }
    }

    IEnumerator EndGame(){
        playerAudioSource.Play();
        yield return new WaitForSeconds(2.3f);
        Debug.Log("Game quit");
        Application.Quit();
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
        InvokeRepeating("IncreaseVitutus", 0.1f, 0.1f);
    }


    private void IncreaseVitutus(){
        Vitutus += 0.00035f;
    }

}
