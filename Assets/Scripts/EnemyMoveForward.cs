using UnityEngine;
using System.Collections;

public class EnemyMoveForward : MonoBehaviour {

    private float acceleration = 75f; // Acceleration of asteroid 
    private float initialVelocity = 2f; // Inital Speed of asteroid upon spawn

    private Rigidbody2D asteroidRB; // Declaring variable to rigid body component, in this case it's the asteroid

    void Start() // Called when game starts
    {
        asteroidRB = GetComponent<Rigidbody2D>();
        asteroidRB.velocity = Vector2.down * initialVelocity;
    }

    void Update() // Update is called once per frame
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;
        asteroidRB.AddForce(ForceToAdd);
    }
}
