using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingUFO : PoolObjects
{
    public UfoView RequestUfo()
    {
        GameObject ufoGO = RequestObject();
        UfoView ufoView = ufoGO.GetComponent<UfoView>();
        return ufoView;
    }
}
