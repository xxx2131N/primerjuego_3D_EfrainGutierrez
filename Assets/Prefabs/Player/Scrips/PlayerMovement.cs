using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Vector3 fuerzaPorAplicar;
    private float tiempoUltimaFuerza;
    private float intervaloTimepo;
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0f, 0f, 300f);
        tiempoUltimaFuerza = 0f;
        intervaloTimepo = 2f;
    }

    void Update()

    {

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
}
