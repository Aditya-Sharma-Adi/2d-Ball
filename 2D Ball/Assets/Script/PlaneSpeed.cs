using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpeed : MonoBehaviour
{
    public static float speed;

    public void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }


}
