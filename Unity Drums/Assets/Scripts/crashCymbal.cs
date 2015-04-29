using UnityEngine;
using System.Collections;

public class crashCymbal : MonoBehaviour 
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
		temp[0] = defaultMaterial;
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			temp[0] = playMaterial;
			GetComponent<AudioSource>().Play();
		}
		GetComponent<Renderer> ().materials = temp;
	}
}
