using UnityEngine;
using System.Collections;

public class snare : MonoBehaviour 
{

	//public Material defaultMaterial;
	//public Material playMaterial;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*renderer.material = defaultMaterial;
		if (Input.GetKeyDown (KeyCode.Q)) // plays the snare
		{
			playDrum();
		}*/
	}

	void OnCollisionEnter(Collision collisionInfo)
	{

		if (collisionInfo.relativeVelocity.magnitude != 0)
		{
			//If the hit is going downwards
			if(collisionInfo.relativeVelocity.y < 0)
			{
				//audio.Play ();
				playDrum();
			}
		}
	}

	private void playDrum()
	{
		GameObject Obj = GameObject.Find("Progress Bar");
		TutorialScript obj = (TutorialScript)Obj.gameObject.GetComponent("TutorialScript");
        //obj.drumType = 1;
		//obj.initialize();

		//renderer.material = playMaterial;
		audio.Play();
		//Debug.Log("Plaaaay");

		obj.feedback("snare");
	}
}