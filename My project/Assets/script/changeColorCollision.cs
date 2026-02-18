using UnityEngine;

// Cuando algo se choque conmigo voy a cambair de color
// Al menos uno de los tiene que tener RIgitdoy y el mess collider

public class changeColorCollision : MonoBehaviour
{

    /*bool white = false;*/

    // OnCollisionEnter(collision) method is executed when 
    // other GameObject hits
    private void OnCollisionEnter(Collision collision) // el objeto collicion es el objeto que me ha chocado
    {
        Debug.Log("Me han golpeado!");

        ChangeColors cc = GetComponent<ChangeColors>();
        cc.ChangeToYellow();

        /*GameObject otherGo = collision.gameObject;
        if (!white)
        {
            otherGo.GetComponent<ChangeColor>().ChangeToYellow();
        }
        else
        {
            otherGo.GetComponent<ChangeColor>().ChangeToBlack();
        }
        white = !white;*/
    }

}
