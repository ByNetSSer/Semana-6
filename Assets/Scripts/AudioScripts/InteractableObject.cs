using UnityEngine;
using System;
using UnityEngine.Audio;
public class InteractableObject : MonoBehaviour
{
    [SerializeField] AudioData audioData;
    [SerializeField] AudioSettings audioSettings;
    public static event Action<AudioMixerGroup, AudioClip> OncollisionMusic;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            OncollisionMusic?.Invoke(audioSettings.AudioMixerGroup,audioData.AudioClip);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
