using UnityEngine;


public class RecogeMoneda : MonoBehaviour
{
   // Detectar colisión con Trigger
   void OnTriggerEnter(Collider other)
   {
       Debug.Log("¡Moneda recogida!");
       Destroy(gameObject); // Elimina la moneda
   }
}
