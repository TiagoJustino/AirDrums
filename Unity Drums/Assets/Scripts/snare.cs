using UnityEngine;
using System.Collections;

public class snare : MonoBehaviour 
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
		Tutorial2Script obj = (Tutorial2Script)Obj.gameObject.GetComponent("Tutorial2Script");
		obj.initialize();

		renderer.material = playMaterial;
		audio.Play();
		Debug.Log("Plaaaay");

		obj.feedback();
	}
}