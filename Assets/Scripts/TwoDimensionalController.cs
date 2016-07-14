using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TwoDimensionalController : MonoBehaviour {
	public float speed = 3f;
	public float upTurnTime = 3.0f;
	public float leftTurnTime = 3.0f;
	public float downTurnTime = 3.0f;
	public float rightTurnTime = 3.0f;
	Rigidbody2D _rigidBody;
	public float anglarSpeed = 90f; //degree per seconds
	List<int> inputStack;

	// Use this for initialization
	void Start () {
		_rigidBody = GetComponent<Rigidbody2D> ();
		_rigidBody.velocity = transform.up;
		inputStack = new List<int> ();
		inputStack.Add (0);
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (_rigidBody.velocity);
		
		Vector3 direction = Vector3.zero;
		int currentDirect = inputStack[inputStack.Count - 1];
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			if (currentDirect != 1)
				inputStack.Add(1);
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			if (currentDirect != 2)
				inputStack.Add(2);
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			if (currentDirect != 3)
				inputStack.Add(3);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			if (currentDirect != 4)
			inputStack.Add(4);
		}

		while (inputStack.Count > 1) 
		{
			currentDirect = inputStack[inputStack.Count - 1];
			if (currentDirect == 1)
			{
				if (!Input.GetKey(KeyCode.LeftArrow))
					inputStack.RemoveAt(inputStack.Count - 1);
				else
					break;
			}
			if (currentDirect == 2)
			{
				if (!Input.GetKey(KeyCode.RightArrow))
					inputStack.RemoveAt(inputStack.Count - 1);
				else
					break;
			}
			if (currentDirect == 3)
			{
				if (!Input.GetKey(KeyCode.UpArrow))
					inputStack.RemoveAt(inputStack.Count - 1);
				else
					break;
			}
			if (currentDirect == 4)
			{
				if (!Input.GetKey(KeyCode.DownArrow))
					inputStack.RemoveAt(inputStack.Count - 1);
				else
					break;
			}

		}
		currentDirect = inputStack[inputStack.Count - 1];

		if (currentDirect == 0)
			direction = Vector2.zero;
		else if (currentDirect == 1)
			direction = Vector2.left;
		else if (currentDirect == 2)
			direction = Vector2.right;
		else if (currentDirect == 3)
			direction = Vector2.up;
		else if (currentDirect == 4)
			direction = Vector2.down;


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
