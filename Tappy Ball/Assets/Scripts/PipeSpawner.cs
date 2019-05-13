using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

	public float maxYPos;
	public float spawnTime;
	public GameObject pipe;
	// Use this for initialization
	void Start () {
		StartSpawning ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void StopSpawning()
	{
		CancelInvoke ("SpawnPipe");
	}

	public void StartSpawning()
	{
		InvokeRepeating ("SpawnPipe", 0.2f, spawnTime);
	}

	void SpawnPipe()
	{
		Instantiate (pipe, new Vector3 (transform.position.x, Random.Range (-maxYPos, maxYPos), 0), Quaternion.identity);
	}
}
