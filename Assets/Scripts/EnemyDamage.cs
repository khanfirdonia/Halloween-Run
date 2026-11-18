using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [HideInInspector]
    public bool isStomped = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && !isStomped)
        {
            Rigidbody2D playerRb = col
                .GetComponent<Rigidbody2D>();

            
            if (playerRb != null && 
                playerRb.velocity.y < -0.1f)
                return;

            
            VieManager.instance.PerdreVie();
        }
    }
}