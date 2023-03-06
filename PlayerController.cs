using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
    private Vector3 currentRotation;
    public float HorizontalRotation = 3f;
    public GameObject projectilePrefab;
    private AudioSource playerAudio;
    private float startDelayBullet = 1.0f;
    private float timeUntilnextbullet;
    private float intervalSpawn = 1.0f;
    public TMPro.TextMeshProUGUI scoreText;
    public TMPro.TextMeshProUGUI healthText;
    public int score;
    public int health;

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    public void UpdateHealth(int HP)
    {
        health -= HP;
        healthText.text = "Health: " + health;
    }

    void Start()
    {
        playerAudio = playerAudio = GetComponent<AudioSource>(); 
        intervalSpawn = startDelayBullet;
        health = 3;
        score = 0;
        UpdateScore(0);
        UpdateHealth(0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentRotation = transform.rotation.eulerAngles;

        if ((Input.GetAxis("Horizontal") > 0.2f) && (currentRotation.y <= 1.0f || currentRotation.y >= 185.0))
        {
            transform.Rotate(0, HorizontalRotation, 0);
        }
        if ((Input.GetAxis("Horizontal") < -0.2f) && (currentRotation.y <= 5.0f || currentRotation.y >= 188.0f))
        {
            transform.Rotate(0, -HorizontalRotation, 0);
        }

    }
    void Update()
    {
        if (timeUntilnextbullet < 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(projectilePrefab, transform.position, transform.rotation);
                // shoots a bullet from here
                timeUntilnextbullet = intervalSpawn;

            }
        }
        timeUntilnextbullet -= Time.deltaTime;
    }
}