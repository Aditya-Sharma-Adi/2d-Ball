using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour
{
    public SpriteRenderer sr;
    public Transform go;
    public Transform sc;
    private void Start()
    {
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float targetRatio = sr.bounds.size.x / sr.bounds.size.y;

        if (screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = sr.bounds.size.y / 2;
        }
        else
        {
            float differenceInSize = targetRatio / screenRatio;
            Camera.main.orthographicSize = sr.bounds.size.y / 2 * differenceInSize;
        }
        go.position = new Vector3(0, Camera.main.orthographicSize + 1.2f, 0);
        sc.position = new Vector3(0, -Camera.main.orthographicSize - 1.2f, 0);

    }

}
