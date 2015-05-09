using UnityEngine;
using System.Collections;

public class tomtom : MonoBehaviour {

	// Use this for initialization

    public Material defaultMaterial;
	public Material playMaterial;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material = defaultMaterial;
		if (Input.GetKeyDown (KeyCode.W))
		{
			playDrum();
		}
	}

    private void playDrum()
	{
		GameObject Obj = GameObject.Find("Progress Bar");
        Tutorial1Script obj = (Tutorial1Script)Obj.gameObject.GetComponent("Tutorial1Script");
        obj.drumType = 3;
        //obj.initialize();

		renderer.material = playMaterial;
		audio.Play();
		Debug.Log("Plaaaay");

		obj.feedback();
	}
}
