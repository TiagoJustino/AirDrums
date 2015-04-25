using UnityEngine;
using System.Collections;

public class drum1 : MonoBehaviour 
{

	public Material defaultMaterial;
	public Material playMaterial;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		renderer.material = defaultMaterial;
		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			renderer.material = playMaterial;
			audio.Play();
		}
	}
}
