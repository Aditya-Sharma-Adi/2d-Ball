using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject plane;
    public GameObject timerText;
    public Rigidbody2D rb;
    public static bool isplay;
    public float timer=3f;
    public Text timeText;
 
    public AudioClip BuckCollision;
    private AudioSource audioSource;

    private void Start()
    {
        instance = this;
        StartCoroutine(startGame());
        plane.SetActive(false);
        rb.gravityScale = 0;
        audioSource = GetComponent<AudioSource>();
        PlaneSpeed.speed = 1;
    }

    private void Update()
    {

        if (isplay == true)
        {
            plane.SetActive(true);
            rb.gravityScale = 1;
            if (RayCast.isGameOver == true)
            {
                SceneManager.LoadScene(0);
            }
        }
        else
        {
            if (timer >= 0)
            {
                timer -= Time.deltaTime;
                timeText.text = Mathf.RoundToInt(timer).ToString();
            }
            else
            {
                timer = 0;
                timerText.SetActive(false);
            }
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
       
    }

    IEnumerator startGame()
    {
        isplay = false;
        yield return new WaitForSeconds(3);
        isplay = true;
    }

    public  void Collision()
    {
        audioSource.PlayOneShot(BuckCollision);
    }


}
