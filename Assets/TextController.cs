using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	public int slideNumber;

	// Use this for initialization
	void Start () {
		text.text = "It's Friday.";
		slideNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Mouse0) && slideNumber == 0) {
			text.text = "Friday.";
			slideNumber += 1;
		} else if (Input.GetKey (KeyCode.Mouse0) && slideNumber == 1) {
			text.text = "Do you gotta get down on Friday? (y,n)";
			slideNumber += 1;
		} else if (Input.GetKey (KeyCode.Y) && slideNumber == 2) {
			text.text = "Yeah, yeah, yeah";
			slideNumber += 1;
		} else if (Input.GetKey (KeyCode.N) && slideNumber == 2) {
			text.text = "Incorrect";
			slideNumber += 1;
		} else if (Input.GetKey (KeyCode.Mouse0) && slideNumber == 3) {
			text.text = "Seven a.m., waking up in the morning\n";
			text.text += "Press A to be fresh and go downstairs\n";
			text.text += "Press B to have your bowl and have cereal\n";
			text.text += "Press C to get down to the bus stop";
			slideNumber += 1;
		} else if (Input.GetKey (KeyCode.A) && slideNumber == 4) {
			SlideFour ();
		} else if (Input.GetKey (KeyCode.B) && slideNumber == 4) {
			SlideFour ();
		} else if (Input.GetKey (KeyCode.C) && slideNumber == 4) {
			SlideFour ();
		}

	}

	void SlideFour() {
		text.text = "Gotta catch my bus, I see my friends\n";
		text.text += "Kickin' in the front seat\n";
		text.text += "Sittin' in the back seat\n";
		text.text += "Gotta make my mind up\n";
		text.text += "Which seat do you take?\n";
		text.text += "Press D for Driver Seat\n";
		text.text += "Press S for Shotgun\n";
		text.text += "Press B for Backseat\n";
		slideNumber += 1;
	}
}
