using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundsLogic
{
    public Vector3 CalculateScale(Camera cam, float zScale)
    {
        
        Vector3 scaleDesired, scaleColl;

        scaleDesired.z = zScale;
        scaleDesired.y = cam.orthographicSize * 2;
        scaleDesired.x = scaleDesired.y * cam.aspect;
        
        scaleColl = scaleDesired;
        
        return scaleColl;
    }
    public static Vector3 CalculateRandomPosition(Bounds bounds, float buffer)
    {
        Vector2 location;
        float minX = bounds.min.x - buffer;
        float maxX = bounds.max.x + buffer;
        float minY = bounds.min.y - buffer;
        float maxY = bounds.max.y + buffer;

        if (Random.value > 0.5)
        {
            if (Random.value > 0.5)
            {
                location = new Vector2(minX, Random.Range(minY, maxY));
            }
            else
            {
                location = new Vector2(maxX, Random.Range(minY, maxY));
            }
        }
        else
        {
            if (Random.value > 0.5)
            {
                location = new Vector2(Random.Range(minX, maxX), minY);
            }
            else
            {
                location = new Vector2(Random.Range(minX, maxX), maxY);
            }
        }
        return location;
    }
}
