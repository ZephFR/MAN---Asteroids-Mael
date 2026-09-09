using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    [SerializeField] private float shootCD = 0.5f;
    private float t;
    private bool canShoot;

    // Update is called once per frame
    void Update()
    {
        
        t -= Time.deltaTime;
        if (t <= 0)
            canShoot = true;
    
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
            t = shootCD;
            canShoot=false;
        }
    }
}
