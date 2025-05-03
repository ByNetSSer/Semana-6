using UnityEngine;
using System;
using UnityEngine.UI;
public class NPCStaded : MonoBehaviour
{
    [SerializeField] private Vector3[] Puntos;
    [SerializeField] private int velocity;
    [SerializeField] private Vector3 objetivo;
    [SerializeField] private bool actual;
    [SerializeField] private int objetg;
    [SerializeField]private bool Canmove = true;

    [SerializeField] SO_DatatNPC Interaccion;
    public static event Action<Image,string, string, int> OnTalk;
    private void Update()
    {
        if (Canmove)
        {
            transform.position = Vector3.MoveTowards(transform.position, objetivo, velocity * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, objetivo) == 0 && actual)
        {
            actual = false;
            objetg = objetg + 1;

            //objetivo = Puntos[0];
        }
        if (Vector3.Distance(transform.position, objetivo) > 1)
        {
            actual = true;
        }
        if (objetg == Puntos.Length)
        {
            objetg = 0;

        }
        objetivo = Puntos[objetg];
       
    }
    public void Talk()
    {
        OnTalk?.Invoke(Interaccion.Perfil,Interaccion.name ,Interaccion.Text, Interaccion.Time);
        
        //Debug.Log("hola soy un npc");
    }
}
