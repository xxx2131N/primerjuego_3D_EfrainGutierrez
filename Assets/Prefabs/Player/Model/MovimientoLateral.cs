using UnityEngine;

public class MovimientoLateral : IMovementStrategy
{
    public void Move(Transform transform, float speed, float direccion)
    {
        float moveInX = direccion * speed * Time.deltaTime;
        transform.Translate(moveInX, 0, 0);
    }
}
