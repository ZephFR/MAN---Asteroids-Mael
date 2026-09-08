using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float rotationSpeed = 1f;
    Vector2 dir;
    Vector3 moveDir;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        dir = Random.insideUnitCircle;

        moveDir = new Vector3(dir.x, dir.y, 0f).normalized;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + moveDir * moveSpeed);
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
