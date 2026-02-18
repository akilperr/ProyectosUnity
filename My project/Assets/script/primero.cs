using UnityEngine;

public class primero : MonoBehaviour
{

    public int numero = 5;
    public string texto = "hola";
    public bool booleano = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("hola soy el start " + texto);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hola soy el update");
    }
}
