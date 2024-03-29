using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour {

    private float acceleration = 50f; // The acceleration of the bullet
    private float initialVelocity = 5f; // The speed of the bullet at first

    private Rigidbody2D bulletRB; // Declaring variable to rigid body component, ie the bullet

    void Start() // Method called once the game has started
    {
        bulletRB = GetComponent<Rigidbody2D>();
        bulletRB.velocity = Vector2.up * initialVelocity;
    }

    void Update() // Method called every frame, keeps the speed of the bullet constant 
    {
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;
        bulletRB.AddForce(ForceToAdd);
    }
}
