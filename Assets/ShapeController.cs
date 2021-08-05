using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShapeController : MonoBehaviour {

	private Vector2 direction = Vector2.zero;
	public float moveSpeed = 0.4f;
	public float clampedHeight;

	internal Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		// GameObject SphereBox = GameObject.Find("SphereBox");
		// GameObject SquareBox = GameObject.Find("SquareBox");
	}
	
	// Update is called once per frame
	void Update () {
		CheckInput();
		rb = GetComponent<Rigidbody2D>();
	}

	internal void MovePos()
	{
		if(transform.position.y  == -3)
		{
			UpdateOrientation();
		}	
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		// if(other.gameObject.tag == "Deadline")
		// {
			// Destroy(this.gameObject);
			// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		// }
	}

	internal void Move()
	{
		transform.Translate(0, 1, 0);
	}

	void CheckInput() {
		if(SwipeController.Instance.IsSwiping(SwipeDirection.left))
		{
		// if(Input.GetKeyDown(KeyCode.LeftArrow))
			// {
				direction = Vector2.left;
				MovePos();
			// }
		}
		else if(SwipeController.Instance.IsSwiping(SwipeDirection.Right))
		{
		// else if(Input.GetKeyDown(KeyCode.RightArrow))	
			// {
				direction = Vector2.right;
				MovePos();
			// }
		}

		// if(SwipeController.Instance.IsSwiping(SwipeDirection.left)) 
		// {
			// if(Input.GetKeyDown(KeyCode.LeftArrow))
			// {
				// direction = Vector2.left;
				// MovePos();
			
			// } else if(Input.GetKeyDown(KeyCode.RightArrow))
			// {
				// direction = Vector2.right;
				
		}

		// else if(SwipeController.Instance.IsSwiping(SwipeDirection.Up))
		// {
		// else if(Input.GetKeyDown(KeyCode.UpArrow)){

			// direction = Vector2.up;
		// }
		// }
		// else if(SwipeController.Instance.IsSwiping(SwipeDirection.Down))
		// {
		// else if(Input.GetKeyDown(KeyCode.DownArrow)){

			// direction = Vector2.down;
		// }	
		// }
	

	/********************************
	Movement
	********************************/
	// void Move(){
	// 	transform.localPosition += (Vector3)(direction * moveSpeed) * Time.deltaTime;
	// }

	/********************************
	Rotate to moving direction
	********************************/
	void UpdateOrientation () {

		if (direction == Vector2.left) {
			// GameObject xxa = GameObject.Find("SphereBox");
			transform.Translate(-2f, 0, 0);


			// transform.position = Vector3.MoveTowards(transform.position, xxa.transform.position, 0.5f);

			// transform.localScale = new Vector3 (-1, 1, 1);
			// transform.localRotation = Quaternion.Euler (0, 0, 10);

		} else if (direction == Vector2.right) {

			transform.Translate(2f, 0, 0);

			// transform.position = new Vector2();

			// rb.MovePosition(transform.position + transform.right * Time.deltaTime);


			// transform.localScale = new Vector3 (1, 1, 1);
			// transform.localRotation = Quaternion.Euler (0, 0, 10);


		// } else if (direction == Vector2.up) {

		// 	transform.localScale = new Vector3 (1, 1, 1);
		// 	transform.localRotation = Quaternion.Euler (0, 0, 90);

		// } else if (direction == Vector2.down) {

		// 	transform.localScale = new Vector3 (1, 1, 1);
		// 	transform.localRotation = Quaternion.Euler (0, 0, 270);
		// }
		}
	}
}
