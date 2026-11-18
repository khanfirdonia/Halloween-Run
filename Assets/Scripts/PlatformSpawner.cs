using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformHalloween;
    private float lastPlatformX;
    private float lastPlatformY;

    void Start()
    {
        lastPlatformX = 5f;
        lastPlatformY = 0f;
        
        for (int i = 0; i < 5; i++)
        {
            SpawnPlatform();
        }
    }

    void Update()
    {
        if (Camera.main.transform.position.x 
            + 15f > lastPlatformX)
        {
            SpawnPlatform();
        }

        
        GameObject[] platforms = 
            GameObject.FindGameObjectsWithTag
            ("Ground");

        foreach (GameObject p in platforms)
        {
            if (p.transform.position.x < 
                Camera.main.transform.position.x 
                - 20f)
            {
                Destroy(p);
            }
        }
    }

    void SpawnPlatform()
    {
        float randomY = Random.Range(-1f, 2f);
        float randomGap = Random.Range(4f, 7f);

        lastPlatformX += randomGap;
        lastPlatformY = randomY;

        Vector3 spawnPos = new Vector3(
            lastPlatformX,
            lastPlatformY,
            0f
        );

        Instantiate(
            platformHalloween, 
            spawnPos, 
            Quaternion.identity
        );
    }
}