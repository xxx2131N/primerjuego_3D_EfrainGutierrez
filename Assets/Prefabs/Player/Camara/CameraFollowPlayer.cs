using UnityEngine;

public class CameraFollwPlayer : MonoBehaviour
{
    private Vector3 offSet;
    private PlayerMovement playerMovement;
    void Start()
    {
        offSet = new Vector3(0f, 1f, -5f);   
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerMovement.transform.position + offSet;
    }
}
