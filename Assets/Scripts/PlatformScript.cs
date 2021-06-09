using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public GameObject Platform;
    [SerializeField] private float spawnTime;
    [SerializeField] private float yMin, yMax;

    [SerializeField] private float platformWidth;

    // previousplatform so they don't collide with eachother
    private GameObject previousPlatform;

    // Start is called before the first frame update
    void Start()
    {
        previousPlatform = Platform;
        // platform spawn time between when the platform spawns and when the next one spawns
        InvokeRepeating("platformSpawn", 0, spawnTime);

    }

    void platformSpawn()
    {
        // randomized range for the platforms so they end up in a different position then the last one to make things interesting
        float y = Random.Range(yMin, yMax);

        // position of the range and gap that the platforms need to be and how wide they will be
        Vector3 pos = new Vector3(previousPlatform.transform.position.x + platformWidth + 10, y, 0);
        // previousplatform distancebetween
        previousPlatform = Instantiate(Platform, pos, transform.rotation); 
    }
}
