using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public GameObject Platform;
    public float spawnTime;
    public float yMin, yMax;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("platformSpawn", 0, spawnTime);

    }

    void platformSpawn()
    {
        float y = Random.Range(yMin, yMax);

        Vector3 pos = new Vector3(transform.position.x, y, 0);
        Instantiate(Platform, pos, transform.rotation);
    }
}
