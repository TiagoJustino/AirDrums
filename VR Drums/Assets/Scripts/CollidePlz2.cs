using UnityEngine;
using System.Collections;

public class CollidePlz2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collisionInfo)
	{

		if (collisionInfo.relativeVelocity.magnitude != 0)
		{
			//If the hit is going downwards
			if(collisionInfo.relativeVelocity.y < 0)
				audio.Play ();
		}
	}
}
