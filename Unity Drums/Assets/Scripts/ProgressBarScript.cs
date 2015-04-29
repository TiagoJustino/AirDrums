using UnityEngine;
using System.Collections;

public class ProgressBarScript : MonoBehaviour {

	public float speed;
	//private Vector3 startPoint = new Vector3(4.6f,0.1f,1.5f);

	// Use this for initialization
	void Start () 
	{
		GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//calculate the distance for moving the bar (per frame)
		float moveBar = speed * Time.deltaTime;
		
		//move the bar
		if(transform.position.x<3.5)
		{
			transform.Translate(Vector3.right * moveBar);
		}
		else
			GetComponent<AudioSource>().Stop();
	}
}
