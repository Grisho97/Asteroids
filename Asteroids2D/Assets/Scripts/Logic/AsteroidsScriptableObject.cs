using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/AsteroidsSO", fileName = "AsteroidsSO")]
[System.Serializable]
public class AsteroidsScriptableObject : ScriptableObject
{
    public static AsteroidsScriptableObject S; 

    public AsteroidsScriptableObject()
    {
        S = this;
    }
    
    public float        defaultVelocity = 5;
    public int          initialSize = 2;
    public float        asteroidScale = 0.2f;
    public int          numSmallerAsteroidsToSpawn = 2;
    public int[]        pointsForAsteroidSize = {200, 100};

    public Vector3 DeltaPosition(Vector3 direction, float velocity, float time)
    {
        Vector3 deltaPos = direction * velocity * time;
        return deltaPos;
    }

    public void SetTransformParameters(Transform asteroidTransform, int size)
    {
        asteroidTransform.localScale = Vector3.one * size * asteroidScale;
        asteroidTransform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);
    }

}
