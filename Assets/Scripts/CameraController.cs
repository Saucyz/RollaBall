using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// For follow cameras, late update runs every frame after all items processed, like position
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}