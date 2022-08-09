using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //[SerializeField] GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //InstantiateEnemy();
    }
    /*public void InstantiateEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(4.5f, -4.5f), 3f, 0f), Quaternion.identity);
    }*/
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject);
        }
    }*/
}
