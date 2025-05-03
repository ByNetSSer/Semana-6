using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Fade : MonoBehaviour
{
    [SerializeField] Image Fadein;
    [SerializeField] public static Fade Instance;

    private void OnEnable()
    {
        InteractableObject.OutCollisionMusic += OnChangefloor;
    }
    public void OnChangefloor()
    {
        StartCoroutine(OnFade());
    }
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(this);
    }

    IEnumerator OnFade()
    {
        /*
        for (float i= Fadein.color.a;i >0;  )
        {

        }
        */
        while (Fadein.color.a < 1)
        {
            Fadein.color = new Color(Fadein.color.r, Fadein.color.g, Fadein.color.b, Fadein.color.a + 0.01f);
            yield return new WaitForSeconds(0.001f);
        }
        while (Fadein.color.a>0)
        {
            Fadein.color = new Color(Fadein.color.r, Fadein.color.g, Fadein.color.b, Fadein.color.a - 0.01f);
            yield return new WaitForSeconds(0.001f);
        }
        

    }
}
