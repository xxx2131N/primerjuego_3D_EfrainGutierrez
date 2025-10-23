using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoColicion : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       if (collision.collider.name == "Player")
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
