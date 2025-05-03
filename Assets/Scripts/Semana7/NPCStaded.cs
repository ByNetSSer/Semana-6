using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;
public class NPCStaded : MonoBehaviour
{
    [SerializeField] private Vector3[] Puntos;
    [SerializeField] private int velocity;
    [SerializeField] private Vector3 objetivo;
    [SerializeField] private bool actual;
    [SerializeField] private int objetg;
    [SerializeField]private bool Canmove = true;

    [SerializeField] SO_DatatNPC Interaccion;
    public static event Action<string, string, int> OnTalk;
    private void Update()
    {
       
        if (Canmove)
        {
            transform.position = Vector3.MoveTowards(transform.position, objetivo, velocity * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, objetivo) == 0 && actual)
        {
            StartCoroutine(Wait(2));

            actual = false;
            objetg = objetg + 1;

            //objetivo = Puntos[0];
        }
        if (objetg == Puntos.Length)
        {
            objetg = 0;

        }
        if (Vector3.Distance(transform.position, objetivo) > 1)
        {
            actual = true;
        }
        
        objetivo = Puntos[objetg];
       
    }
    public void Talk()
    {
        OnTalk?.Invoke( Interaccion.name ,Interaccion.Text, Interaccion.Time);
        StartCoroutine(Wait(3));
        //Debug.Log("hola soy un npc");
    }
    IEnumerator Wait( int time)
    {
        Canmove = false;
        yield return new WaitForSeconds(time);
        Canmove = true;
    }
}
