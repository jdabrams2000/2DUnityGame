using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {

	public float x;
	public float dX;
	private float posX;
	private float posY;

	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (x, 0);
		posX = x;
		posY = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (posX <= -4f) {
			posY = Random.Range (-3.2f,4.2f);
			posX = 4f;
		}
		else {
			posX = posX - dX;
		}
		transform.position = new Vector2 (posX, posY);
	}
}
