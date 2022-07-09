/* Jazmin Fazzolari, 29.06.2022 */
using UnityEngine;

/// <summary>
/// Manages audio within a scene
/// </summary>
public class AudioManager : MonoBehaviour
{
    /* Variables */
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource ambienceSource;

    /* FUNCTIONS */
    private void Awake()
    {
        musicSource = GetComponent<AudioSource>();
        ambienceSource = GetComponent<AudioSource>();
    }
}
