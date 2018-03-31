using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	// Use this for initialization

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, breakout_1, lock_0_dance, lock_0_persuade, lock_0_pee, hallway_arrive, hallway_rightleft, lock_1, lock_1_satan, lock_1_tackle, lock_1_giveup, escape};
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
		else if (myState == States.hallway_rightleft)
		{
			state_hallway_leftright();
		}
		else if (myState == States.lock_1)
		{
			state_hallway_lock_1();
		}
		else if (myState == States.lock_1_satan)
		{
			state_lock_1_satan();
		}
		else if (myState == States.lock_1_tackle)
		{
			state_lock_1_tackle();
		}
		else if (myState == States.lock_1_giveup)
		{
			state_lock_1_giveup();
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

	// Function for changing states in final lock
	public void finalEscapeChoices()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			myState = States.lock_1_satan;
		}
		if(Input.GetKeyDown(KeyCode.T))
		{
			myState = States.lock_1_tackle;
		}
		if (Input.GetKeyDown(KeyCode.G))
		{
			myState = States.lock_1_giveup;
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			myState = States.lock_1;
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
		"Finally he finds the perfect thing. With his rough voice he whispers in the most sensual manner he can: 'Bloodborne 2 out September 2018'. " +
		"Immediately the lock turns bright red and melts. The cell door opens.\n\n" +
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
		text.text = "Mean Dudeman arrives to a hallway full of cell doors. Right in front of him there is a hallway that ends with a huge door that says 'Escape Here'. " +
		"There are also hallways on his left and right sides that end in a smaller door that say 'No Escape Here'. Which hallway should he choose?\n\n" +
		"Press 'F' to go forward\nPress 'L' to go left\nPress 'R' to go right";

		if (Input.GetKeyDown(KeyCode.F))
		{
			myState = States.lock_1;
		}
		else if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.L))
		{
			myState = States.hallway_rightleft;
		}
	}

	void state_hallway_leftright()
	{
		text.text = "Lets not be stupid here. Press space to go back dumdum";
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			myState = States.hallway_arrive;
		}
	}

	void state_hallway_lock_1()
	{
		text.text = "Mean Dudeman arrives at what he presumes to be the final lock. He bases this on the thought that the idea of a prison having more than two locks is idiotic. " +
		"He rattles the lock. 'Theres no peeing through this one' he mutters to himself. But surely there is a way. What should Dudeman do?\n\n" +
		"Press 'S' to try to summon Satan\n" +
		"Press 'T' to tackle the door\n" +
		"Press 'G' to give up";

		finalEscapeChoices();
	}

	void state_lock_1_satan()
	{
		text.text = "In the joint Mean Dudeman was introduced to a historically accurate documentary 'South Park' that among other stories tells how Satan is actually in a homosexual " +
		"relationship with Saddam Hussein. He had seen Satan often being summoned in time of need and so Dudeman figured maybe the lord of darkness could help him too in exchange " +
		"for what they in the prison refered to as 'butt price'.\n\n" +
		"Dudeman cut himself by banging his forehead on the door. He thought about using his feces first, but then concluded that'd be too stupid even for this game. He used his gushing forehead " +
		"to draw a pentagram on the floor. Then he muttered 'O Satan please help me through this' and sat on the ground patiently waiting. After 15 minutes he collapsed and died from blood loss. " +
		"One might say that death is the greatest freedom. But not Dudeman. Because he was dead.\n\nThe End.";

		if (Input.anyKeyDown)
		{
			Application.Quit();
		}
	}

	void state_lock_1_tackle()
	{
		text.text = "Dudeman walks calmly to the back of the hallway, as far away from the door as he can. He takes a breath. He puts on his helmet that he had with him all this time. " +
		"He imagines a crowd chanting for him. 'Dude-man, Dude-man' they go. Another deep breath. He tenses his muscles, sheds a single tear and starts charging at the door. " +
		"He crashes in to the door with unimaginably low speed, the door opens and rays of sunshine warm his face for the first time since forever. " +
		"Turns out the door hadn't been locked this whole time. Shit.\n\n" +
		"Dudeman walks down to the shore to enjoy his newfound freedom. After bathing in the sunlight for a while he suddenly hears a loud bang. A plane crashes in to the island " +
		"where the prison is located. He suddenly realises he lives inside a Lost fanfic. Tears of joy run down his face with the revelation that it'll finally end. The plane " +
		"crashes in to the island and burns everything in to ashes. He wakes up back in his cell. Oh shit.\n\nThe End.";

		if (Input.anyKeyDown)
		{
			Application.Quit();
		}
	}

	void state_lock_1_giveup()
	{
		text.text = "Suddenly Mean Dudeman realized how tired he is. He walks all the way back to his cell, closes the first door and takes a nap. 'Better luck next time' he thinks " +
		"and falls asleep. While napping he sees a dream about a golden retriever puppy riding on a giant frog. This was definitely the right choice.\n\nThe End.";

		if (Input.anyKeyDown)
		{
			Application.Quit();
		}
	}
}
