using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour {

	int steps = 0;
	Vector2 homeLocation = new Vector2 (2, 3);
	Vector2 playerLocation = new Vector2 (5, 1.0f);
	bool gameOver = false;

	// Use this for initialization
	void Start () {
		PrintWelcomeMessage();
	}

	void PrintWelcomeMessage() {
		print ("Welcome to the game: Go home... or die out there!");
	}

	void UpdateStatus() {
		steps++;
		if (homeLocation == playerLocation) {
			gameOver = true;
			print ("Congratulations, you made it home in " + steps + " steps.");
		} else {
			Vector2 distance = homeLocation - playerLocation;
			print ("After " + steps + " steps, you are " + distance.magnitude + " feet away from home.");
		}
	}

	// Update is called once per frame
	void Update () {

		/* or do: if (gameOver) { returns;} and the rest of the code after the returns statement */

		if (!gameOver){
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				playerLocation += Vector2.up;
				UpdateStatus();
			} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
				playerLocation += Vector2.down;
				UpdateStatus();
			} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				playerLocation += Vector2.left;
				UpdateStatus();
			} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
				playerLocation += Vector2.right;
				UpdateStatus();
			}
		}

	}
}
