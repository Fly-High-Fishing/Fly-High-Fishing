/* Jazmin Fazzolari, 04.07.2022 */
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SceneTransitioner : MonoBehaviour
{
    /* Variables */
    private int sceneToLoad = 0;
    [SerializeField] private AudioMixer audioMixer = default;
    [SerializeField] private Animator crossfade = default;
    [SerializeField] private float transitionTime = 1f;

    /// <summary>
    /// Reset the music after a fade
    /// </summary>
    public void Awake()
    {
        StartCoroutine(AudioMixerManager.StartFade(audioMixer, "volMaster", 1F, 1f));
    }

    /// <summary>
    /// Start the process to fade into the next scene
    /// </summary>
    public void FadeToScene(int sceneIndex)
    {
        sceneToLoad = sceneIndex; //The desired scene
        crossfade.SetTrigger("FadeOut"); //Trigger the crossfade
        StartCoroutine(AudioMixerManager.StartFade(audioMixer, "volMaster", 3F, 0.0001f)); //Fade out the audio
    }

    /// <summary>
    /// Load scene once fade is complete
    /// </summary>
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(sceneToLoad); //Load the scene
    }
}
