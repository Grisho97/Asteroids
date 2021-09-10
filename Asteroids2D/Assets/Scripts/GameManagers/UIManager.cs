using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region Singleton
    
    private static UIManager _Instance;
    public static UIManager Instance
    {
        get
        {
            if (_Instance == null)
            {
                Debug.LogError("Attempt to get value of Instance before it has been set.");
                return null;
            }
            return _Instance;
        }
        private set
        {
            if (_Instance != null)
            {
                Debug.LogError("Attempt to set Instance when it has already been set.");
            }
            _Instance = value;
        }
    }
    #endregion
    
    [SerializeField] private Text scoreText;

    [SerializeField] private Text livesText;
    
    [SerializeField] private Text amountOfLaserShootsText;
    
    [SerializeField] private Image laserLoadingImage;

    [Header("PlayerShip Parameters")]
    [SerializeField] private Text xCoordinateText;
    [SerializeField] private Text yCoordinateText;
    [SerializeField] private Text angleText;
    [SerializeField] private Text speedText;
    

    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        GameController.OnHealthChange += UpdateLives;
        GameController.OnScoreChange += UpdateScore;
        GameController.OnLaserLoading += UpdateLaserShoots;
    }

    private void OnDisable()
    {
        GameController.OnHealthChange -= UpdateLives;
        GameController.OnScoreChange -= UpdateScore;
        GameController.OnLaserLoading -= UpdateLaserShoots;
    }

    private void FixedUpdate()
    {
        UpdatePlayerShipParameters();
    }

    private void UpdatePlayerShipParameters()
    {
        var parameters = GameController.Instance.GetUIPlayerShipParameters();
        xCoordinateText.text = $"X: {parameters.XCordinate.ToString()}";
        yCoordinateText.text = $"Y: {parameters.YCordinate.ToString()}";
        angleText.text = $"Angle: {parameters.Angle.ToString()}";
        speedText.text = $"Speed: {parameters.Speed.ToString()}";
    }

    private void UpdateScore()
    {
        scoreText.text = GameController.Instance.score.ToString();
    }
    
    private void UpdateLives()
    {
        var lives = GameController.Instance.lives;
        livesText.text = lives > 0 ? lives.ToString() : "0";
    }

    private void UpdateLaserShoots(float loadingTime, int amountOfLaserShoots)
    {
        amountOfLaserShootsText.text = amountOfLaserShoots.ToString();
        if (amountOfLaserShoots > 0)
        {
            StartCoroutine(LoadLaser(loadingTime));
        }
        else
        {
            laserLoadingImage.fillAmount = 0;
            GameController.Instance.LaserLoadingComplete();
        }
        
    }
    
    private IEnumerator LoadLaser(float loadingTime)
    {
        var timer = 0f;
        while (timer <= loadingTime)
        {
            timer += Time.deltaTime;
            laserLoadingImage.fillAmount = timer / loadingTime;
            yield return null;
        }
        GameController.Instance.LaserLoadingComplete();
    }
}
