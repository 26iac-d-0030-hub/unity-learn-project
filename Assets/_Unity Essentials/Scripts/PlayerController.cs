using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        Debug.Log(verticalInput);

        Vector3 movement = transform.forward * speed * Time.deltaTime * verticalInput;
        rb.MovePosition(rb.position + movement);

        float horizontalInput = Input.GetAxis("Horizontal");
        float turn = rotationSpeed * Time.deltaTime * horizontalInput;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation *  turnRotation);
    }
}
