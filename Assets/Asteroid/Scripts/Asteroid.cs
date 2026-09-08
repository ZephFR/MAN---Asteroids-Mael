using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private float movespeed = 1f;
    float directionX;
    float directionY;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        directionX = Random.Range(-1f, 1f);
        directionY = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(directionX, directionY, transform.position.z, Space.World);
    }
}
