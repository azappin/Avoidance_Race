using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public PlayerScore playerScore;
    public GameObject completeLevelUI;

    public static GameManager Instance
    {
        get
        {
            return _instance;
        }
    }

    void Start()
    {
        completeLevelUI = GameObject.FindWithTag("LevelComplete");
        completeLevelUI.SetActive(false);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);

            //gameHasEnded = true;
            //playerScore.isGameOver = true;
            //playerScore.scoreText.text = "GAME OVER!";

            //Restart the Game
            //Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {

        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else
        {
            _instance = this;
        }
    }

}
