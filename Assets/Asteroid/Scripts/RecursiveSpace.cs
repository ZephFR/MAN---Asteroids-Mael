using UnityEngine;

public class RecursiveSpace : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private float buffer;
    private Vector3 position;

    private float bounds;

    void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //// X axis
        //if (transform.position.x > bounds)
        //{
        //    transform.position = new Vector3(-bounds + buffer, transform.position.y, transform.position.z);
        //}

        //else if (transform.position.x < -bounds)
        //{
        //    transform.position = new Vector3(bounds - buffer, transform.position.y, transform.position.z);
        //}

        //// Y axis
        //if (transform.position.y > bounds)
        //{
        //    transform.position = new Vector3(transform.position.x, -bounds + buffer, transform.position.z);
        //}

        //else if (transform.position.y < -bounds)
        //{
        //    transform.position = new Vector3(transform.position.x, bounds - buffer, transform.position.z);
        //}

        position = transform.position;
        bounds = cam.orthographicSize + buffer;

        position.x = cam.transform.position.x + Mathf.Repeat(position.x - cam.transform.position.x + bounds, (bounds *2)) - bounds;
        position.y = cam.transform.position.y + Mathf.Repeat(position.y - cam.transform.position.y + bounds, (bounds *2)) - bounds;
        
        transform.position = position;
    }

    public void AddScreenSize(float size)
    {
        bounds = bounds + size;
    }
}
