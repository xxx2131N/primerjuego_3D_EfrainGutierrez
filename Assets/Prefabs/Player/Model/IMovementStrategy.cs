using UnityEngine;

public interface IMovementStrategy 
{
    public void Move(Transform transform, float speed, float direccion);
}
