using UnityEngine;
using System.Collections;

public class snare : MonoBehaviour 
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
		temp[5] = defaultMaterial;
		if (Input.GetKeyDown (KeyCode.J)) 
		{
			temp[5] = playMaterial;
			GetComponent<AudioSource>().Play();
		}
		GetComponent<Renderer> ().materials = temp;
	}
}
