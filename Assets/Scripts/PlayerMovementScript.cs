﻿using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour 
{
    // SerializeField exposes this value to the Editor, but not to other Scripts!
    // It is "pseudo public"
    // HorizontalPlayerAcceleration indicates how fast we accelerate Horizontally
           
    [SerializeField] private float playerAcceleration = 5000f;

    private Rigidbody2D spaceshipRB;

    void Start() // Use this for initialization
    {
        // Get spaceshipRBComponent once at the start of the game and store a reference to it
        // This means that we don't need to call GetComponent more than once! This makes our game faster. (GetComponent is SLOW)
        spaceshipRB = GetComponent<Rigidbody2D>(); 
    }

    void Update() // Update is called once per frame
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f) 
        {
            Vector2 ForceToAdd=Vector2.right*HorizontalInput*playerAcceleration*Time.deltaTime;
            spaceshipRB.AddForce(ForceToAdd);
            
        } 
    } 
}
