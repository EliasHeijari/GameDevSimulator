using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ValueToText : MonoBehaviour
{

    private TextMeshProUGUI moneyText;
    private void Start() {
        moneyText = GetComponent<TextMeshProUGUI>();
    }
    private void Update() {
        moneyText.text = "Money: " + PlayerPrefsData.Money.ToString() + "$"; 
    }
}
