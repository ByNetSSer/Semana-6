using UnityEngine;
using UnityEngine.Audio;
public class ChannelPlayer : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSettings audioSettings;
    public AudioMixerGroup PlayerChannel => audioSource.outputAudioMixerGroup;
    private void Awake()
    {
        audioSource.outputAudioMixerGroup = audioSettings.AudioMixerGroup;
    }
    public void PlayerClip(AudioClip cliptoplay)
    {
        Debug.Log("recibi");
        audioSource.Stop();
        audioSource.clip = cliptoplay;
        audioSource.Play();
    }
}
