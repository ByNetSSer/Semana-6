using UnityEngine;

[CreateAssetMenu(fileName = "Audio Data SO", menuName = "Scriptable Objects/Audio/Audio Data")]
public class AudioData : ScriptableObject
{
    [SerializeField] AudioClip audioClip;
    public AudioClip AudioClip => audioClip;
}
