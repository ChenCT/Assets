using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 碰撞 : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D food) {
		if (food.name == "player") {
			Destroy (gameObject);
		}
	}
}
