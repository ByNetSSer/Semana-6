using UnityEngine;
using UnityEngine.Audio;
public class AudioPlayer : MonoBehaviour
{
    [SerializeField] ChannelPlayer musicPlayer;
    [SerializeField] ChannelPlayer sfxPlayer;
    private void OnEnable()
    {
        InteractableObject.OncollisionMusic += PlayPlayer;

    }
    private void OnDisable()
    {
        InteractableObject.OncollisionMusic -= PlayPlayer;
    }
    public void PlayPlayer(AudioMixerGroup currentGroup,AudioClip currentAudioClip)
    {
        if (currentGroup == musicPlayer.PlayerChannel)
        {
            musicPlayer.PlayerClip(currentAudioClip);
        }
        else
        {
            sfxPlayer.PlayerClip(currentAudioClip);
        }
    }
    
}
