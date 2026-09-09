using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        if (other.tag == "Asteroid")
        {
            health -= 1;
            Destroy(other.gameObject);
        }

        if (health == 0)
        {
            Destroy(gameObject);
            GameObject.Find("GameManager").GetComponent<GameTracker>().OnPlayerDestroyed();
        }

    }
}
