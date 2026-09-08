using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(3))
        {
            Instantiate(projectilePrefab);
        }
    }
}
