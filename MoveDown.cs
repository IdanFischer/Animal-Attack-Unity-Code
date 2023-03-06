
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 12.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // moves animals down the screen.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}