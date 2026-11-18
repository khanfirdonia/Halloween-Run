using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalloweenBackground : MonoBehaviour
{
    
    private Transform bg1;
    private Transform bg2;
    
    
    private float bgHalloweenWidth;
    
    
    private Transform mainCam;

    void Start()
    {
        mainCam = Camera.main.transform;

        
        bg1 = transform.GetChild(0);
        bg2 = transform.GetChild(1);

        
        bgHalloweenWidth = bg1
            .GetComponent<SpriteRenderer>()
            .bounds.size.x;

        
        bg1.position = new Vector3(
            0, 0, 0);
        bg2.position = new Vector3(
            bgHalloweenWidth, 0, 0);
    }

    void Update()
    {
        
        if (bg1.position.x < 
            mainCam.position.x - bgHalloweenWidth)
        {
            bg1.position = new Vector3(
                bg2.position.x + bgHalloweenWidth,
                bg1.position.y,
                bg1.position.z);
        }

        
        if (bg2.position.x < 
            mainCam.position.x - bgHalloweenWidth)
        {
            bg2.position = new Vector3(
                bg1.position.x + bgHalloweenWidth,
                bg2.position.y,
                bg2.position.z);
        }
    }
}