using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 fuerzaPorAplicar;
    private float tiempoUltimaFuerza;
    private float intervaloTiempo;
    private float velocidadLateral;
    private IMovementStrategy movementStrategy;

    void Start()
    {
        fuerzaPorAplicar = new Vector3(0f, 0f, 300f);
        tiempoUltimaFuerza = 0f;
        intervaloTiempo = 2f;
        velocidadLateral = 5f;
    }
    public void MovePlayer(float input)
    {
        movementStrategy.Move(transform, velocidadLateral,input);
    }
    void FixedUpdate()
    {
        tiempoUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoUltimaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoUltimaFuerza = 0f;
        }
    }
    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        this.movementStrategy = strategy;
    }
}
