using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;
public class WavesGameMode : MonoBehaviour
{
    [SerializeField] public Life playerLife ;
    [SerializeField] public Life playerBaseLife ;

    void Start () {

        playerLife.onDeath.AddListener (OnPlayerOrBaseDied) ; 
        playerBaseLife.onDeath.AddListener (OnPlayerOrBaseDied) ;
        EnemiesManager.instance.onChanged.AddListener (checkWinConditions);
        WaveManager.instance.onChanged.AddListener (checkWinConditions);
    }

    void checkWinConditions () {

       if (EnemiesManager.instance.enemies.Count <= 0 && WaveManager.instance.waves.Count <= 0 ) {

        SceneManager.LoadScene ("WinScreen") ;
       }
    }

    void OnPlayerOrBaseDied () {

        SceneManager.LoadScene ("LoseScreen") ;
    }
}