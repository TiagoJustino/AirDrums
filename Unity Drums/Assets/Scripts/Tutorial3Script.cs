using UnityEngine;
using System.Collections;

public class Tutorial3Script : MonoBehaviour {

	public GameObject CorrectNote;
	public GameObject WrongNote;
	public int noteCount;
	private Vector3[] hihap;
	private Vector3[] snare;
	public float Barspeed;

	// Use this for initialization
	void Start () 
	{}

	public void initialize()
	{
		//initializing the position for placing the note feedback
		//notes are stored in reverse order
		//e.g. note 1 -> [7], note 2 ->[6] etc.
		hihap = new Vector3[8];
		snare = new Vector3[2];
	}

	public void feedback(string name)
	{
		// Each hit corresponds to a note on the sheet.
		// when note is hit, make copy of one of the balls and 
		// place them on top of a note.
		// Green note when progress bar is over a note
		// Red note when played out of time

		/*noteCount--;
		if(noteCount>=0)
		{
			//check timing here!
			//checking if drum is played when bar is within +/- 0.2 (x coord) of the note
			float pos = transform.position.x;
			if( (notePosition[noteCount].x - 0.2f <= pos) && (notePosition[noteCount].x + 0.2f >= pos) )
			{
				Debug.Log(noteCount);
				Debug.Log(notePosition[noteCount]);
				Instantiate( CorrectNote, notePosition[noteCount], Quaternion.identity);
			}
			else
			{
				Instantiate( WrongNote, notePosition[noteCount], Quaternion.identity);
			}
		}*/
	}
	
	// Update is called once per frame
	void Update () 
	{
		//calculate the distance for moving the bar (per frame)
		float moveBar = Barspeed * Time.deltaTime;
		
		//move the bar
		if(transform.position.x<4.5)
		{
			transform.Translate(Vector3.right * moveBar);
		}

		/*if(notePosition[noteCount].x + 0.2f < transform.position.x)
		{
			Instantiate( WrongNote, notePosition[noteCount], Quaternion.identity);
			noteCount--;
		}*/
	}
}

//hihap[1]
//hihap[2]
//hihap[3]
//hihap[4]
//hihap[5]
//hihap[6]
//hihap[7]
//hihap[8]

//snare[1]
//snare[2]*/