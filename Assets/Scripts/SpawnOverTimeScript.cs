using UnityEngine;
using System.Collections;

public class SpawnOverTimeScript : MonoBehaviour
{

    [SerializeField] private GameObject spawnObject; // Object to spawn
    [SerializeField] private float spawnDelay = 2f; // Delay between spawns

    private Renderer ourRenderer;
    
    void Start() // Use this for initialization
    {
        ourRenderer = GetComponent<Renderer>();
        ourRenderer.enabled = false; // Stop our Spawner from being visible!
        InvokeRepeating("Spawn", spawnDelay, spawnDelay); // Calls said function after delay, then repeats forever
    }

    void Spawn()
    {
        float x1 = transform.position.x - ourRenderer.bounds.size.x / 2;
        float x2 = transform.position.x + ourRenderer.bounds.size.x / 2;

        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y); // Randomly pick a point within the spawn object
        Instantiate(spawnObject, spawnPoint, Quaternion.identity); // Spawn the object at the 'spawnPoint' position
    }
}
