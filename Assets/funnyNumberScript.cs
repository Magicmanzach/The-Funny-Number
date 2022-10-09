using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;

public class funnyNumberScript : MonoBehaviour 
{
	public KMAudio Audio;

	public KMSelectable button1;
	public KMSelectable button2;
	public KMSelectable button3;
	public KMSelectable button4;
	public KMSelectable button5;
	public KMSelectable button6;
	public KMSelectable button7;
	public KMSelectable button8;
	public KMSelectable button9;
	public KMSelectable button0;
	public KMSelectable buttonNegative;
	public KMSelectable buttonSubmit;
	public KMSelectable buttonCancel;
	public TextMesh randoTxt;
	public TextMesh inputTxt;

	private Dictionary<char, KMSelectable> TwitchSelectables;

	//Logging
	static int moduleIdCounter = 1;
	int moduleId;
	private bool moduleSolved;

	private int input;
	private int answer;
	private int rando;
	private bool negative;
	private bool displayZero;

	void Awake()
	{
		moduleId = moduleIdCounter++;
		button1.OnInteract += delegate () { PressButton1(); return false; };
		button2.OnInteract += delegate () { PressButton2(); return false; };
		button3.OnInteract += delegate () { PressButton3(); return false; };
		button4.OnInteract += delegate () { PressButton4(); return false; };
		button5.OnInteract += delegate () { PressButton5(); return false; };
		button6.OnInteract += delegate () { PressButton6(); return false; };
		button7.OnInteract += delegate () { PressButton7(); return false; };
		button8.OnInteract += delegate () { PressButton8(); return false; };
		button9.OnInteract += delegate () { PressButton9(); return false; };
		button0.OnInteract += delegate () { PressButton0(); return false; };
		buttonNegative.OnInteract += delegate () { PressButtonNegative(); return false; };
		buttonSubmit.OnInteract += delegate () { PressButtonSubmit(); return false; };
		buttonCancel.OnInteract += delegate () { PressButtonCancel(); return false; };
		TwitchSelectables = new Dictionary<char, KMSelectable>
		{
			{ '-', buttonNegative },
			{ '0', button0 },
			{ '1', button1 },
			{ '2', button2 },
			{ '3', button3 },
			{ '4', button4 },
			{ '5', button5 },
			{ '6', button6 },
			{ '7', button7 },
			{ '8', button8 },
			{ '9', button9 }
		};
		Debug.Log(moduleId);
	}

	void Start () 
	{
		rando = UnityEngine.Random.Range(0, 100);
		randoTxt.text = rando.ToString();
		inputTxt.text = "";
		answer = 69 - rando;
		input = 0;
	}

	void PressButton1()
	{
		Debug.Log("1 Pressed!");
		button1.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if(moduleSolved == false)
		{
			if (input < 10)
			{
				input *= 10;
				input += 1;
			}
			DisplayInput();
		}
	}

	void PressButton2()
	{
		Debug.Log("2 Pressed!");
		button2.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved == false)
		{
			if (input < 10)
			{
				input *= 10;
				input += 2;
			}
			DisplayInput();
		}
	}

	void PressButton3()
	{
		Debug.Log("3 Pressed!");
		button3.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved == false)
		{
			if (input < 10)
			{
				input *= 10;
				input += 3;
			}
			DisplayInput();
		}
	}

	void PressButton4()
	{
		Debug.Log("4 Pressed!");
		button4.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved == false)
		{
			if (input < 10)
			{
				input *= 10;
				input += 4;
			}
			DisplayInput();
		}
	}

	void PressButton5()
	{
		Debug.Log("5 Pressed!");
		button5.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved == false)
		{
			if (input < 10)
			{
				input *= 10;
				input += 5;
			}
			DisplayInput();
		}
	}

	void PressButton6()
	{
		Debug.Log("6 Pressed!");
		button6.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved == false)
		{
			if (input < 10)
			{
				input *= 10;
				input += 6;
			}
			DisplayInput();
		}
	}

	void PressButton7()
	{
		Debug.Log("7 Pressed!");
		button7.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved == false)
		{
			if (input < 10)
			{
				input *= 10;
				input += 7;
			}
			DisplayInput();
		}
	}

	void PressButton8()
	{
		Debug.Log("8 Pressed!");
		button8.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved == false)
		{
			if (input < 10)
			{
				input *= 10;
				input += 8;
			}
			DisplayInput();
		}
	}

	void PressButton9()
	{
		Debug.Log("9 Pressed!");
		button9.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved == false)
		{
			if (input < 10)
			{
				input *= 10;
				input += 9;
			}
			DisplayInput();
		}
	}

	void PressButton0()
	{
		Debug.Log("0 Pressed!");
		button0.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved == false)
		{
			if (input < 10)
			{
				input *= 10;
				displayZero = true;
			}
			DisplayInput();
		}
	}

	void PressButtonNegative()
	{
		Debug.Log("- Pressed!");
		buttonNegative.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved == false)
		{
			if (negative == true)
			{
				negative = false;
			}
			else
			{
				negative = true;
			}
			DisplayInput();
		}
	}

	void PressButtonSubmit()
	{
		Debug.Log("Submit Pressed!");
		buttonSubmit.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (negative == true)
		{
			input *= -1;
		}
		if(input == answer)
		{
			moduleSolved = true;
			Debug.Log("Solved!");
			GetComponent<KMBombModule>().HandlePass();
			inputTxt.text = "Nice";
			randoTxt.text = "69";
		}
		else if(moduleSolved == false)
		{
			input = 0;
			Debug.Log("Strike!");
			GetComponent<KMBombModule>().HandleStrike();
			displayZero = false;
			DisplayInput();
		}
	}

	void PressButtonCancel()
	{
		Debug.Log("Cancel Pressed!");
		buttonCancel.AddInteractionPunch(.5f);
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved == false)
		{
			input = 0;
			negative = false;
			displayZero = false;
			DisplayInput();
		}
	}

	void DisplayInput()
	{
		if(negative == true)
		{
			if(input == 0 && displayZero == false)
			{
				inputTxt.text = "-";
			}
			else
			{
				inputTxt.text = "-" + input.ToString();
			}
		}
		else
		{
			if(input == 0 && displayZero == false)
			{
				inputTxt.text = "";
			}
			else
			{
				inputTxt.text = input.ToString();
			}
		}
	}

	#pragma warning disable 414
	private readonly string TwitchHelpMessage = "Submit a number with '!{0} submit [number]'. Leave [number] blank to just press the submit button.";
	#pragma warning restore 414
	
	IEnumerator ProcessTwitchCommand(string command)
	{
		var match = Regex.Match(command.Trim(), @"^submit( (-?\d+))?$", RegexOptions.IgnoreCase);
		if (!match.Success)
			yield break;
		yield return null;
		yield return match.Groups[2].Value.Select(c => TwitchSelectables[c]).ToArray();
		buttonSubmit.OnInteract();
	}

	IEnumerator HandleForcedSolve()
	{
		var handler = ProcessTwitchCommand("submit " + answer);
		while (handler.MoveNext())
		{
			var current = handler.Current as KMSelectable[];
			if (current == null) 
				yield return null;
			else foreach (var selectable in current)
			{
				yield return null;
				selectable.OnInteract();
				yield return new WaitForSeconds(.1f);
			}
		}
	}

	void TwitchHandleForcedSolve()
	{
		StartCoroutine(HandleForcedSolve());
	}
}
