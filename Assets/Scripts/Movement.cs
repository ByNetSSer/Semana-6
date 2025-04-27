using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float Vertical;
    [SerializeField] float Horizontal;
    [SerializeField] float velocidad;
    [SerializeField] Rigidbody Rdy;
    [SerializeField] AudioPlayer audio;
   // [SerializeField] AudioPlayer audio2;
    [SerializeField] AudioData Clip;
    //[SerializeField] AudioData ClipIntro;
    [SerializeField] AudioSettings canal;
    //[SerializeField] AudioSettings canal2;
    [SerializeField] AudioSource sonido;
    private void Awake()
    {
        Rdy = GetComponent<Rigidbody>();
    }
    void Start()
    {
        //audio2.PlayPlayer(canal2.AudioMixerGroup, ClipIntro.AudioClip);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <0)
        {
            transform.position = new Vector3(0, 2.16f,0);
        }   
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
