using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float rotationSpeed;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Vertical"))
        {
            //transform.Translate(0f, moveSpeed * Time.deltaTime, 0f);
            rb.AddForce(transform.up * moveSpeed);
        }
        float horizontal = Input.GetAxisRaw("Horizontal");

        if(Input.GetButton("Horizontal"))
        {   
            rb.AddTorque(-transform.forward * rotationSpeed * horizontal);
        }
    }
}
