using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Need to interacti with UI

public class PlayerController : MonoBehaviour {
    private Rigidbody rb; // Holds reference for rigidbody on object
    public float speed = 10; // Default speed, can be changed in editor
    private int count;
    public Text countText;
    public Text winText;

    // First frame script is active
    void Start() {
        count = 0;
        rb = GetComponent<Rigidbody>();
        SetCountText();
        winText.text = "";
    }

    // Called before physics calculations
    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical); //Ball should roll on axis, no y movement

        rb.AddForce(movement * speed); // Adds force in direction of Vector3 from input sped up by speed
    }

    // OnTriggerEnter is called by Unity when touching trigger collider, other is reference to collider we touched
    // Trigger colliders won't use physics
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Pick Up")) // Label this tag in Unity
        {
            other.gameObject.SetActive(false); // disable the game object in scene, not deleting
            count++;
            SetCountText();
        }
    }

    // Updates UI text to current count of pick ups
    void SetCountText() {
        countText.text = "Count: " + count.ToString();
        
        if(count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}