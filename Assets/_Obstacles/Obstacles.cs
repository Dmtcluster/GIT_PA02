﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private int Hitpoints = 3;
    [SerializeField] private bool RandomRotation = false;

    public GameObject particles;



    private void Start()
    {
        if(RandomRotation)
            transform.eulerAngles = new Vector3(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180));
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - ( 3* 2 * Time.deltaTime));

        if(transform.position.z <= -10)
        {
            Destroy(gameObject);
            GameManager.Score++;
            print(GameManager.Score.ToString());
            HUD.HUDManager.UpdateScore();

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Lives--;
            HUD.HUDManager.UpdateLives();
            Instantiate(particles, this.transform.position, this.transform.rotation);

            if(GameManager.Lives==0)
            {
                HUD.HUDManager.GameOver();
                
            }
        }
    }
}
