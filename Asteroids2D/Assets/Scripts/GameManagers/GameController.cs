using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    #region Singleton
    
    static private GameController _Instance;
    static public GameController Instance
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

    [Header("Game parameters")]
    [SerializeField] private int startHealth = 1;
    
    public int score { get; private set; }
    
    public int lives { get; private set; }
    
    public PlayerShipView playerShipView;

    public static Action OnStart;
    public static Action OnLoose;
    public static Action OnHealthChange;
    public static Action OnScoreChange;
    public static Action<float,int> OnLaserLoading;
    
    
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        AddScore(0);
        ChangeHealth(startHealth);
        OnStart?.Invoke();
    }

    public void AddScore(int numb)
    {
        score += numb;
        OnScoreChange?.Invoke();
    }

    private void GameOver()
    {
        OnLoose?.Invoke();
    }

    public void ChangeHealth(int changeNum)
    {
        lives += changeNum;
        OnHealthChange?.Invoke();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    public void StartLaserLoading(float loadingTime, int numberOfShootsLeft)
    {
        playerShipView.laserIsLoading = true;
        OnLaserLoading?.Invoke(loadingTime,numberOfShootsLeft);
    }

    public void LaserLoadingComplete()
    {
        playerShipView.laserIsLoading = false;
    }

    public PlayerParameters GetUIPlayerShipParameters()
    {
        var parameters = playerShipView.GetPlayerParameters();

        return parameters;
    }
}
