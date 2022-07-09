/* Jazmin Fazzolari, 04.07.2022 */
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour 
{
    public static GameManager gameManager;
    public static CountdownTimer countdownTimer;

    /* Variables */
    public GameObject mainMenuUI = default;
    public GameObject tutorialUI = default;
    public GameObject leaderboardUI = default;

    /// <summary>
    /// Return to the main menu
    /// </summary>
    public void ReturnMainMenu()
    {
        Invoke("Restart", gameManager.restartDelay); //Restart the current game with a delay
        return;
    }

    /// <summary>
    /// Reload the current scene
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// Quit the game
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }
}
