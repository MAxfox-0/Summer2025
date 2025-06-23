using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class PlayerControler : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }

    void OnMove(InputValue movmentValue)
    {
        Vector2 movmentVector = movmentValue.Get<Vector2>();

        movementX = movmentVector.x;
        movementY = movmentVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 10)
       {
           winTextObject.SetActive(true);
       }
   }

    private void FixedUpdate()
    {
        Vector3 movment = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movment * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
        
    }
}
