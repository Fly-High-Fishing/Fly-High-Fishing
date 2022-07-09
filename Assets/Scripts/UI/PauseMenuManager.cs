/* Jazmin Fazzolari, 29.06.2022 */
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class PauseMenuManager : MonoBehaviour
{
    /* Variables */
    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;
    public GameObject controlsMenuUI;
    public GameObject tutorialMenuUI;
    public TextMeshProUGUI tutorialReturnText;

    bool firstCloseTutorial = true;

    [SerializeField] private InputActionReference iar;
    [SerializeField] private static bool gameIsPaused = false;
    [SerializeField] ToggleRay raycastToggle;

    private bool buttonPressed = false;

    private void Start()
    {
        iar.action.performed += TogglePause;
    }


    /// <summary>
    /// Update game pause state
    /// </summary>
    private void Update()
    {
        if (buttonPressed) 
        {

            buttonPressed = false;
        }
    }

    //Needed so that when transitioning between Scenes, it actually works
    public void ResumeTime()
    {
        Time.timeScale = 1.0f;
    }

    /// <summary>
    /// Pauses gameplay
    /// </summary>
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        raycastToggle.ShowControllerRay();
    }

    /// <summary>
    /// Resumes gameplay
    /// </summary>
    public void ResumeGame()
    {
        CloseAllMenus();
        Time.timeScale = 1.0F;
        gameIsPaused = false;
        raycastToggle.HideControllerRay();
    }


    /* UTILITY */
    /// <summary>
    /// Validate if pause input is triggered
    /// </summary>
    /// <returns></returns>
    private void TogglePause(InputAction.CallbackContext context)
    {
        if (gameIsPaused)  //If the game is paused
        {
            ResumeGame();  //Resume the game.
        }
        else
        {
            PauseGame(); //Otherwise the game is unpaused, so pause it
        }
    }

    public void DebugButtons()
    {
        Debug.Log("Button was pressed");
    }

    public void TutorialReturn()
    {
        if (firstCloseTutorial)
        {
            CloseAllMenus();
            raycastToggle.ToggleControllerRays();
            firstCloseTutorial = false;
            tutorialReturnText.text = "Return";
        }
        else
        {
            PreviousMenu();
        }
    }

    public void PreviousMenu()
    {
        pauseMenuUI.SetActive(true);
        optionsMenuUI.SetActive(false);
        controlsMenuUI.SetActive(false);
        tutorialMenuUI.SetActive(false);
    }

    public void CloseAllMenus()
    {
        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(false);
        controlsMenuUI.SetActive(false);
        tutorialMenuUI.SetActive(false);
    }

}
