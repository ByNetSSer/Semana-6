using UnityEngine;
using System;
using UnityEngine.Audio;
public class InteractableObject : MonoBehaviour
{
    [SerializeField] AudioData audioData;
    [SerializeField] AudioSettings audioSettings;
    

    public static event Action<AudioMixerGroup, AudioClip> OncollisionMusic;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("colicione");
                
            OncollisionMusic?.Invoke(audioSettings.AudioMixerGroup, audioData.AudioClip);
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
