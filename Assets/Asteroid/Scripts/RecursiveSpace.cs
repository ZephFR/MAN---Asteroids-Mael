using UnityEngine;

public class RecursiveSpace : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private float buffer;

    private float bounds;

    private void Start()
    {
        bounds = cam.orthographicSize + 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // X axis
        if (transform.position.x > bounds)
        {
            transform.position = new Vector3(-bounds + buffer, transform.position.y, transform.position.z);
        }

        else if (transform.position.x < -bounds)
        {
            transform.position = new Vector3(bounds - buffer, transform.position.y, transform.position.z);
        }

        // Y axis
        if (transform.position.y > bounds)
        {
            transform.position = new Vector3(transform.position.x, -bounds + buffer, transform.position.z);
        }

        else if (transform.position.y < -bounds)
        {
            transform.position = new Vector3(transform.position.x, bounds - buffer, transform.position.z);
        }
    }

    public void AddScreenSize(float size)
    {
        bounds = bounds + size;
    }
}
