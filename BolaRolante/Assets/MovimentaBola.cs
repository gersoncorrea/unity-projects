using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaBola : MonoBehaviour {

	private Rigidbody rb;
	public float velocidade;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = new Vector3 (Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
		rb.AddForce (move*velocidade);
	}
}
