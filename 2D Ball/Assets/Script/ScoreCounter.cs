using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreManager.score += 10;
 
        GameManager.instance.Collision();
        if (PlatFormGenerator.time >=0.8f)
        {
            PlatFormGenerator.time -= 0.2f;
        }
        if (PlaneSpeed.speed<=5) 
        {
            PlaneSpeed.speed += 0.4f;
        }
        if (PlayerMovement.speed <=200)
        {
            PlayerMovement.speed += 50;
        }
    }

}
