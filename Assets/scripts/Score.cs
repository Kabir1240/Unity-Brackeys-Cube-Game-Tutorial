using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text score;
    public Transform trigger;

    public float triggerPosition;
    public float playerPosition;
    public float distanceFromTrigger;
    public float currentScore;

    // Update is called once per frame
    void Update()
    {

        triggerPosition = trigger.position.z;
        playerPosition = player.position.z;
        distanceFromTrigger = triggerPosition - playerPosition;
        currentScore = ((triggerPosition - (distanceFromTrigger)) / triggerPosition) * 100;
        
        if (currentScore <= 100)
        {
            score.text = currentScore.ToString("0") + "%";
        }
        
    }
}
