using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;      //create instance variable 

    //Sound Controller Variable
   // [SerializeField] AudioSource[] audioSource;
    [SerializeField] AudioSource shoot;
    [SerializeField] AudioSource enemydead;

    //Scoring Variable
    [SerializeField] int score = 0;
    [SerializeField] Text scoringText;
    private void Awake()
    {
        Instance = this;     //create instance
    }
    
    public void _ShootSound()
    {
        //Method for play shoot sound when player shoot
        Debug.Log("Play Shoot Sound");
        shoot.Play();
    }
    public static void ShootSound()
    {
         Instance._ShootSound();
    }
    public void _EnemydeadSound()
    {
        // Method For Play sound when enemy dead
        Debug.Log("Enemy Dead Sound");
        enemydead.Play();
    }
    public static void EnemydeadSound()
    {
        Instance._EnemydeadSound();
    }
    public void _Scoring()
    {
        // Method for Score as enemy dead Score will increses
        Debug.Log("Score is: " + score + ".");
        score+=5;
        scoringText.text = " Score: " + score.ToString();
    }
    public static void Scoring()
    {
        Instance._Scoring();
    }
}
