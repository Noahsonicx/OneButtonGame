using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseManager : MonoBehaviour
{
    public Transform platformController;
    public PlayerController player;

    private Vector3 platformStartPoint;
    private Vector3 playerStartPoint;

    // Start is called before the first frame update
    void Start()
    {
        platformStartPoint = platformController.position;
        playerStartPoint = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        StartCoroutine("Restart");
    }

    public IEnumerator Restart()
    {
        player.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        player.transform.position = playerStartPoint;
        platformController.position = platformStartPoint;
        player.gameObject.SetActive(true);
    }
}
