using UnityEngine;
using System.Collections;

public class drum2 : MonoBehaviour 
{

	public Material defaultMaterial;
	public Material playMaterial;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<Renderer>().material = defaultMaterial;
		if (Input.GetKeyDown (KeyCode.W)) 
		{
			GetComponent<Renderer>().material = playMaterial;
			GetComponent<AudioSource>().Play();
		}
	}
}
