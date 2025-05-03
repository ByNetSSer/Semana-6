using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Plane : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI barradevida;
    [SerializeField] TextMeshProUGUI Puntos;
    [SerializeField] float puntos;
    [SerializeField] int vidas = 3;
    [SerializeField] GameObject Perdida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (vidas <= 0)
        {
            Debug.Log("perdiste");
            vidas = 0;
            Perdida.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            puntos = puntos + Time.deltaTime;
        }
        Puntos.text = "Puntos: "+((int)puntos);
        barradevida.text = "Vidas: " + vidas;
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstaculo")
        {
            vidas = vidas - 1;
        }
    }
}
