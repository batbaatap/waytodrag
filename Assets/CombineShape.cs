using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineShape : MonoBehaviour {

	public GameObject ShapeSpawn;
	// public GameObject[] Shapes;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// Shapes = GameObject.FindGameObjectsWithTag("Shape");
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Shape")
		{
			Destroy(other.gameObject);
			ShapeSpawn.GetComponent<ShapeSpawner>().ShapeSpawn();

			// for(int i = 0; i < Shapes.Length; i++)
			// {
			// 	Shapes[i].GetComponent<ShapeController>().swiped = false;
			// }

		}
	}
}
