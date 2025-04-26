using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float Vertical;
    [SerializeField] float Horizontal;
    [SerializeField] float velocidad;
    [SerializeField] Rigidbody Rdy;
    private void Awake()
    {
        Rdy = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
