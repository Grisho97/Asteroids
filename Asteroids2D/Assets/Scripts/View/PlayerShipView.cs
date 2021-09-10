using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerShipView : MonoBehaviour
{
    [Header("PlayerShip parameters")]
    [SerializeField] private float thrustForce = 2.0f;
    [SerializeField] float rotationSpeed = 150f;
    [SerializeField] private int numberOfLaserShoots = 3;

    [Header("PlayerShip weapons")]
    [SerializeField] private PoolingBullets poolingBullets;
    [SerializeField] private Laser laser;

    public bool laserIsLoading { get; set; }
    
    public float instantaneousSpeed { get; private set; }

    public Transform playerTransform { get; private set; }


    private Vector3 vectorSpeed;
    private InputActions _inputActions;
    private float _turnDirection = 0f;
    private bool _isMoving = false;

    private PlayerShipLogic _playerShipLogic;

    private void Awake()
    {
        playerTransform = GetComponent<Transform>();
        _inputActions = new InputActions();
        _playerShipLogic = new PlayerShipLogic();
    }
    
    private void OnEnable()
    {
        GameController.OnLoose += DestroyPlayerShip;
        
        _inputActions.SpaceShip.Shoot.performed += Shoot;
        _inputActions.SpaceShip.Laser.performed += LaserShoot;

        _inputActions.SpaceShip.Rotate.performed += context => _turnDirection = context.ReadValue<float>();
        _inputActions.SpaceShip.Rotate.canceled += context => _turnDirection = 0f;

        _inputActions.SpaceShip.Move.performed += context => _isMoving = true;
        _inputActions.SpaceShip.Move.canceled += context => _isMoving = false;
        
        _inputActions.Enable();
    }

    private void OnDisable()
    {
        GameController.OnLoose -= DestroyPlayerShip;
        _inputActions.Disable();
    }

    private void Start()
    {
        ReloadLaser();
    }

    private void FixedUpdate()
    {
        if (_turnDirection != 0f)
            playerTransform.Rotate(Vector3.back, _turnDirection * rotationSpeed * Time.fixedDeltaTime);

        if (_isMoving)
        {
            AddForce();
        }
        
        playerTransform.position += vectorSpeed * Time.fixedDeltaTime;

    }

    private void Shoot(InputAction.CallbackContext context)
    {
        poolingBullets.RequestBullet(playerTransform);
    }

    private void LaserShoot(InputAction.CallbackContext context)
    {
        if (!laserIsLoading && numberOfLaserShoots > 0)
        {
            laser.Init();
            numberOfLaserShoots--;
            ReloadLaser();

        }
    }

    private void ReloadLaser()
    {
        GameController.Instance.StartLaserLoading(laser.loadingTime, numberOfLaserShoots);
    }

    private void AddForce()
    {
        Vector3 impulse = _playerShipLogic.CalculateImpulse(playerTransform.up,thrustForce,Time.fixedDeltaTime);
        vectorSpeed += impulse;
        instantaneousSpeed = _playerShipLogic.CalculateSpeed(vectorSpeed);
    }

    public PlayerParameters GetPlayerParameters()
    {
        PlayerParameters parameters = _playerShipLogic.CalculateParameters(playerTransform, instantaneousSpeed);
        return parameters;
    }

    private void DestroyPlayerShip()
    {
        this.gameObject.SetActive(false);
    }
}
