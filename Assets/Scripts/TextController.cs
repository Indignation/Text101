using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	// Use this for initialization

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, breakout_1, lock_0_dance, lock_0_persuade, lock_0_pee, hallway_arrive, lock_1, breakout_2, freedom};
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
		else if (myState == States.breakout_1)
		{
			state_breakout_1();
		}
		else if (myState == States.lock_0_dance)
		{
			state_lock_0_dance();
		}
		else if (myState == States.lock_0_persuade)
		{
			state_lock_0_persuade();
		}
		else if (myState == States.lock_0_pee)
		{
			state_lock_0_pee();
		}
		else if (myState == States.hallway_arrive)
		{
			state_hallway_arrive();
		}
	}
	// Function for changing the states in part 1 of the game
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

	public void breakout1()
	{

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
		text.text = "Mean Dudeman stared at the lock of his cell very intently. 'There has to be a way out of this shithole' he thought out loud, being the idiot he is." +
					"He smells the lock. He licks the lock. He wiggles it around and does the hokey pokey. Eventually Dudeman comes to the conclusion that he is " +
					"capable of escaping the cell. \n \n" +
					"Press 'E' to try to escape \n" +
					"Press 'C' to view Cell \n" +
					"Press 'S' to view Sheets \n" +
					"Press 'L' to view Lock";
		
		if (Input.GetKeyDown(KeyCode.E))
		{
			myState = States.breakout_1;
		}

		stateChanger1();
	}
	// The breakout starts here. Do a short sequence here where you get to make choices that probably don't matter and eventually end up in a hallway perhaps?
	// Then do the whole thing all over again and then freedom. Remember to rewrite state names for the hallway escape sequence or whatever you decide for it to be
	void state_breakout_1()
	{
		text.text = "Mean Dudeman is staring at his cell door. In his heart of hearts he knows theres a way out. What should he do? \n\n" +
		"Press 'D' to dance at the lock.\n" +
		"Press 'S' to sensually persuade the lock\n" +
		"Press 'P' to pee on the lock";

		if (Input.GetKeyDown(KeyCode.D))
		{
			myState = States.lock_0_dance;
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.lock_0_persuade;
		}
		if (Input.GetKeyDown(KeyCode.P))
		{
			myState = States.lock_0_pee;
		}
	}

	void state_lock_0_dance()
	{
		text.text = "Mean Dudeman takes a dance stance. One of his fondest memories from the outside world is seeing Michael Jackson's 'Smooth Criminal' video, which we all of " +
		"course know is the greatest music video. Dudeman wiggles around for a bit, does a spin and then attempts the anti-gravity lean. Not realizing the move is impossible he falls " +
		"forward and hits his head on the lock. The lock splits in half and the door opens.\n\n" +
		"Press 'Space' to continue.";

		if (Input.GetKeyDown(KeyCode.Space))
		{
			myState = States.hallway_arrive;
		}
	}

	void state_lock_0_persuade()
	{
		text.text = "Mean Dudeman caresses the round shape of the lock. His mind is racing through all the erotic things he could whisper at the lock in hopes of opening it. " +
		"Finally he finds the perfect thing. With his rough voice he whispers in the most sensual manner he can: 'Bloodborne 2 out September 2018'." +
		"Immediately the lock turns bright red and melts. The cell door opens\n\n" +
		"Press 'Space' to continue";

		if (Input.GetKeyDown(KeyCode.Space))
		{
			myState = States.hallway_arrive;
		}
	}

	void state_lock_0_pee()
	{
		text.text = "Being the genious he is, Mean Dudeman comes up with the idea to pee in the lock. 'It has to work', he exclaims. But immediately he realises how incredibly dehydrated he is." +
		"To fix this minor problem he dunks his head in to his toilet bowl that, of course, is sparkling clean and contains the purest of all waters because as we know the prison system " +
		"has the best, most hygienic spaces in all the world. Especially in the US. \n\nHe drinks until he can no longer. He rushes to the lock, pulls out his junk and releases a stream " +
		"of flaming hot pee in to the lock. The lock opens immediately because thats how locks work.\n\nPress 'Space' to continue";

		if (Input.GetKeyDown(KeyCode.Space))
		{
			myState = States.hallway_arrive;
		}
	}

	void state_hallway_arrive()
	{
		text.text = "You have arrived to the hallway";
	}
}
