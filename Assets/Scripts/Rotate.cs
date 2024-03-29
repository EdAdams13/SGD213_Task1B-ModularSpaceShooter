using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float maximumSpinSpeed = 200f; // Rotation speed of the asteroids

    void Start() // Use this for initialization
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maximumSpinSpeed, maximumSpinSpeed); // Determines whether spin is clockwise or anti-clockwise and between -200 / 200
    }
}
