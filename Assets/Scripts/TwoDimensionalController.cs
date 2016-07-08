using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TwoDimensionalController : MonoBehaviour {
	public float speed = 3f;
	Rigidbody2D _rigidBody;
	public float anglarSpeed = 90f; //degree per seconds
	List<Vector2> inputStack;



	// Use this for initialization
	void Start () {
		_rigidBody = GetComponent<Rigidbody2D> ();
		_rigidBody.velocity = transform.up;
		inputStack = new List<Vector2> ();
		inputStack.Add (Vector3.zero);
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (_rigidBody.velocity);
		
		Vector3 direction = Vector3.zero;
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			inputStack.Add(Vector2.left);
		} else if (Input.GetKeyDown (KeyCode.RightArrow))
			inputStack.Add(Vector2.right);
		else if (Input.GetKeyDown (KeyCode.UpArrow))
			inputStack.Add(Vector2.up);
		else if (Input.GetKeyDown (KeyCode.DownArrow))
			inputStack.Add(Vector2.down);
		else if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			inputStack.RemoveAll(element => element == Vector2.left);
		} else if (Input.GetKeyUp (KeyCode.RightArrow))
			inputStack.RemoveAll(element => element == Vector2.right);
		else if (Input.GetKeyUp (KeyCode.UpArrow))
			inputStack.RemoveAll(element => element == Vector2.up);
		else if (Input.GetKeyUp (KeyCode.DownArrow))
			inputStack.RemoveAll(element => element == Vector2.down);
		direction = inputStack [inputStack.Count - 1];
		Debug.Log (direction);
		_rigidBody.velocity = Quaternion.Euler (0f, 0f, isTurnLeft(_rigidBody.velocity, direction) * anglarSpeed * Time.deltaTime * 75f) * _rigidBody.velocity.normalized * speed;

	}

	private int isTurnLeft(Vector2 vec1, Vector2 vec2)
	{
		Vector3 _vec1 = vec1.normalized;
		Vector3 _vec2 = vec2.normalized;
		Vector3 _cross = Vector3.Cross (_vec1, _vec2);
		if (_cross.z > 0.01f)
			return 1;
		else if (_cross.z < -0.01f)
			return -1;
		else return 0;
	}
}
