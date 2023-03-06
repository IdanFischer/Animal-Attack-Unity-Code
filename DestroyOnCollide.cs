using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class DestroyOnCollide : MonoBehaviour
{
    public GameObject player;
    private PlayerController playerController;
    public ParticleSystem Boom;



    void Start()
    {
        player = GameObject.Find("Player");
        Boom = GameObject.Find("Boom").GetComponent<ParticleSystem>();
        playerController = player.GetComponent<PlayerController>();
    }

    void OnTriggerEnter(Collider other)
    {
        // if you collided with an "enemy" then destory both and get points
        if (other.gameObject.CompareTag("enemy"))
        {
            playerController.UpdateScore(20);
            Boom.transform.position = transform.position;
            Boom.Play();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Boom.Play();

        }
    }
}
