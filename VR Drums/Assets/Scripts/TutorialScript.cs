using UnityEngine;
using System.Collections;

public class TutorialScript : MonoBehaviour {

	public GameObject CorrectNote;
	public GameObject WrongNote;
	public int noteCount;
    public int count = -1;
	private Vector3[] initialPosition;
    private Vector3[] notePosition;
	public float Barspeed;
    private string[] DrumType;
    private string drumType;
    public int lessonNum;
    private bool start;

	// Use this for initialization
	void Start () 
	{
        start = false;
        initialPosition = new Vector3[24];
        notePosition = new Vector3[10];
        DrumType = new string[10];
        drumType = "";
        initialPosition[0] = new Vector3(3.432547f, 3.604739f, 7.996204f); //hihat 1
        initialPosition[1] = new Vector3(2.492673f, 3.636118f, 7.996204f); //hihat 2
        initialPosition[2] = new Vector3(1.507733f, 3.636118f, 7.996204f); //hihat 3
        initialPosition[3] = new Vector3(0.5323566f, 3.621357f, 7.996204f); //hihat 4
        initialPosition[4] = new Vector3(-0.4145995f, 3.606776f, 7.996204f); //hihat 5
        initialPosition[5] = new Vector3(-1.344433f, 3.610593f, 7.996204f); //hihat 6
        initialPosition[6] = new Vector3(-2.348921f, 3.596923f, 7.996204f); //hihat 7
        initialPosition[7] = new Vector3(-3.32729f, 3.610302f, 7.996204f); //hihat 8

        initialPosition[8] = new Vector3(3.432547f, 3.136315f, 7.996204f); //snare 1
        initialPosition[9] = new Vector3(2.492673f, 3.153215f, 7.996204f); //snare 2
        initialPosition[10] = new Vector3(1.507733f, 3.138794f, 7.996204f); //snare 3
        initialPosition[11] = new Vector3(0.5323566f, 3.152649f, 7.996204f); //snare 4
        initialPosition[12] = new Vector3(-0.4145995f, 3.164584f, 7.996204f); //snare 5
        initialPosition[13] = new Vector3(-1.344433f, 3.16808f, 7.996204f); //snare 6
        initialPosition[14] = new Vector3(-2.348921f, 3.182255f, 7.996204f); //snare 7
        initialPosition[15] = new Vector3(-3.32729f, 3.18105f, 7.996204f); //snare 8

        initialPosition[16] = new Vector3(3.432547f, 3.077803f, 7.996204f); //tomtom 1
        initialPosition[17] = new Vector3(2.492673f, 3.077803f, 7.996204f); //tomtom 2
        initialPosition[18] = new Vector3(1.507733f, 3.077803f, 7.996204f); //tomtom 3
        initialPosition[19] = new Vector3(0.5323566f, 3.077803f, 7.996204f); //tomtom 4
        initialPosition[20] = new Vector3(-0.4145995f, 3.077803f, 7.996204f); //tomtom 5
        initialPosition[21] = new Vector3(-1.344433f, 3.077803f, 7.996204f); //tomtom 6
        initialPosition[22] = new Vector3(-2.348921f, 3.077803f, 7.996204f); //tomtom 7
        initialPosition[23] = new Vector3(-3.32729f, 3.077803f, 7.996204f); //tomtom 8
        //Debug.Log(lessonNum);
        
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
            DrumType[0] = "hihat";
            DrumType[1] = "hihat";
            DrumType[2] = "hihat";
            DrumType[3] = "hihat";
            DrumType[4] = "hihat";
            DrumType[5] = "hihat";
            DrumType[6] = "hihat";
            DrumType[7] = "hihat";
        }
        else if (lessonNum == 2)
        {
            notePosition[0] = initialPosition[15];
            notePosition[1] = initialPosition[14];
            notePosition[2] = initialPosition[13];
            notePosition[3] = initialPosition[12];

            notePosition[4] = initialPosition[11];
            notePosition[5] = initialPosition[10];
            notePosition[6] = initialPosition[9];
            notePosition[7] = initialPosition[8];
            DrumType[0] = "snare";
            DrumType[1] = "snare";
            DrumType[2] = "snare";
            DrumType[3] = "snare";
            DrumType[4] = "snare";
            DrumType[5] = "snare";
            DrumType[6] = "snare";
            DrumType[7] = "snare";
        }
        else if (lessonNum == 3)
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

