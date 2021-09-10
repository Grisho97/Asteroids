using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemySpawner : MonoBehaviour
{

    #region Singleton
    static private EnemySpawner _Instance;
    
    static public EnemySpawner Instance
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

    [Header("Spawn parameters")]
    [SerializeField] private int numberOfStartAsteroids = 2;
    [SerializeField] private int asteroidsSpawnTime = 7;
    [SerializeField] private int ufoSpawnTime = 12;
    
    [Header("Prefab containers")]
    [SerializeField] private PoolingAsteroids asteroidsContainer;
    [SerializeField] private PoolingUFO ufoContainer;
    
    [Header("Scriptable Objects")]
    public AsteroidsScriptableObject asteroidSO;
    public static AsteroidsScriptableObject AsteroidsSO
    {
        get
        {
            if (Instance != null)
            {
                return Instance.asteroidSO;
            }
            return null;
        }
    }
    
    public UfoScriptableObject ufoSO;
    public static UfoScriptableObject UfoSO
    {
        get
        {
            if (Instance != null)
            {
                return Instance.ufoSO;
            }
            return null;
        }
    }

    private InputActions _inputActions;
    private void Awake()
    {
        Instance = this;
        _inputActions = new InputActions();
    }

    private void OnEnable()
    {
        _inputActions.SpaceShip.SpawnAsteroid.performed += context => SpawnNewAsteroid();
        
        _inputActions.SpaceShip.SpawnUfo.performed += context => SpawnUfo();
        _inputActions.Enable();
    }

    private void Start()
    {
        for (int i = 0; i < numberOfStartAsteroids; i++)
        {
           Invoke(nameof(SpawnNewAsteroid), 0.001f); //give time to update screen bounds box collider
        }
        
        InvokeRepeating(nameof(SpawnNewAsteroid),asteroidsSpawnTime,asteroidsSpawnTime);
        InvokeRepeating(nameof(SpawnUfo),ufoSpawnTime,ufoSpawnTime);
    }

    private void SpawnNewAsteroid()
    {
        AsteroidView ast = GetAsteroid();
        ast.size = AsteroidsSO.initialSize;
        Vector3 location = ScreenBoundsView.RANDOM_ON_SCREEN_LOC;
        ast.transform.position = location;
        ast.Init();
    }

    public AsteroidView GetAsteroid()
    {
        GameObject astGO = asteroidsContainer.RequestAsteroid();
        AsteroidView asteroidView = astGO.GetComponent<AsteroidView>();
        return asteroidView;
    }

    private void SpawnUfo()
    {
        UfoView ufoView = ufoContainer.RequestUfo();
        Vector3 location = ScreenBoundsView.RANDOM_ON_SCREEN_LOC;
        ufoView.transform.position = location;
        ufoView.Init(GameController.Instance.playerShipView.transform);
    }

    private void OnDisable()
    {
        _inputActions.Disable();
    }
}
