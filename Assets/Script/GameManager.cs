using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager Instance;      //create instance variable 

    //Sound Controller Variable
    [SerializeField] AudioSource[] audioSource;
    AudioSource shoot;
    AudioSource enemydead;

    //Scoring Variable
    [SerializeField] int score = 0;
    [SerializeField] Text scoringText;
    private void Awake()
    {
        Instance = this;     //create instance
    }
    private void Start()
    {
        //SoundController
        audioSource = GetComponents<AudioSource>();
        shoot = audioSource[0];
        enemydead = audioSource[1];
    }
    public void _ShootSound()
    {
        Debug.Log("Play Shoot Sound");
        shoot.Play();
    }
    public static void ShootSound()
    {
         Instance._ShootSound();
    }
    public void _EnemydeadSound()
    {
        Debug.Log("Enemy Dead Sound");
        enemydead.Play();
    }
    public static void EnemydeadSound()
    {
        Instance._EnemydeadSound();
    }
    public void _Scoring()
    {
        Debug.Log("Score is: " + score + ".");
        score+=5;
        scoringText.text = " Score: " + score.ToString();
    }
    public static void Scoring()
    {
        Instance._Scoring();
    }
}
