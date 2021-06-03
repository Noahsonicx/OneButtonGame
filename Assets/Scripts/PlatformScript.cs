using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public GameObject Platform;
    [SerializeField] private float spawnTime;
    [SerializeField] private float yMin, yMax;

    [SerializeField] private float platformWidth;

    private GameObject previousPlatform;

    // Start is called before the first frame update
    void Start()
    {
        previousPlatform = Platform;
        InvokeRepeating("platformSpawn", 0, spawnTime);

    }

    void platformSpawn()
    {
        float y = Random.Range(yMin, yMax);

        Vector3 pos = new Vector3(previousPlatform.transform.position.x + platformWidth + 10, y, 0);
        previousPlatform = Instantiate(Platform, pos, transform.rotation); // store the previous platform, and move it based on that
    }
}
