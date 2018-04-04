using System.Collections;
using UnityEngine.SceneManagement; //allows to load new scenes or restart the current one
using UnityEngine;

public class EndGame : MonoBehaviour {

	void OnTriggerEnter2D()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
