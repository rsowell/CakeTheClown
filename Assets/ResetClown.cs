﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetClown : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void ResetClownOnHit () {
		gameObject.transform.localScale = Vector3.one;
		gameObject.GetComponentInChildren<CollisionBehavior> ().collided = false;
	}
}
