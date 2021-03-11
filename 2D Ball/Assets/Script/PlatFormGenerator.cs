using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFormGenerator : MonoBehaviour
{

    public int num;
    public static float time = 2.1f;
    public GameObject[] plateform1;

    private void Start()
    {
        StartCoroutine(GeneratePlane());
        time = 2.1f;
    }

    IEnumerator GeneratePlane()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            num = Random.Range(0, 6);
            for (int i = 0; i < plateform1.Length; i++)
            {
                if (i == num)
                {
                    Instantiate(plateform1[i], new Vector3(0, -5.5f, 0), Quaternion.identity);
                }
            }
        }
       
    }

} 
