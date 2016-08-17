using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	float playerScore = 0;

	public GUIStyle guistyle = new GUIStyle();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		playerScore += Time.deltaTime;
	
	}

	public void IncreaseScore(int amount){

		playerScore += amount;

	}

	void OnDisable(){

		PlayerPrefs.SetInt("Score", (int)playerScore);
	}

	void OnGUI(){

		guistyle.normal.textColor = Color.yellow;
		guistyle.fontSize = 25;
		GUI.Label(new Rect(700, 20, 300, 90), "Score: " + (int)(playerScore * 100), guistyle);
	}


}
