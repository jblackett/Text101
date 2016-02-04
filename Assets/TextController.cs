using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, sheets_1, lock_1, cell_mirror, freedom};
	private States myState;
	private string keyPress;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		GetKeyPress();
		
		switch (myState)
		{
			case States.cell:
				State_Cell();
				switch (keyPress)
				{
					case "S":
					myState = States.sheets_0;
					return;
				}
				break;
				
			case States.sheets_0:
				State_Sheets_0();
				break;
		}
		
	}
	
	void State_Cell() {
		text.text = "You are in a prison cell. There are sheets on the bed, " +
			"a mirror on the wall, and the door is locked from the outside.\n\n" +
				"Press S to inspect the sheets, M to look at the mirror, and L to look at the lock.";
	}
	
	void State_Sheets_0()
	{
		GetKeyPress();
		
		text.text = "You have a sheet.";
		
		if (keyPress == "R")
		{
			myState = States.cell;
		}
	}
	
	void GetKeyPress() 
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			keyPress = "S";
		}
		
		if (Input.GetKeyDown(KeyCode.S))
		{
			keyPress = "R";
		}
		
	}
}
