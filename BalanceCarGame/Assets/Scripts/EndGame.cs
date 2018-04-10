using System.Collections;
using UnityEngine.SceneManagement; //allows to load new scenes or restart the current one
using UnityEngine;

public class EndGame : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D colInfo)
	{
		//if the car hits the crate, or the map, the player wil lose and scene is restarted
		if (colInfo.CompareTag ("Collidable")) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
			
	}



}
