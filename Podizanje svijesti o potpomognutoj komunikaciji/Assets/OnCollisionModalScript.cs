using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionModalScript : MonoBehaviour {

	public GameObject modalPanelObject;
	public GameObject correctAnswerMark;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (!correctAnswerMark.activeSelf) {
			modalPanelObject.SetActive (true);
		}
	}

	void OnCollisionExit2D(Collision2D collision)
	{
		modalPanelObject.SetActive (false);
	}
}
