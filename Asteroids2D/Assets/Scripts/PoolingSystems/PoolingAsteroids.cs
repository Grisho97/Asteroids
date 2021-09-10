using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingAsteroids : PoolObjects
{
    public GameObject RequestAsteroid()
    {
        GameObject asteroid = RequestObject();
        return asteroid;
    }
}
