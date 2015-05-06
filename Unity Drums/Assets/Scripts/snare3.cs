using UnityEngine;
using System.Collections;

public class snare3 : MonoBehaviour 
{

	public Material defaultMaterial;
	public Material playMaterial;


	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		renderer.material = defaultMaterial;
		if (Input.GetKeyDown (KeyCode.Q)) // plays the snare
		{
			playDrum();
		}
	}

	private void playDrum()
	{
		GameObject Obj = GameObject.Find("Progress Bar");
		Tutorial3Script obj = (Tutorial3Script)Obj.gameObject.GetComponent("Tutorial3Script");
		obj.initialize();

		renderer.material = playMaterial;
		audio.Play();
		Debug.Log("Plaaaay");

		obj.feedback("snare");
	}
}