using UnityEngine;

[CreateAssetMenu(fileName = "Audio Data SO", menuName = "Scriptable Objects/Audio/Audio Data")]
public class AudioData : ScriptableObject
{
    [SerializeField] AudioClip audioClip;
    public AudioClip AudioClip => audioClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
