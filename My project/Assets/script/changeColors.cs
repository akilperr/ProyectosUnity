using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    // METODOS PARA CAMBIAR DE COLOR -------------------------------------------------------------
    // This method changes the color of the gameobject.
    // Puede ser cambiado también desde fuera de la clase
    public void ChangeToBlack()
    {
        Renderer renderer = GetComponent<Renderer>(); // componente
        Material material = renderer.material;
        material.color = Color.black; // lo mismo que = new Color(0,0,0,1);
    }

    // This method changes the color of the gameobject.
    public void ChangeToYellow()
    {
        Renderer renderer = GetComponent<Renderer>();
        Material material = renderer.material;
        material.color = Color.yellow;
    }

    // START Y UPDATE ----------------------------------------------------------------------------
    void Start()
    {
        ChangeToBlack();
    }

    // Primer Update, el mas simple
    /*void Update()
    {
        ChangeToYellow();
    }*/

    // Update is called once per frame
    void Update()
    {
        // Input.GetKeyDown resturns a boolean (True or False)
        if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeToBlack();
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            ChangeToYellow();
        }
    }

}
