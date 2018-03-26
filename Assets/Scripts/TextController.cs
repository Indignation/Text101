using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	// Use this for initialization

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell)
		{
			state_cell();
		}
		else if (myState == States.sheets_0)
		{
			state_sheets_0();
		}
		else if (myState == States.mirror)
		{
			state_mirror();
		}
		else if (myState == States.lock_0)
		{
			state_lock_0();
		}
	}

	public void stateChanger1()
	{
		if (Input.GetKeyDown(KeyCode.C))
		{
			myState = States.cell;
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.sheets_0;
		}
		else if(Input.GetKeyDown(KeyCode.M))
		{
			myState = States.mirror;
		}
		else if(Input.GetKeyDown(KeyCode.L))
		{
			myState = States.lock_0;
		}
	}

	void state_cell ()
	{
		text.text = "Dudeman was a mean guy who was in prison. In the prison there was a " +
					"painting on the wall that just said 'Prison' to remind Mean Dudeman that he was " +
					"indeed in prison.\n \n" +
					"Press 'S' to view Sheets \n" +
					"Press 'M' to view Mirror \n" +
					"Press 'L' to view Lock";

		stateChanger1();
	}

		void state_sheets_0 ()
	{
		text.text = "Dudeman looked at his sheets and for a moment thought about hanging himself. It's been a while since he saw the outside world. But today is " +
					"the day he's getting out and this is no time to despair. He looks around the cell for other things once more. \n \n" +
					"Press 'C' to view Cell \n" +
					"Press 'M' to view Mirror \n" +
					"Press 'L' to view Lock";

		stateChanger1();
	}

		void state_mirror ()
	{
		text.text = "Dudeman looked in the mirror. During his time in prison he had grown an ugly neckbeard. It was the main reason " +
					"he wanted to get out. To shave that ugly beard. God damn. \n \n" +
					"Press 'C' to view Cell \n" +
					"Press 'S' to view Sheets \n" +
					"Press 'L' to view Lock";

		stateChanger1();
	}

		void state_lock_0 ()
	{
		text.text = "Mean Dudeman stared at the lock of his cell very intently. There had to be a way out of this shithole, he thought." +
					" \n \n" +
					"Press 'C' to view Cell \n" +
					"Press 'S' to view Sheets \n" +
					"Press 'L' to view Lock";

		stateChanger1();
	}
}
