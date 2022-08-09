using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_Controller : MonoBehaviour
{
    [SerializeField] float speed = 100f;

    // Update is called once per frame
    void Update()
    {
        RocketMovement();
    }

    public void RocketMovement()
    {
        // Clamp Rocket 
        Vector3 rocket = transform.position;
        rocket.x = Mathf.Clamp(rocket.x, -2.5f, 2.5f);      // we clamp the rocket player in horizontal right and left end 
        rocket.y = Mathf.Clamp(rocket.y, -3.3f, 4.5f);      //Clamp in Vertical up and Down End
        transform.position = rocket;

        // here we use Input Maneger for player movement
        float hor = Input.GetAxis("Horizontal") * speed * Time.deltaTime;   //Horizontal Movement right and left 
        //float ver = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = transform.position + new Vector3(hor, 0f, 0f);
        //transform.Translate(hor, ver, 0f); // Another Method to move Player
    }

}
