using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoView : MonoBehaviour, IDamage
{
    private float _speed;
    private Transform _ufoTransform;
    private Transform _playerLocation;

    public void Init(Transform playerLocation)
    {
        _playerLocation = playerLocation;
        _speed = EnemySpawner.UfoSO.speed;
    }

    private void Start()
    {
        _ufoTransform = transform;
    }

    private void FixedUpdate()
    {
        _ufoTransform.position = Vector2.MoveTowards(transform.position, 
            _playerLocation.position, _speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TakeDamage(-1);
        }

        else if (other.gameObject.CompareTag("Bullet"))
        {
            GameController.Instance.AddScore(EnemySpawner.UfoSO.pointsForUfo);
        }
        
        DestroyUfo();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Laser"))
        {
            DestroyUfo();
        }
    }

    public void TakeDamage(int damage)
    {
        GameController.Instance.ChangeHealth(damage);
    }

    private void DestroyUfo()
    {
        gameObject.SetActive(false);
    }
}
