using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    //public float xRange = 10;
    public GameObject projectilePrefab;
    private Quaternion rotation;
    private float startDelayBullet = 1.0f;
    private float timeUntilnextbullet;
    private float intervalSpawn = 1.3f;

    // Start is called before the first frame update
    void Start()
    {
        intervalSpawn = startDelayBullet;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Test to see if pressing down space bar. (Only press not hold)
        if (timeUntilnextbullet < 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(projectilePrefab, transform.position, rotation);
                // shoots a bullet from here
                timeUntilnextbullet = intervalSpawn;
            }
        }
        timeUntilnextbullet -= Time.deltaTime;
        // get user's horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        // get user's vertical input
        rotation = transform.rotation;
        //move player left and right
        //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //move player forward and backward
        //transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        // keep player inbounds
        ////left boundry
        //if (transform.position.x < -xRange)
        //{
        //    transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        //}
        ////right boundry
        //if (transform.position.x > xRange)
        //{
        //    transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        //}
    }
}