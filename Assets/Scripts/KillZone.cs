using UnityEngine;

public class KillZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            VieManager.instance.vies = 1;
            VieManager.instance.PerdreVie();
        }
    }
}