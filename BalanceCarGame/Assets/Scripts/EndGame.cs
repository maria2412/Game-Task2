using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //allows to load new scenes or restart the current one
using UnityEngine;

public class EndGame : MonoBehaviour {

	public Text endText;
	public bool finished;

	void Start()
	{
		finished = false;
	}

	void Update(){
		//when the player loses the game freezes and is restarted when the player presses the spacebar
		if (Input.GetKey (KeyCode.Space) && finished) {

			Time.timeScale = 1; // game will no longer be paused as it is 1
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	void OnTriggerEnter2D(Collider2D colInfo)
	{
		//if the car hits the crate, or the map, the player wil lose and scene is restarted
		if (colInfo.CompareTag ("Collidable")) 
		{
			Time.timeScale = 0;
			endText.text = "Game Ended! Press Spacebar to play again!";
		} else if (colInfo.CompareTag ("Player"))
		{
			Time.timeScale = 0;
			endText.text = "Game Ended! Press Spacebar to play again!";
		}

			
	}

			
}


