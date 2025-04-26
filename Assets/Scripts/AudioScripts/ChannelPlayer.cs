using UnityEngine;

public class ChannelPlayer : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSettings audioSettings;
    private void Awake()
    {
        audioSource.outputAudioMixerGroup = audioSettings.AudioMixerGroup;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerClip(AudioClip cliptoplay)
    {
        audioSource.Stop();
        audioSource.clip = cliptoplay;
        audioSource.Play();
    }
}
