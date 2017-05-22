using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 创建笔墨效果 : MonoBehaviour {
	public GameObject 墨水 ;
    public GameObject 玩家 ;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		
	}
	public void 创建物体() 
	{
		int speed = 1;
		GameObject obj = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		obj.transform.position = new Vector2 (5, 5);


		GameObject newobj = Instantiate (墨水)as GameObject;
		Vector2 pos = 玩家.transform.position;
	    Vector2 dir = new Vector2();
		dir.x = Random.Range(-1, 1);
		dir.y = Random.Range(-1, 1);
		newobj.AddComponent<Rigidbody2D> ();
		newobj.transform.position = pos;
		newobj.GetComponent<Rigidbody2D> ().AddForce (dir * speed);
	}
}
