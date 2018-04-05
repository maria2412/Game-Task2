using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoalComponent : MonoBehaviour {


	public Text scoreText;
	private int count=0;

	void OnTriggerEnter2D(Collider2D colInfo)
	{
		//if the player hits the flag, the user wins the game and the game is restarted
		if (colInfo.CompareTag("Player")) {
			count = count + 10;
			SetCountText ();
		}

		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	void SetCountText()
	{
		scoreText.text = "Score: " + count.ToString ();
	}
}
