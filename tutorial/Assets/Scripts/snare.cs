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
		Tutorial1Script obj = (Tutorial1Script)Obj.gameObject.GetComponent("Tutorial1Script");
        obj.drumType = 2;
		//obj.initialize();

		renderer.material = playMaterial;
		audio.Play();
		Debug.Log("Plaaaay");

		obj.feedback();
	}
}