/* Jazmin Fazzolari, 29.06.2022 */
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections;

/// <summary>
/// 
/// </summary>
public class AudioMixerManager : MonoBehaviour
{
    /* Variables */
    [Header("Volume Parameters")]
    [SerializeField] private string volumeParameter = "volMaster";
    [SerializeField] private AudioMixer audioMixer = default;
    [SerializeField] private float volumeMultiplier = 20F;

    [Header("Volume Controls")]
    [SerializeField] private Slider slider = default;
    private float volumeIncrement = 0.025F;

    private void Awake()
    {
        slider.onValueChanged.AddListener(HandleAudioValueChanged);
    }

    /// <summary>
    /// Get and set playerPrefs when starting
    /// </summary>
    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat(volumeParameter, slider.value);
    }

    /// <summary>
    /// Save playerPrefs when disabled
    /// </summary>
    private void OnDisable()
    {
        PlayerPrefs.SetFloat(volumeParameter, slider.value);
        PlayerPrefs.Save();
    }

    /// <summary>
    /// Handles the value of the mixer when the slider is changed
    /// </summary>
    /// <param name="sliderValue"></param>
    private void HandleAudioValueChanged(float sliderValue)
    {
        audioMixer.SetFloat(volumeParameter, Mathf.Log10(sliderValue) * volumeMultiplier);
    }

    public void HandleAudioUp()
    {
        slider.value += volumeIncrement;
        HandleAudioValueChanged(slider.value);
    }

    public void HandleAudioDown()
    {
        slider.value -= volumeIncrement;
        HandleAudioValueChanged(slider.value);
    }


    /// <summary>
    /// Fade-in the master volume when initiating a scene
    /// </summary>
    public static IEnumerator StartFade(AudioMixer audioMixer, string exposedParam, float duration, float targetVolume)
    {
        float currentTime = 0;
        float currentVol;
        audioMixer.GetFloat(exposedParam, out currentVol);
        currentVol = Mathf.Pow(10, currentVol / 20);
        float targetValue = Mathf.Clamp(targetVolume, 0.0001F, 1);

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            float newVol = Mathf.Lerp(currentVol, targetValue, currentTime / duration);
            audioMixer.SetFloat(exposedParam, Mathf.Log10(newVol) * 20);
            yield return null;
        }
        yield break;
    }
}
