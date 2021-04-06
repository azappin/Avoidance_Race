using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public bool isGameOver;


    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        scoreText.text = player.position.z.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
