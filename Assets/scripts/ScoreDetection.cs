using UnityEngine;
using System.Collections;

public class ScoreDetection : MonoBehaviour {

	public int score_value = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		FindObjectOfType<ScoreKeeper>().IncrementScore(score_value);
	}
}
