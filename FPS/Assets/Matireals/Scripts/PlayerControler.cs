using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerControler : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 movment = new Vector3(movementX, 0.0f, movementY);

       rb. AddForce (movment * speed);
    }

    void OnMove(InputValue movmentValue)
    {
        Vector2 movmentVector = movmentValue.Get<Vector2>();

        movementX = movmentVector.x;
        movementY = movmentVector.y;
    }
}
