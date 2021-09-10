using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Bullet parameters")]
    [SerializeField] private float speed = 6f;
    [SerializeField] private float liveTime = 3f;
    private Transform _bulletTransform;

    private void OnEnable()
    {
        Invoke(nameof(DestroyBullet),liveTime);
    }

    private void Start()
    {
        _bulletTransform = transform;
    }

    private void FixedUpdate()
    {
        _bulletTransform.position += transform.up * (speed * Time.fixedDeltaTime);
    }
    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Asteroid") || other.gameObject.CompareTag("UFO"))
        {
            DestroyBullet();
        }
    }

    private void DestroyBullet()
    {
        this.gameObject.SetActive(false);
    }
}
