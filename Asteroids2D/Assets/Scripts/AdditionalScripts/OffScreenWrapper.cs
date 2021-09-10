using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScreenWrapper : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Bounds"))
        {
            ScreenBoundsView boundsView = other.GetComponent<ScreenBoundsView>();
            ScreenWrap(boundsView);
        }
        
    }

    
    private void ScreenWrap(ScreenBoundsView boundsView) {
        
        Vector3 relativeLoc = boundsView.transform.InverseTransformPoint(transform.position);
        
        if (Mathf.Abs(relativeLoc.x) > 0.5f)
        {
            relativeLoc.x *= -1;
        }
        if (Mathf.Abs(relativeLoc.y) > 0.5f)
        {
            relativeLoc.y *= -1;
        }
        transform.position = boundsView.transform.TransformPoint(relativeLoc);
    }
}
