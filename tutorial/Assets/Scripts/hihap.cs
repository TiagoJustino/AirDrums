using UnityEngine;
using System.Collections;

public class hihap : MonoBehaviour 
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
		if (Input.GetKeyDown (KeyCode.E)) // plays the hihap
		{
			playDrum();
		}
	}

	private void playDrum()
	{
		GameObject Obj = GameObject.Find("Progress Bar");
		Tutorial1Script obj = (Tutorial1Script)Obj.gameObject.GetComponent("Tutorial1Script");
        obj.drumType = 1;
		//obj.initialize();

		renderer.material = playMaterial;
		audio.Play();

		obj.feedback();
	}
}