using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundsView : MonoBehaviour
{
    private static ScreenBoundsView Instance; 
    
    public float zScale = 10;
    private static float buffer = 0f;

    private ScreenBoundsLogic _screenBoundsLogic;
    
    Camera mainCamera;
    BoxCollider2D boxColl;


    private void Awake()
    {
        Instance = this;

        _screenBoundsLogic = new ScreenBoundsLogic();

        mainCamera = Camera.main;
        
        if (!mainCamera.orthographic)
        {
            Debug.LogError("ScaleToCamera:Start() - Camera.main needs to be orthograhic " +
                           "for ScaleToCamera to work, but this camera is not orthograhic.");
        }
        
        boxColl = GetComponent<BoxCollider2D>();
        boxColl.size = Vector3.one;
        transform.position = Vector3.zero;
        
        transform.localScale = _screenBoundsLogic.CalculateScale(mainCamera, zScale);
    }
    

    public static Vector3 RANDOM_ON_SCREEN_LOC
    {
        get
        {
            Bounds bounds = BOUNDS;
            Vector2 location = ScreenBoundsLogic.CalculateRandomPosition(BOUNDS, buffer);
            return location;
        }
    }

    
    private static Bounds BOUNDS
    {
        get
        {
            if (Instance == null)
            {
                Debug.LogError("ScreenBounds.BOUNDS - ScreenBounds.S is null!");
                return new Bounds();
            }
            if (Instance.boxColl == null)
            {
                Debug.LogError("ScreenBounds.BOUNDS - ScreenBounds.S.boxColl is null!");
                return new Bounds();
            }
            return Instance.boxColl.bounds;
        }
    }
}
