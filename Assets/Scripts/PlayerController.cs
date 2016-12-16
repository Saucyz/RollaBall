using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private Rigidbody rb; // Holds reference for rigidbody on object
    public float speed = 10; // Default speed, can be changed in editor
    // First frame script is active
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Called before physics calculations
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical); //Ball should roll on axis, no y movement

        rb.AddForce(movement * speed); // Adds force in direction of Vector3 from input sped up by speed
    }
}
