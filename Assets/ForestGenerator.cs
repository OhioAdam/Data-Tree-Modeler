﻿using UnityEngine;
using System.Collections;

public class ForestGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Instantiate(tree, gameObject.transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
