using UnityEngine;

public class RecursiveSpace : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Camera cam;
    private float bounds;

    private void Start()
    {
        bounds = cam.orthographicSize + 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // X axis
        if (player.position.x > bounds)
        {
            player.position = new Vector3(-bounds, player.position.y, player.position.z);
        }

        else if (player.position.x < -bounds)
        {
            player.position = new Vector3(-bounds, player.position.y, player.position.z);
        }

        // Y axis
        if (player.position.y > bounds)
        {
            player.position = new Vector3(player.position.x, -bounds, player.position.z);
        }

        else if (player.position.y < -bounds)
        {
            player.position = new Vector3(player.position.x, bounds, player.position.z);
        }
    }

    public void AddScreenSize(float size)
    {
        bounds = bounds + size;
    }
}
