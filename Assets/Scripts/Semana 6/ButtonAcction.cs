using UnityEngine;

public class ButtonAcction : MonoBehaviour
{
    [SerializeField] GameObject Object;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActionObject(bool action)
    {
        Object.SetActive(action);
    }
}
