using UnityEngine;
using System.Collections;

public class cubeSpawn : MonoBehaviour {

	GameObject enemy;
	float RNGesus;
	float RNGesus2;
	// Use this for initialization
	void Start () {
		RNGesus = Random.value;
		RNGesus2 = Random.value;
		if (RNGesus > 0.5f) {
			enemy = GameObject.CreatePrimitive (PrimitiveType.Cube);
		} else {
			enemy = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		}
		if (RNGesus2 > 0.5f) {
			enemy.transform.position = new Vector3 (-2.0f, 0.25f, 0);
		} else {
			enemy.transform.position = new Vector3 (2.0f, -0.25f, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
