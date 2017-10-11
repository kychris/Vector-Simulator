using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	float speed  = 10f;
	// Use this for initialization
	void Start () {
		print ("hello");
	}
	
	// Update is called once per frame
	void Update () {
		print (Input.GetAxis("Horizontal"));
		transform.Translate (Input.GetAxis("Horizontal") *Time.deltaTime * speed, 0f, Input.GetAxis("Vertical") * Time.deltaTime * speed);

	}
}
	