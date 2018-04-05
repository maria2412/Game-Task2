using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoalComponent : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D colInfo)
	{
		//if the player hits the flag, the user wins the game and the game is restarted
		if (colInfo.CompareTag("Player")) {
			Debug.Log ("You won the game");
		}
		
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		
	}
}
