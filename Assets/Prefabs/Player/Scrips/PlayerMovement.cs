using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
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
        SetMovementStrategy(new MovimientoSuave());
    }

    void Update()
    {
        MovePlayer();
    }
    public void MovePlayer()
    {
        movementStrategy.Move(transform, speed.x);
    }

    void FixedUpdate()
    {
        tiempoUltimaFuerza += Time.fixedDeltaTime;
        if (tiempoUltimaFuerza >= intervaloTimepo)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoUltimaFuerza = 0f;
        }
    }

    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        this.movementStrategy = strategy;
    }
    
}
