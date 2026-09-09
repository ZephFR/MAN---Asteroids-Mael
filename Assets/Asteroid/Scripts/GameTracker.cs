using System.Runtime.CompilerServices;
using UnityEngine;

public class GameTracker : MonoBehaviour
{
    public int asteroidDestroyed;
    public int score;
    [SerializeField] float sizeInc;
    [SerializeField] int sizeIncRequirement;
    private int scoreSinceLastInc;

    [SerializeField] private Camera cam;
    [SerializeField] private GameObject canvas;

    [SerializeField] private GameObject asteroidGO;
    [SerializeField] private int maxAsteroidCount;
    private int currentAsteroidCount;

    // Update is called once per frame
    void Update()
    {
        if (currentAsteroidCount < maxAsteroidCount)
        {
            Instantiate(asteroidGO, new Vector3(Random.Range(-cam.orthographicSize, cam.orthographicSize), Random.Range(-cam.orthographicSize, cam.orthographicSize), 0), Quaternion.identity);
            currentAsteroidCount += 1;
        }

        if (scoreSinceLastInc <= 0)
        {
            cam.orthographicSize += sizeInc;
            scoreSinceLastInc = sizeIncRequirement;
            canvas.transform.localScale = new Vector3(canvas.transform.localScale.x + (sizeInc/10), canvas.transform.localScale.y + (sizeInc / 10), canvas.transform.localScale.z + (sizeInc / 10));
        }
    }

    public void OnAsteroidDestroyed()
    {
        asteroidDestroyed += 1;
        score += 10;
        scoreSinceLastInc -= 1;
        currentAsteroidCount -= 1;
    }

    public void OnPlayerDestroyed()
    {
        cam.backgroundColor = Color.red;
        Destroy(canvas);
    }
}
