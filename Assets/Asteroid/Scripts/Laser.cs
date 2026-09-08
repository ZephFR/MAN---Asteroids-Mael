using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float lifetime;
    private Rigidbody rb;
    private float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        t += Time.deltaTime;
        if (t > lifetime)
            Destroy(gameObject);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = transform.position + Vector3.up * moveSpeed * Time.deltaTime;
    }
}
