using System.Collections;
using UnityEngine;

public class StompZone : MonoBehaviour 
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Rigidbody2D rb = col
                .GetComponent<Rigidbody2D>();

            if (rb == null || 
                rb.velocity.y >= -0.1f) return;

            GameObject enemyParent = 
                transform.parent.gameObject;

            EnemyDamage ed = enemyParent
                .GetComponent<EnemyDamage>();
            if (ed != null) 
                ed.isStomped = true;

            foreach (Collider2D c in enemyParent
                .GetComponentsInChildren<Collider2D>())
            {
                c.enabled = false;
            }

            rb.velocity = new Vector2(
                rb.velocity.x, 10f);

            StartCoroutine(
                DestroyNextFrame(enemyParent));
        }
    }

    IEnumerator DestroyNextFrame(GameObject obj)
    {
        obj.SetActive(false);
        yield return null;
        Destroy(obj);
    }
}