using UnityEngine;
using System.Collections;

public class Tutorial1Script : MonoBehaviour {

	public GameObject CorrectNote;
	public GameObject WrongNote;
	public int noteCount;
    public int count = -1;
	private Vector3[] initialPosition;
    private Vector3[] notePosition;
	public float Barspeed;
    private int[] DrumType;
    public int drumType;
    public int lessonNum;

	// Use this for initialization
	void Start () 
	{
        initialPosition = new Vector3[24];
        notePosition = new Vector3[10];
        DrumType = new int[10];
        initialPosition[0] = new Vector3(3.432547f, 3.604739f, 7.996204f);
        initialPosition[1] = new Vector3(2.492673f, 3.636118f, 7.996204f);
        initialPosition[2] = new Vector3(1.507733f, 3.636118f, 7.996204f);
        initialPosition[3] = new Vector3(0.5323566f, 3.621357f, 7.996204f);
        initialPosition[4] = new Vector3(-0.4145995f, 3.606776f, 7.996204f);
        initialPosition[5] = new Vector3(-1.344433f, 3.610593f, 7.996204f);
        initialPosition[6] = new Vector3(-2.348921f, 3.596923f, 7.996204f);
        initialPosition[7] = new Vector3(-3.32729f, 3.610302f, 7.996204f);

        initialPosition[8] = new Vector3(3.432547f, 3.136315f, 7.996204f);
        initialPosition[9] = new Vector3(2.492673f, 3.153215f, 7.996204f);
        initialPosition[10] = new Vector3(1.507733f, 3.138794f, 7.996204f);
        initialPosition[11] = new Vector3(0.5323566f, 3.152649f, 7.996204f);
        initialPosition[12] = new Vector3(-0.4145995f, 3.164584f, 7.996204f);
        initialPosition[13] = new Vector3(-1.344433f, 3.16808f, 7.996204f);
        initialPosition[14] = new Vector3(-2.348921f, 3.182255f, 7.996204f);
        initialPosition[15] = new Vector3(-3.32729f, 3.18105f, 7.996204f);

        initialPosition[16] = new Vector3(3.432547f, 3.077803f, 7.996204f);
        initialPosition[17] = new Vector3(2.492673f, 3.077803f, 7.996204f);
        initialPosition[18] = new Vector3(1.507733f, 3.077803f, 7.996204f);
        initialPosition[19] = new Vector3(0.5323566f, 3.077803f, 7.996204f);
        initialPosition[20] = new Vector3(-0.4145995f, 3.077803f, 7.996204f);
        initialPosition[21] = new Vector3(-1.344433f, 3.077803f, 7.996204f);
        initialPosition[22] = new Vector3(-2.348921f, 3.077803f, 7.996204f);
        initialPosition[23] = new Vector3(-3.32729f, 3.077803f, 7.996204f);
        Debug.Log(lessonNum);
        
        if (lessonNum == 1)
        {
            notePosition[0] = initialPosition[7];
            notePosition[1] = initialPosition[6];
            notePosition[2] = initialPosition[5];
            notePosition[3] = initialPosition[4];
            notePosition[4] = initialPosition[3];
            notePosition[5] = initialPosition[2];
            notePosition[6] = initialPosition[1];
            notePosition[7] = initialPosition[0];
            DrumType[0] = 1;
            DrumType[1] = 1;
            DrumType[2] = 1;
            DrumType[3] = 1;
            DrumType[4] = 1;
            DrumType[5] = 1;
            DrumType[6] = 1;
            DrumType[7] = 1;
        }

        if (lessonNum == 2)
        {
            notePosition[0] = initialPosition[15];
            notePosition[1] = initialPosition[14];
            notePosition[2] = initialPosition[13];
            notePosition[3] = initialPosition[12];

            notePosition[4] = initialPosition[11];
            notePosition[5] = initialPosition[10];
            notePosition[6] = initialPosition[9];
            notePosition[7] = initialPosition[8];
            DrumType[0] = 2;
            DrumType[1] = 2;
            DrumType[2] = 2;
            DrumType[3] = 2;
            DrumType[4] = 2;
            DrumType[5] = 2;
            DrumType[6] = 2;
            DrumType[7] = 2;
        }

        if (lessonNum == 3)
        {
            notePosition[0] = initialPosition[7];
            notePosition[1] = initialPosition[6];
            notePosition[2] = initialPosition[13];
            notePosition[3] = initialPosition[5];
            notePosition[4] = initialPosition[4];

            notePosition[5] = initialPosition[3];
            notePosition[6] = initialPosition[2];
            notePosition[7] = initialPosition[9];
            notePosition[8] = initialPosition[1];
            notePosition[9] = initialPosition[0];

            DrumType[0] = 1;
            DrumType[1] = 1;
            DrumType[2] = 2;
            DrumType[3] = 1;
            DrumType[4] = 1;


            DrumType[5] = 1;
            DrumType[6] = 1;
            DrumType[7] = 2;
            DrumType[8] = 1;
            DrumType[9] = 1;
        }
        if (lessonNum == 4)
        {
            notePosition[0] = initialPosition[23];
            notePosition[1] = initialPosition[22];
            notePosition[2] = initialPosition[21];
            notePosition[3] = initialPosition[20];
            notePosition[4] = initialPosition[19];
            notePosition[5] = initialPosition[18];
            notePosition[6] = initialPosition[17];
            notePosition[7] = initialPosition[16];
            DrumType[0] = 3;
            DrumType[1] = 3;
            DrumType[2] = 3;
            DrumType[3] = 3;
            DrumType[4] = 3;
            DrumType[5] = 3;
            DrumType[6] = 3;
            DrumType[7] = 3;
        }

        if (lessonNum == 5)
        {
            notePosition[0] = initialPosition[23];
            notePosition[1] = initialPosition[6];
            notePosition[2] = initialPosition[13];
            notePosition[3] = initialPosition[4];
            notePosition[4] = initialPosition[19];
            notePosition[5] = initialPosition[2];
            notePosition[6] = initialPosition[9];
            notePosition[7] = initialPosition[0];
            DrumType[0] = 3;
            DrumType[1] = 1;
            DrumType[2] = 2;
            DrumType[3] = 1;
            DrumType[4] = 3;
            DrumType[5] = 1;
            DrumType[6] = 2;
            DrumType[7] = 1;
        }


    }

