using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Transform player;
    public Score score;
    public Rigidbody rb;
    public playerMovement movement;

    public GameObject completeLevelUI;

    bool gameHasEnded = false;
    public float delay = 1f;

    public void EndGame()
    {
        if (!gameHasEnded) 
        {
            rb.useGravity = false;
            movement.enabled = false;
            score.enabled = false;

            gameHasEnded = true;

            // invoke lets you call a method with a delay
            Invoke("Restart", delay);
        }
    }

    public void CompleteLevel()
    {
        gameHasEnded = true;
        completeLevelUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
