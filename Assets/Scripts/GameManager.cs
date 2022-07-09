/* Jazmin Fazzolari, 29.06.2022 */
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public static CountdownTimer countdownTimer;
    
    /* Variables */
    [Header("Do Not Modify.")]
    public int gameScore = 0;
    public int highestScore = 0;
    public GameObject gameOverScreen = default;
    [SerializeField] ToggleRay toggleRay;
    [SerializeField] GameObject bow;

    [Header("Timer")]
    [Tooltip("Countdown time in seconds.")]
    public float gameTime = 0F;

    [Header("Game Parameters")]
    public float restartDelay = 1F;

    /* Methods */
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("An instance of GameManager already exists.");
            Destroy(this);
            return;
        }

        Instance = this;

        gameScore = 0;
    }

    private void Update()
    {
        if (gameTime <= 0F)
        {
            EndGame();
        }
    }

    /// <summary>
    /// Handle the game when time runs out
    /// </summary>
    private void EndGame()
    {
        /* Save Highscore */
        if (gameScore > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", gameScore);
        }

        /* Watch Flash and Beep */

        /* Fish Flee */

        /* Display Leaderboard */
        gameOverScreen.SetActive(true);

        toggleRay.ShowControllerRay();

        bow.SetActive(false);
    }
}
