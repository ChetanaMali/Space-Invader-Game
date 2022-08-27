using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;      //create instance 
    public static GameManager instance { get { return Instance; } }

    //Sound Controller Variable
    // [SerializeField] AudioSource[] audioSource;
    [SerializeField] AudioSource shoot;
    [SerializeField] AudioSource enemydead;

    //Scoring Variable
    [SerializeField] int score = 0;
    [SerializeField] Text scoringText;
    private void Awake()
    {
        /*At a one time we only use one instance and other ones are destroy
         * Here we use singlton means we just need to use one script for all scene 
         * we just need to add this in first scene it automaticaly us for other scene also 
         * when we need it
        */
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void ShootSound()
    {
        //Method for play shoot sound when player shoot
        Debug.Log("Play Shoot Sound");
        shoot.Play();
    }
    /*public static void ShootSound()
    {
         Instance._ShootSound();
    }*/
    public void EnemydeadSound()
    {
        // Method For Play sound when enemy dead
        Debug.Log("Enemy Dead Sound");
        enemydead.Play();
    }
    /*public static void EnemydeadSound()
    {
        Instance._EnemydeadSound();
    }*/
    public void Scoring()
    {
        // Method for Score as enemy dead Score will increses 
        Debug.Log("Score is: " + score + ".");
        score += 5;
        scoringText.text = " Score: " + score.ToString();
    }
    /*public static void Scoring()
    {
        Instance._Scoring();
    }*/
}