	public void feedback()
	{
		// Each hit corresponds to a note on the sheet.
		// when note is hit, make copy of one of the balls and 
		// place them on top of a note.
		// Green note when progress bar is over a note
		// Red note when played out of time
        Debug.Log(drumType);
        count++;
		if(count>=0)
		{
			//check timing here!
			//checking if drum is played when bar is within +/- 0.2 (x coord) of the note
			float pos = transform.position.x;
            
            //if (lessonNum == 3 && ((count == 2))){
            //    if ((notePosition[count].x - 0.7f <= pos) && (notePosition[count].x + 0.7f >= pos)){
            //        if (drumType == 1){
            //            Instantiate(CorrectNote, notePosition[3], Quaternion.identity);
            //        }
            //        else if(drumType == 2){
            //            Instantiate(CorrectNote, notePosition[2], Quaternion.identity);
            //        }
            //    }
            //}



            //else
            //{
                if ((notePosition[count].x - 0.2f <= pos) && (notePosition[count].x + 0.2f >= pos) && (drumType == DrumType[count]))
                {
                    Instantiate(CorrectNote, notePosition[count], Quaternion.identity);
                }
                else
                {
                    Instantiate(WrongNote, notePosition[count], Quaternion.identity);
                }
            //}
		}
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

//note1 = (-3.32729, 3.556709, 7.996204)
//note2 = (-2.348921, 3.556709, 7.996204)
//note3 = (-1.344433, 3.556709, 7.996204)
//note4 = (-0.4145995, 3.606776, 7.996204)
//note5 = (0.5323566, 3.621357, 7.996204)
//note6 = (1.507733, 3.636118, 7.996204)
//note7 = (2.466387, 3.636118, 7.996204)
//note8 = (3.393084, 3.658813, 7.996204)