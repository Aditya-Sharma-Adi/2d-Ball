using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneDestroy : MonoBehaviour
{
    public void Update()
    {
        if (transform.position.y >= 7)
        {
            Destroy(this.gameObject);
        }
    }
}
