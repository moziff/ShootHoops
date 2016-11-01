using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour {

	Text text;


	// Use this for initialization
	void Start () {
		text = GetComponent<Text>(); 
	}

	// Update is called once per frame
	void Update () {
		int score = FindObjectOfType<ScoreAbsorber>().score;
		text.text = "Score: "+ score;
	}
}
