using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player"){
			Debug.Log("Player entered " + gameObject.name);
			}
		else{
			Debug.Log(other.tag);
		}
	}
}
