using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoalComponent : MonoBehaviour {


	public Text scoreText;
	private int count=0;
	public bool finished;

	void Start()
	{
		finished = false;
	}

	//is called whenever the game has to be restarted
	void Update(){
		//when the player loses the game freezes and is restarted when the player presses the spacebar
		if (Input.GetKey (KeyCode.Space) && finished) {

			Time.timeScale = 1; // game will no longer be paused as it is 1
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	void OnTriggerEnter2D(Collider2D colInfo)
	{
		//if the player hits the flag, the user wins the game and the game is restarted
		if (colInfo.CompareTag("Player")) {
			count = count + 10;
			//SetCountText ();
			Time.timeScale = 0;
			finished = true;
		}

	}

	void SetCountText()
	{
		scoreText.text = "Score: " + count.ToString ();
	}
}
