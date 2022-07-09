/* Jazmin Fazzolari, 28.06.2022 */
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    /* Variables */
    public GameManager gameManager;
    public bool enableCountdown = false;

    private void Update()
    {
        PerformCountdown();
    }

    public void StartTimer()
    {
        enableCountdown = true;
    }

    /// <summary>
    /// Updates the time so that it decrements 
    /// </summary>
    public void PerformCountdown()
    {
        if (!enableCountdown) { return; }

        /* Countdown */
        if (gameManager.gameTime > 0)
        {
            gameManager.gameTime -= Time.deltaTime;
        }
        else
        {
            gameManager.gameTime = 0.0F;
        }
    }
}
