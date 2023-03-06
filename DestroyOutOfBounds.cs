using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = -30f;
    private float lowerBound = 25f;
    private float rightBound = 25f;
    private float leftBound = -25f;
    public GameObject player;
    private PlayerController playerController;

    void Start()
    {
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > rightBound)
        {
            Destroy(gameObject);
            playerController.UpdateScore(-10);
        }
        if (transform.position.z < leftBound)
        {
            Destroy(gameObject);
            playerController.UpdateScore(-10);
        }
        // Destroys objects that go past the x posistion set.
        if (transform.position.x > lowerBound)
        {
            playerController.UpdateHealth(1);
            Debug.Log("Animal got through, Lose one health!");
            Destroy(gameObject);
        }
        else if (transform.position.x < topBound)
        {
            Destroy(gameObject);
            playerController.UpdateScore(-10);
        }
        if (playerController.health <= 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene("Personal scene REAL");
        }
    }
}
