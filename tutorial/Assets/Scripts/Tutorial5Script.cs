using UnityEngine;
using System.Collections;

public class Tutorial5Script : MonoBehaviour
{
    public GameObject CorrectNote;
    public GameObject WrongNote;
    public int noteCount;
    private Vector3[] notePosition;
    public float Barspeed;

    // Use this for initialization
    void Start()
    {
    }

    public void initialize()
    {
        //initializing the position for placing the note feedback
        //notes are stored in reverse order
        //e.g. note 1 -> [7], note 2 ->[6] etc.
        notePosition = new Vector3[8];
        notePosition[0] = new Vector3(3.432547f, 3.136315f, 7.00f);
        notePosition[1] = new Vector3(2.492673f, 3.153215f, 7.996204f);
        notePosition[2] = new Vector3(1.507733f, 3.138794f, 7.996204f);
        notePosition[3] = new Vector3(0.5323566f, 3.152649f, 7.996204f);
        notePosition[4] = new Vector3(-0.4145995f, 3.164584f, 7.996204f);
        notePosition[5] = new Vector3(-1.344433f, 3.16808f, 7.996204f);
        notePosition[6] = new Vector3(-2.348921f, 3.182255f, 7.996204f);
        notePosition[7] = new Vector3(-3.32729f, 3.18105f, 7.996204f);
    }

    public void feedback()
    {
        // Each hit corresponds to a note on the sheet.
        // when note is hit, make copy of one of the balls and 
        // place them on top of a note.
        // Green note when progress bar is over a note
        // Red note when played out of time

        noteCount--;
        if (noteCount >= 0)
        {
            //check timing here!
            //checking if drum is played when bar is within +/- 0.2 (x coord) of the note
            float pos = transform.position.x;
            if ((notePosition[noteCount].x - 0.2f <= pos) && (notePosition[noteCount].x + 0.2f >= pos))
            {
                Debug.Log(noteCount);
                Debug.Log(notePosition[noteCount]);
                Instantiate(CorrectNote, notePosition[noteCount], Quaternion.identity);
            }
            else
            {
                Instantiate(WrongNote, notePosition[noteCount], Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        //calculate the distance for moving the bar (per frame)
        float moveBar = Barspeed * Time.deltaTime;

        //move the bar
        if (transform.position.x < 4.5)
        {
            transform.Translate(Vector3.right * moveBar);
        }

    }
}

