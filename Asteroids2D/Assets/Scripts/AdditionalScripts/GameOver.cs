using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    

    private void OnEnable()
    {
        
    }
    
    private void Start()
    {
        GameController.OnLoose += Init;
        gameObject.SetActive(false);
    }

    private void Init()
    {
        gameObject.SetActive(true);
        scoreText.text = $"Score: {GameController.Instance.score.ToString()}";
        GameController.OnLoose -= Init;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
