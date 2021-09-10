using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laser : MonoBehaviour
{
    [Header("Laser parameters")]
    [SerializeField] private float activeLaserTime = 0.4f;
    public float loadingTime = 0.4f;
    private void Start()
    {
        TurnOff();
    }

    public void Init()
    {
        this.gameObject.SetActive(true);
        Invoke(nameof(TurnOff), activeLaserTime);
    }

    private void TurnOff()
    {
        this.gameObject.SetActive(false);
    }
    
}
