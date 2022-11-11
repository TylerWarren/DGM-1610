using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private AudioSource gameOverSound;
    public AudioClip gameOver;
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;
    public GameManager gameManager; // Store reference to GameManager

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // Reference GameManager Script
        gameOverSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            gameManager.isGameOver = true;
            Time.timeScale = 0; // Freeze Time
            gameOverSound.PlayOneShot(gameOver, 1.0f);
        }
    }
}
