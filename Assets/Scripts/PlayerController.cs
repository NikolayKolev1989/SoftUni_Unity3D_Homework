using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed;
    public float rotationSpeed;
    private float verticalInput;
    private float horizontalInput;
    private Rigidbody rb;
    private int rollInput;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rollInput = 0;

        // move the plane forward at a constant rate
        rb.AddRelativeForce(Vector3.forward * forwardSpeed, ForceMode.Acceleration);

        // tilt the plane up/down based on up/down arrow keys
        verticalInput = Input.GetAxis("Vertical");
        rb.AddRelativeTorque(Vector3.right * rotationSpeed * verticalInput, ForceMode.Acceleration);

        // turn the plane left/right based on left/right arrow keys
        horizontalInput = Input.GetAxis("Horizontal");
        rb.AddRelativeTorque(Vector3.up * rotationSpeed * horizontalInput, ForceMode.Acceleration);

        // rotate the plane on Y Axis
        if (Input.GetKey(KeyCode.Q))
        {
            rollInput = 1;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rollInput = -1;
        }

        // roll the plane
        rb.AddRelativeTorque(Vector3.forward * this.rotationSpeed * rollInput, ForceMode.Acceleration);

    }   
}
