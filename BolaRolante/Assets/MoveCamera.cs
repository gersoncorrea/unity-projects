using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
	public GameObject objBall;
	private Vector3 initialPos;
	// Use this for initialization
	void Start () {
		initialPos = transform.position - objBall.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = objBall.transform.position + initialPos;
	}
}
