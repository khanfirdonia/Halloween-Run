using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("KillZone"))
        {
            VieManager.instance.PerdreVie();
        }
    }
}