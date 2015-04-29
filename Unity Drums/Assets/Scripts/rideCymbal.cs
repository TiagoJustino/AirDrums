﻿using UnityEngine;
using System.Collections;

public class rideCymbal : MonoBehaviour 
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
		if (Input.GetKeyDown (KeyCode.D)) 
		{
			temp[0] = playMaterial;
			GetComponent<AudioSource>().Play();
		}
		GetComponent<Renderer> ().materials = temp;
	}
}
