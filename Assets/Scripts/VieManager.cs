using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VieManager : MonoBehaviour
{
    public static VieManager instance;

    [Header("Vies")]
    public int vies = 3;

    [Header("Images Coeurs")]
    public Image vie1;
    public Image vie2;
    public Image vie3;

    [Header("Sprites")]
    public Sprite coeurPlein;
    public Sprite coeurVide;

    [Header("Game Over")]
    public GameObject panelGameOver;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        panelGameOver.SetActive(false);
        MettreAJourCoeurs();
    }

    public void PerdreVie()
    {
        vies--;
        MettreAJourCoeurs();

        if (vies <= 0)
        {
            GameOver();
        }
    }

    void MettreAJourCoeurs()
    {
        vie1.sprite = vies >= 1 ? 
            coeurPlein : coeurVide;
        vie2.sprite = vies >= 2 ? 
            coeurPlein : coeurVide;
        vie3.sprite = vies >= 3 ? 
            coeurPlein : coeurVide;
    }

    void GameOver()
    {
        panelGameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Rejouer()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuPrincipal");
    }
}