using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMech : MonoBehaviour
{
    [SerializeField] float shootingSpeed = 5f;     //Bullet shoot speed
    
   
    private void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * shootingSpeed);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" )
        {
            Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject);
            GameManager.EnemydeadSound();
            GameManager.Scoring();

        }
        
        Destroy(gameObject);
        
    }
    
}
