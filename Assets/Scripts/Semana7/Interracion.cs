using UnityEngine;
using UnityEngine.InputSystem;
public class Interracion : MonoBehaviour
{
    [SerializeField] NPCStaded NPC;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "NPC" && collision.gameObject.GetComponent<NPCStaded>() != null && NPC== null)
        {
            NPC = collision.gameObject.GetComponent<NPCStaded>();
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "NPC" && collision.gameObject.GetComponent<NPCStaded>() == NPC)
        {
            NPC = null;
        }
    }

    public void InteractiveAccion(InputAction.CallbackContext context)
    {
        if (context.phase != InputActionPhase.Started) return;
        if (NPC != null)
        {
            NPC.Talk();
        }
        
    }
}
