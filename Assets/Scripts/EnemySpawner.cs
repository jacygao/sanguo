using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnRadius = 5.0f;
    public int numberOfObjects = 5;
    public Vector3 spawnScale = new Vector3(0.5f, 0.5f, 0.5f);

    // Start is called before the first frame update
    void Start()
    {
        Vector3 playerPosition = transform.position;

        // Spawn objects
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Generate random position around the player
            Vector3 spawnPosition = playerPosition + Random.insideUnitSphere * spawnRadius;
            spawnPosition.y = 0f; // Set the Y position (if needed)

            // Instantiate the object prefab at the spawn position with the random scale
            GameObject spawnedObject = Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
            spawnedObject.transform.localScale = spawnScale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}