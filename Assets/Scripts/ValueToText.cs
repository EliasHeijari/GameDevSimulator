using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ValueToText : MonoBehaviour
{

    private TextMeshProUGUI Text;
    [SerializeField] private bool money = false;
    [SerializeField] private bool cigarettes = false;
    private void Start() {
        Text = GetComponent<TextMeshProUGUI>();
    }
    private void Update() {
        if (money)
            Text.text = "Money: " + PlayerPrefsData.Money.ToString() + "$";
        else if (cigarettes)
            Text.text = "Cigarettes: " + PlayerPrefsData.Cigarettes.ToString();

    }
}
