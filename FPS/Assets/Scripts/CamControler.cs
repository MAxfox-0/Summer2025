using UnityEngine;

public class CamControler : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    
    void Start()
    {
        offset = transform.position - player.transform.position;   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset; 
    }
}
