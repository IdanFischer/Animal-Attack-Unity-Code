using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Wall"))
        //{
        gameObject.SetActive(false);
        other.gameObject.SetActive(false);
            //Destroy(other.gameObject);

            // will detect if objects collide and will destroy them if they do
        // Destroy(other.gameObject);
        //}
    }
}