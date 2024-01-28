using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreSystem : MonoBehaviour
{
    

    public void BuyCigarettes(int amount){
        float cost = 10f;
        if (PlayerPrefsData.Money >= cost){
            PlayerPrefsData.Cigarettes = amount;
            PlayerPrefsData.Money = -cost;
        }
    }

    public void ButGForce(int amount){
        //TODO 
    }
}
