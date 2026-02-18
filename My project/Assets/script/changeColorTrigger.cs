using UnityEngine;

public class changeColorTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Me están atravesando!");

        ChangeColors cc = GetComponent<ChangeColors>();
        cc.ChangeToYellow();
    }

}
