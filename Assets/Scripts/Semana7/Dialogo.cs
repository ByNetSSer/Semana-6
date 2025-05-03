using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
public class Dialogo : MonoBehaviour
{
    // [SerializeField] Image Perfil;
    [SerializeField] GameObject dialogoObject;
    [SerializeField] TextMeshProUGUI Name;
    [SerializeField] TextMeshProUGUI TextDialogue;
    private void OnEnable()
    {
        NPCStaded.OnTalk += OnStartDialogue;
    }
    private void OnDisable()
    {
        NPCStaded.OnTalk -= OnStartDialogue;
    }
    public void OnStartDialogue( string name, string dialogo,int tiempo)
    {
        // Perfil.sprite = perfil;
        Name.text = name;
        TextDialogue.text = dialogo;
       // Perfil.enabled = true;
        dialogoObject.SetActive(true);
        Debug.Log("inicie");
        StartCoroutine(WaitTodisabled(tiempo));
        
    }
    IEnumerator WaitTodisabled(int tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        //Perfil.enabled = false;
        dialogoObject.SetActive(false);
        Debug.Log("termine");
    }
}
