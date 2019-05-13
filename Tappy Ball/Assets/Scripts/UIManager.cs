using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	public static UIManager instance;
	public Text scoreText;
	public GameObject GameOverPanel;
	public Text HighScoreText;

	void Awake()
	{
		if (instance == null) {
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = ScoreManager.instance.score.ToString ();
	}
		
	public void GameOver()
	{
		if (BallController.instance.gameOver == true) {
			HighScoreText.text = PlayerPrefs.GetInt ("HighScore").ToString ();
			GameOverPanel.SetActive (true);
		}
	}
	public void Replay()
	{
		SceneManager.LoadScene ("Level1");
	}
	public void Menu()
	{
		SceneManager.LoadScene ("Menu");
	}
}
