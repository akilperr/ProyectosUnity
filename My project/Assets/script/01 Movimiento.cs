using UnityEngine;
public class Movimiento : MonoBehaviour
{
  public float speed = 0.1f; // Velocidad de movimiento
   // Update is called once per frame
   void Update()
   {
       // Obtener entrada del teclado
       float moveHorizontal = Input.GetAxis("Horizontal"); // A/D o Flechas
       float moveVertical   = Input.GetAxis("Vertical");     // W/S o Flechas


       // Crear vector de movimiento
       Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);


       // Mover al jugador con Translate
       gameObject.transform.Translate(movement * speed, Space.World);
   }
}
