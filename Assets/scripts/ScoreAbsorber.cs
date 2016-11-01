using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {

	public int score;

	// Use this for initialization
	void Start () {
		ScoreKeeper oldkeeper = FindObjectOfType<ScoreKeeper> ();
		score = 0;
		if (oldkeeper) {
			score = oldkeeper.score;
			DestroyObject (oldkeeper);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
