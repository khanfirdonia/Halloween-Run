using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationMenu : MonoBehaviour
{
    [Header("Titre")]
    public RectTransform titre;

    [Header("Chauves-souris")]
    public RectTransform chauve1;
    public RectTransform chauve2;

    [Header("Citrouilles")]
    public RectTransform citrouille1;
    public RectTransform citrouille2;

    // positions de départ
    private Vector3 startTitre;
    private Vector3 startCitrouille1;
    private Vector3 startCitrouille2;

    
    private float screenWidth = 1200f;

    void Start()
    {
        startTitre = titre.anchoredPosition;
        startCitrouille1 = 
            citrouille1.anchoredPosition;
        startCitrouille2 = 
            citrouille2.anchoredPosition;

        
        chauve1.anchoredPosition = 
            new Vector2(-screenWidth, 100f);
        chauve2.anchoredPosition = 
            new Vector2(screenWidth, 150f);
    }

    void Update()
    {
        
        titre.anchoredPosition = new Vector2(
            startTitre.x,
            startTitre.y + Mathf.Sin(
                Time.time * 1.5f) * 15f
        );

        
        float scale = 1f + Mathf.Sin(
            Time.time * 2f) * 0.03f;
        titre.localScale = new Vector3(
            scale, scale, 1f);

        
        chauve1.anchoredPosition = new Vector2(
            chauve1.anchoredPosition.x + 
                2f * Time.deltaTime * 100f,
            100f + Mathf.Sin(
                Time.time * 2f) * 30f
        );
        
        if (chauve1.anchoredPosition.x > 
            screenWidth)
        {
            chauve1.anchoredPosition = 
                new Vector2(-screenWidth, 100f);
        }

        
        chauve2.anchoredPosition = new Vector2(
            chauve2.anchoredPosition.x - 
                1.5f * Time.deltaTime * 100f,
            150f + Mathf.Sin(
                Time.time * 2.5f) * 25f
        );
        
        if (chauve2.anchoredPosition.x < 
            -screenWidth)
        {
            chauve2.anchoredPosition = 
                new Vector2(screenWidth, 150f);
        }

        
        citrouille1.anchoredPosition = new Vector2(
            startCitrouille1.x,
            startCitrouille1.y + Mathf.Sin(
                Time.time * 1.2f) * 20f
        );

        citrouille2.anchoredPosition = new Vector2(
            startCitrouille2.x,
            startCitrouille2.y + Mathf.Sin(
                Time.time * 1.8f) * 20f
        );
    }
}