            DrumType[0] = "hihat";
            DrumType[1] = "hihat";
            DrumType[2] = "snare";
            DrumType[3] = "hihat";
            DrumType[4] = "hihat";


            DrumType[5] = "hihat";
            DrumType[6] = "hihat";
            DrumType[7] = "snare";
            DrumType[8] = "hihat";
            DrumType[9] = "hihat";
        }
        else if (lessonNum == 4)
        {
            notePosition[0] = initialPosition[23];
            notePosition[1] = initialPosition[22];
            notePosition[2] = initialPosition[21];
            notePosition[3] = initialPosition[20];
            notePosition[4] = initialPosition[19];
            notePosition[5] = initialPosition[18];
            notePosition[6] = initialPosition[17];
            notePosition[7] = initialPosition[16];
            DrumType[0] = "tomtom";
            DrumType[1] = "tomtom";
            DrumType[2] = "tomtom";
            DrumType[3] = "tomtom";
            DrumType[4] = "tomtom";
            DrumType[5] = "tomtom";
            DrumType[6] = "tomtom";
            DrumType[7] = "tomtom";
        }
        else if (lessonNum == 5)
        {
            notePosition[0] = initialPosition[23];
            notePosition[1] = initialPosition[6];
            notePosition[2] = initialPosition[13];
            notePosition[3] = initialPosition[4];
            notePosition[4] = initialPosition[19];
            notePosition[5] = initialPosition[2];
            notePosition[6] = initialPosition[9];
            notePosition[7] = initialPosition[0];
            DrumType[0] = "tomtom";
            DrumType[1] = "hihat";
            DrumType[2] = "snare";
            DrumType[3] = "hihat";
            DrumType[4] = "tomtom";
            DrumType[5] = "hihat";
            DrumType[6] = "snare";
            DrumType[7] = "hihat";
        }
    }

	public void feedback(string drumType)
	{
        print("feedback has been called");
        if(start==true)
        {
    		// Each hit corresponds to a note on the sheet.
    		// when note is hit, make copy of one of the balls and 
    		// place them on top of a note.
    		// Green note when progress bar is over a note
    		// Red note when played out of time
            print("drum type played:"+drumType);
            count++;
            print("COUNT"+count);
    		if(count>=0 && count<noteCount)
    		{
    			//check timing here!
    			//checking if drum is played when bar is within +/- 0.2 (x coord) of the note
    			float pos = transform.position.x;
                //print("bar position x:"+transform.position.x);
                //print("bar position y:"+transform.position.y);
                //print("bar position z:"+transform.position.z);
                
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

                if ((notePosition[count].x - 0.2f <= pos) && (notePosition[count].x + 0.2f >= pos) && (drumType == DrumType[count]))
                {
                    Instantiate(CorrectNote, notePosition[count], Quaternion.identity);
                    print("CorrectNote!");
                }
                else
                {
                    Instantiate(WrongNote, notePosition[count], Quaternion.identity);
                    print("WrongNote!");
                }  
    		}
        }
	}
	
	// Update is called once per frame
	void Update () 
	{
        if(Input.GetKeyDown (KeyCode.Space))
            start = true;

        if(start==true)    
    	{   
            //calculate the distance for moving the bar (per frame)
    		float moveBar = Barspeed * Time.deltaTime;
    		
    		//move the bar
    		if(transform.position.x<4.5)
    		{
    			transform.Translate(Vector3.right * moveBar);
    		}
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