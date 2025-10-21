using UnityEngine;

public class MovimientoSuave : IMovementStrategy
{
    public void Move(Transform transform, float speed)
    {
        float moveInX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(moveInX, 0, 0);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
