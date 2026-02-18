using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.transform.position = new Vector3(0, 3, 0);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(0, 0, 1); // cuando hacemos un .transform, todos los componentes lo tienen
            // transform.position = transform.position + new Vector3(0,0,1);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0, 0, -1); // cuando hacemos un .transform, todos los componentes lo tienen
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(1, 0, 0); // cuando hacemos un .transform, todos los componentes lo tienen
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-1, 0, 0); // cuando hacemos un .transform, todos los componentes lo tienen
        }

        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(0, 1, 0); // cuando hacemos un .transform, todos los componentes lo tienen
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(1, 0, 0);
        }*/

    }
}
