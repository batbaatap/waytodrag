using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour {
	public List<GameObject> Shapes = new List<GameObject>(); 
	public GameObject parentP;
	internal float countPos = 0;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		// if(Input.GetKeyDown(KeyCode.LeftArrow))
		// {
		// 	if(parentP.transform.childCount < 6)
		// 	{
		// 		ShapeSpawn();
		// 	}
		// // }
		// Vector3 p = parentP.transform.position;

		// parentP.transform.position = new Vector3(0, Mathf.Clamp( p.y, -0f, 0f ), 0);
		// parentP.transform.position += new Vector3(0, -1, 0);
	}

	internal void ShapeSpawn()
	{
		int index = Random.Range(0,2);
		GameObject Shape = 	Instantiate(Shapes[index], transform.position, transform.rotation);
		Shape.transform.parent = parentP.transform;

		countPos = countPos - 1.5f;
		parentP.transform.position = new Vector2(0, countPos);
		// if(parentP.transform.childCount < 6)
		// {
			// for(int i = 0; i < 6; i++)
			// {
			// 	parentP.transform.GetChild(i).transform.position += new Vector3(0, -1, 0); 
			// }
		// }
	}
}
