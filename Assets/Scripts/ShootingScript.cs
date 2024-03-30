using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{

    [SerializeField] private GameObject bullet;
    private float lastFiredTime = 0f;
    [SerializeField] private float fireDelay = 1f;
    private float bulletOffset = 2f;

    void Start() // Do some math to perfectly spawn bullets in front of us
    {
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Half of our size
            + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size
    }

    
    void Update() // Update is called once per frame
    {
        if (Input.GetButton("Fire1"))
        {
            float CurrentTime = Time.time;

            if (CurrentTime - lastFiredTime > fireDelay) // Have a delay so we don't shoot too many bullets
            {
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);
                Instantiate(bullet, spawnPosition, transform.rotation);
                lastFiredTime = CurrentTime;
            }
        }
    }

    public float SampleMethod(int number) // Sample of how to use abstraction by specification. Converting int to float
    {
        return number;
    }
}
