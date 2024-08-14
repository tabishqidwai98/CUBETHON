using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("We hit Something");

        if (collision.collider.tag == "obstacle") {

            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        
        }
    }
}
