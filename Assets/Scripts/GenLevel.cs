using UnityEngine;
using System.Collections;

public class GenLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject[] obstacles = Resources.LoadAll<GameObject>("prefabs");
		foreach(GameObject obstacle in obstacles) {
			if(obstacle.tag != "Goal") {
				for(int i = 0; i < 3; i++) {
					Instantiate(obstacle, new Vector3((Random.value * 12f) - 12f, (Random.value * 12f) - 12f, 0), Quaternion.identity);
				}
			}
			else {
				Instantiate(obstacle, new Vector3((Random.value * 12f) - 12f, (Random.value * 12f) - 12f, 0), Quaternion.identity);
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
