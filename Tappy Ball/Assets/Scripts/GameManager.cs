using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public bool gameOver;

	void Awake()
	{
		DontDestroyOnLoad (this.gameObject); 
		if (instance == null)
			instance = this;
		else {
			Destroy (this.gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		gameOver = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void GameStarts()
	{
		
	}
	public void GameOver()
	{
		GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StopSpawning ();
		gameOver = false;
		ScoreManager.instance.StopScore ();
		UIManager.instance.GameOver ();
	}
}
