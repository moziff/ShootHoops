﻿using UnityEngine;
using System.Collections;

public class ThudSound : MonoBehaviour {


	void OnCollisionEnter(Collision collision){
	
		AudioSource source = GetComponent<AudioSource> ();
		source.Play ();
	}
}
