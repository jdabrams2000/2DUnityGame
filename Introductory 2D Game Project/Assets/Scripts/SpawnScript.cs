using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public Vector2 pos = new Vector2(-4,0);
	public float size = 1.0f;
	public Vector2 dir = Vector2.right;

	// Use this for initialization
	void Start () {
		StartCoroutine (Spawn ());
	}
	
	IEnumerator Spawn() {
		while (true) {
			Instantiate(obj [Random.Range(0,obj.Length)], pos, Quaternion.identity);
			pos += dir * size;
			yield return new WaitForSeconds(Random.Range(spawnMin, spawnMax));
		}
	}
}
