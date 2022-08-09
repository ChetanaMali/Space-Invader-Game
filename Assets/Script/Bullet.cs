using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float shootingSpeed = 5f;     //Bullet shoot speed
    private void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * shootingSpeed);   //transform for go bullet upside after instentiate
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject);  // Destroy Enemy
            GameManager.EnemydeadSound();   // Play sound when enemy will destroy
            GameManager.Scoring();          // Count Score 
            Destroy(gameObject);            // Destroy Bullet
        }
    }


}
