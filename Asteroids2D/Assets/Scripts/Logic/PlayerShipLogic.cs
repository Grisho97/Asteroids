using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipLogic 
{
    public Vector3 CalculateImpulse(Vector3 direction, float force, float time)
    {
        Vector3 impulse = direction * force * time;
        return impulse;
    }

    public float CalculateSpeed(Vector3 vectorSpeed)
    {
        float speed = Mathf.Round(vectorSpeed.magnitude * 1000) / 10;
        return speed;
    }

    public PlayerParameters CalculateParameters(Transform playerTransform, float instantSpeed)
    {
        PlayerParameters parameters = new PlayerParameters
        {
            XCordinate = Mathf.Round(playerTransform.position.x * 10) / 10,
            YCordinate = Mathf.Round(playerTransform.position.y * 10) / 10,
            Angle = Mathf.RoundToInt(playerTransform.rotation.eulerAngles.z),
            Speed = Mathf.Round(instantSpeed) /10
        };

        return parameters;
    }
}

public struct PlayerParameters
{
    public float XCordinate;
    public float YCordinate;
    public float Angle;
    public float Speed;
}
