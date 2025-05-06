using System;
using TMPro;
using UnityEngine;

public class MoedasTextController : MonoBehaviour
{
    public TMP_Text moedasText;

    public void OnValidate()
    {
        if (moedasText == null)
        {
            moedasText = GetComponent<TMP_Text>();
        }
    }

    private void AtualizarMoedas(int coins)
    {
        moedasText.text = "Moedas: " + coins.ToString();
    }

    private void OnEnable()
    {
        PlayerObserverManager.OnMoedasChanged += AtualizarMoedas;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnMoedasChanged -= AtualizarMoedas;
    }
    
}
