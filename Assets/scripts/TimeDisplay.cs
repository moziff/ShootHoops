using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

	Text text;


	// Use this for initialization
	void Start () {
		text = GetComponent<Text>(); 
	}

	// Update is called once per frame
	void Update () {
		float time = FindObjectOfType<LevelManager> ().time_next_level;
		text.text = "Time: "+ time;
	}
}
