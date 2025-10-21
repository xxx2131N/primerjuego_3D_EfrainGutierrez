using UnityEngine;

public class MovimientoAcelerado : IMovementStrategy
{
    private float velocidadActual = 0f;
    private float aceleracion = 5f;
   public void Move(Transform transform, float speed)
   {
          float inputX = Input.GetAxis("Horizontal");
          bool shiftPresionado = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
          float aceleracionActual = shiftPresionado ? aceleracion * 2 : aceleracion;
          velocidadActual += inputX * aceleracionActual * Time.deltaTime;
          velocidadActual = Mathf.Clamp(velocidadActual, -speed, speed);
          transform.Translate(velocidadActual * Time.deltaTime, 0, 0);
   }
}
