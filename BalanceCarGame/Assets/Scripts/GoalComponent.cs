using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoalComponent : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D colInfo)
	{
		if (colInfo.CompareTag("Player")) {
			Debug.Log ("You won the game");
		}
		
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		
	}
}
