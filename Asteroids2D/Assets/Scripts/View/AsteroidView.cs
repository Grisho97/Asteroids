using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AsteroidView : MonoBehaviour, IDamage
{
    public int size { get; set; }
    private float _velocity;
    private Vector3 _direction;
    private Transform _asteroidTransform;


    public void Init()
    {
        _asteroidTransform = transform;
        EnemySpawner.AsteroidsSO.SetTransformParameters(_asteroidTransform, size);
        _direction = Random.insideUnitCircle.normalized;
        _velocity = EnemySpawner.AsteroidsSO.defaultVelocity / size;
    }

    private void FixedUpdate()
    {
        _asteroidTransform.position += EnemySpawner.AsteroidsSO.DeltaPosition(_direction,_velocity,Time.fixedDeltaTime);
    }
    
    private static AsteroidView SpawnAsteroid()
    {
        AsteroidView ast = EnemySpawner.Instance.GetAsteroid();
        return ast;
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            GameController.Instance.AddScore(EnemySpawner.AsteroidsSO.pointsForAsteroidSize[size-1]);
        } 
        
        if (other.gameObject.CompareTag("Player"))
        {
            TakeDamage(-1);
        }

        if (size > 1)
        {
            for (int i = 0; i < EnemySpawner.AsteroidsSO.numSmallerAsteroidsToSpawn; i++)
            {
                    var ast = SpawnAsteroid();
                    ast.size = size - 1;
                    Vector3 relPos = transform.position;
                    ast.transform.position = relPos;
                    ast.Init();
            }
        }
        DestroyAsteroid();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Laser"))
        {
            DestroyAsteroid();
        }
    }

    public void TakeDamage(int damage)
    {
        GameController.Instance.ChangeHealth(damage);
    }

    private void DestroyAsteroid()
    {
        transform.localScale = Vector3.one * EnemySpawner.AsteroidsSO.asteroidScale;
        this.gameObject.SetActive(false); 
    }
}
