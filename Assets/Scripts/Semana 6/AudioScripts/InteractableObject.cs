using UnityEngine;
using System;
using UnityEngine.Audio;
public class InteractableObject : MonoBehaviour
{
    [SerializeField] AudioData audioData;
    [SerializeField] AudioSettings audioSettings;

    [SerializeField] AudioSettings Restriccion;
    public static event Action<AudioMixerGroup, AudioClip> OncollisionMusic;
    public static event Action OutCollisionMusic;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("colicione");
                
            OncollisionMusic?.Invoke(audioSettings.AudioMixerGroup, audioData.AudioClip);
            
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && audioSettings ==Restriccion )
        {
            Debug.Log("me fui");

            OncollisionMusic?.Invoke(audioSettings.AudioMixerGroup, null);
            OutCollisionMusic.Invoke();
        }
    }
    private void invoke(AudioMixerGroup currentGroup, AudioClip currentAudioClip)
    {
        Debug.Log("invocado");
    }
    private void OnEnable()
    {
        OncollisionMusic += invoke;
    }
    private void OnDisable()
    {
        OncollisionMusic += invoke;
    }
}
