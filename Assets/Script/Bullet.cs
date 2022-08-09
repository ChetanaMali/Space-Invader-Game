using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;     // We add the bullet prefab 
    [SerializeField] GameObject sound;
   
    // Update is called once per frame
    void Update()
    {
        InstantiateBullet();        //Initialize bullet Prefab when we shoot the enemy Rocket
    }

    public void InstantiateBullet()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);// Instantiate bullet where the position of Rocket
            GameManager.ShootSound();   //Play shoot music when we shoot
            
        }

    }
  
    

}
