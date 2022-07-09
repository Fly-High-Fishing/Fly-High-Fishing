using UnityEngine;
using TMPro;

public class WristUI : MonoBehaviour
{
    [SerializeField] private TMP_Text countdownText;
    [SerializeField] private TMP_Text scoreText;


    private void Update()
    {
        DisplayTime(GameManager.Instance.gameTime); //Display time
        DisplayScore(Scoring.Score); //Display score
    }

    /// <summary>
    /// Display the itm on the wrist watch
    /// </summary>
    /// <param name="timeToDisplay"></param>
    public void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0) { timeToDisplay = 0.0F; } //Prevent diaplying a negative time
        else if (timeToDisplay > 0) { timeToDisplay += 1; } //1 Second offset for user readability

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); //Calculates the minutes
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); //Calculates the seconds (returns time remainder as seconds)

        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    /// <summary>
    /// Display the score on the wrist watch
    /// </summary>
    public void DisplayScore(int scoreToDisplay)
    {
        if (scoreToDisplay < 0) { scoreToDisplay = 0; } //Prevent negative score

        scoreText.text = $"{scoreToDisplay:000}"; //Display score as 3 units
    }
}
