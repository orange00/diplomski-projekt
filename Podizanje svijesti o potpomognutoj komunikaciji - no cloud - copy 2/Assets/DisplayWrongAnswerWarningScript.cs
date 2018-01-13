using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayWrongAnswerWarningScript : MonoBehaviour {
	public GameObject wrongAnswerWarning;

	public void ShowWrongAnswerWarning() {
		wrongAnswerWarning.SetActive (true);
	}
}
