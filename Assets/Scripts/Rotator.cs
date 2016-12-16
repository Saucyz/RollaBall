using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); // Multiplying this smoothens by multiplying rotation by time it took for last frame, framerate independence
	}
}
