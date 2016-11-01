using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	public float time_next_level = 15.0f;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		time_next_level -= Time.deltaTime;
		if (time_next_level<0)
		{
			LoadNextScene();
		}


	}

	public void LoadNextScene()
	{

		if (SceneManager.GetActiveScene ().buildIndex == 2) {
			SceneManager.LoadScene (0);
		} else {
			int currentIndex = SceneManager.GetActiveScene ().buildIndex;
			SceneManager.LoadScene (currentIndex + 1);
		}
	}
}