using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    public float bounceForce = 6;
    private AudioManager audioManager;


    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        audioManager.Play("Bounce");
        playerRb.velocity = new Vector3(playerRb.velocity.x, bounceForce, playerRb.velocity.z);
        string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;
        

        if(materialName == "Safe (Instance)")
        {
            //player hits safe area
        }
        else if(materialName == "Unsafe (Instance)") {
            //player hits unsafe area
            GameManager.gameOver = true;
            audioManager.Play("Game Over");
        }
        else if(materialName == "Last Ring (Instance)" && !GameManager.levelCompleted) {

            //level completed
            GameManager.levelCompleted = true;
            audioManager.Play("Win Level");
        } 
         
            
        
    }
}
