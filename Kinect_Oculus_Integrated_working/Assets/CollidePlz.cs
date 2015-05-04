﻿using UnityEngine;
using System.Collections;

public class CollidePlz : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collisionInfo)
	{
		print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
		print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
		print("Their relative velocity is " + collisionInfo.relativeVelocity);

		if (collisionInfo.relativeVelocity.x != 0 ||
		    collisionInfo.relativeVelocity.y != 0 ||
		    collisionInfo.relativeVelocity.z != 0)
		{
			audio.Play ();
		}
	}
}