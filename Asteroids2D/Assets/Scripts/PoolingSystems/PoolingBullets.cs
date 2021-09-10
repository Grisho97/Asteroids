using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingBullets : PoolObjects
{
     public GameObject RequestBullet(Transform instancePosition)
     {
          GameObject bullet = RequestObject();
          bullet.transform.position = instancePosition.position;
          bullet.transform.rotation = instancePosition.rotation;
          return bullet;
     }
}
