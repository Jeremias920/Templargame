using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;
	public GUIStyle PlayGame;
	public GUIStyle Options;
	public GUIStyle Quit;

	void OnGUI(){
				//Display our BGTexture
				GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

				//Display buttons
				if (GUI.Button (new Rect (Screen.width * .40f, Screen.height * .5f, Screen.width * .2f, Screen.height * .1f), "", PlayGame)) {
			Application.LoadLevel("Testi");

				}

				if (GUI.Button (new Rect (Screen.width * .40f, Screen.height * .6f, Screen.width * .2f, Screen.height * .1f), "", Options)) {
			
			
				}
				if (GUI.Button (new Rect (Screen.width * .40f, Screen.height * .7f, Screen.width * .2f, Screen.height * .1f), "", Quit)) {
			Application.Quit();
			
				}
		}

}
