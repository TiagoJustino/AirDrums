using UnityEngine;
using System.Collections;

public class floorTom : MonoBehaviour 
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
		temp[2] = defaultMaterial;
		if (Input.GetKeyDown (KeyCode.L)) 
		{
			temp[2] = playMaterial;
			GetComponent<AudioSource>().Play();
		}
		GetComponent<Renderer> ().materials = temp;
	}
}
