using UnityEngine;
using System.Collections;

public class mountedTom : MonoBehaviour 
{

	public Material defaultMaterial;
	public Material playMaterial;
	public Material[] temp;

	// Use this for initialization
	void Start () {
		temp = GetComponent<Renderer> ().materials;
	}
	
	// Update is called once per frame
	void Update () 
	{
		temp[6] = defaultMaterial;
		if (Input.GetKeyDown (KeyCode.K)) 
		{
			temp[6] = playMaterial;
			GetComponent<AudioSource>().Play();
		}
		GetComponent<Renderer> ().materials = temp;
	}
}
