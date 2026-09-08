using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float rotationSpeed = 1f;
    float directionX;
    float directionY;
    Vector3 moveDir;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        directionX = Random.Range(-1f, 1f);
        directionY = Random.Range(-1f, 1f);

        moveDir = new Vector3(directionX, directionY, 0f).normalized;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + (moveDir * moveSpeed));
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
