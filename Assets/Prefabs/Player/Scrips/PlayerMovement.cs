using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 fuerzaPorAplicar;
    private float tiempoUltimaFuerza;
    private float intervaloTimepo;

    private Vector3 speed;
    private IMovementStrategy movementStrategy;
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0f, 0f, 300f);
        tiempoUltimaFuerza = 0f;
        intervaloTimepo = 2f;

        speed = new Vector3(5f, 0f, 0f);
        SetMovementStrategy(new MovimientoAcelerado());
    }

    void Update()
    {
        MovePlayer();
    }
    public void MovePlayer()
    {
        if (movementStrategy != null)
            movementStrategy.Move(transform, speed.x);
    }

    void FixedUpdate()
    {
        tiempoUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoUltimaFuerza >= intervaloTimepo)
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(fuerzaPorAplicar);
            }
            tiempoUltimaFuerza = 0f;
        }
    }

    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        this.movementStrategy = strategy;
    }
    
}
