using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BalloonController : MonoBehaviour
{

    public float upSpeed;
    int score = 0;

    AudioSource audioSource;

    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 3.5f)
        {
            SceneManager.LoadScene("Game");
        }   
    }
    private void FixedUpdate()
    {
        transform.Translate(0, upSpeed, 0);
    }
    private void OnMouseDown()
    {
        score++;
        scoreText.text = score.ToString();
        audioSource.Play();

        ResetPosition();
    }
    private void ResetPosition()
    {
        float randamX = Random.Range(-3.0f, 3.0f);



        transform.position = new Vector2(randamX, -9.0f);
       
    }
}
