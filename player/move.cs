using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed = 0.4f;
	Vector2 dest = Vector2.zero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		// 移动
		Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
		GetComponent<Rigidbody2D>().MovePosition(p);

		// 按键移动
		if(1+1==2){
			if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up))
				dest = (Vector2)transform.position + Vector2.up;
			if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right))
				dest = (Vector2)transform.position + Vector2.right;
			if (Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.up))
				dest = (Vector2)transform.position - Vector2.up;
			if (Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.right))
				dest = (Vector2)transform.position - Vector2.right;
		}

		// Animation Parameters
		Vector2 dir = dest - (Vector2)transform.position;
		GetComponent<Animator>().SetFloat("Dir_X", dir.x);
		GetComponent<Animator>().SetFloat("Dir_Y", dir.y);

	}

	bool valid(Vector2 dir) {
		//碰撞检测
		Vector2 pos = transform.position;
		RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
		return (hit.collider == GetComponent<Collider2D>());
	}
}
