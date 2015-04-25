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
		renderer.material = defaultMaterial;
		if (Input.GetKeyDown (KeyCode.W)) 
		{
			renderer.material = playMaterial;
			audio.Play();
		}
	}
}
