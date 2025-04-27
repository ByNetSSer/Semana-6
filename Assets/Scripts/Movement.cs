using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float Vertical;
    [SerializeField] float Horizontal;
    [SerializeField] float velocidad;
    [SerializeField] Rigidbody Rdy;
    [SerializeField] AudioPlayer audio;
    [SerializeField] AudioData Clip;
    [SerializeField] AudioData ClipIntro;
    [SerializeField] AudioSettings canal;
    [SerializeField] AudioSource sonido;
    private void Awake()
    {
        Rdy = GetComponent<Rigidbody>();
    }
    void Start()
    {
        audio.PlayPlayer(canal.AudioMixerGroup, ClipIntro.AudioClip);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionStay(Collision collision)
    {

        if (Horizontal != 0 || Vertical != 0)
        {
            if (!sonido.isPlaying)
            {
                audio.PlayPlayer(canal.AudioMixerGroup, Clip.AudioClip);
            }

        }
        else
        {
            if (sonido.isPlaying)
            {
                audio.PlayPlayer(canal.AudioMixerGroup, null);
            }

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (sonido.isPlaying)
        {
            audio.PlayPlayer(canal.AudioMixerGroup, null);
        }
    }
    private void FixedUpdate()
    {
        Rdy.linearVelocity = new Vector3(Horizontal * velocidad, Rdy.linearVelocity.y, Vertical * velocidad);
    }
    public void OnMVertical(InputAction.CallbackContext context)
    {
        Vertical = context.ReadValue<float>();
    }
    public void OnMHorizontal(InputAction.CallbackContext context)
    {
        Horizontal = context.ReadValue<float>();
    }
}
