using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI currencyAI;
    [SerializeField] Animator anime;
    private bool isMenuOpen=true;

    public void ToggleMenu() {
        isMenuOpen=!isMenuOpen;
        anime.SetBool("MenuOpen",isMenuOpen);
    }

    private void OnGUI() {
        currencyAI.text = LevelManager.main.currency.ToString();
    }
    public void SetSelected(){

    }
}
