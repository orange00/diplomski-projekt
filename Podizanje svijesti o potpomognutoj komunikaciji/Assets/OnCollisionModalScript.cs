using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionModalScript : MonoBehaviour {

	public GameObject modalPanelObject;
	public GameObject taskSolvedMark;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (!taskSolvedMark.activeSelf) {
			modalPanelObject.SetActive (true);
		}
	}

	void OnCollisionExit2D(Collision2D collision)
	{
		modalPanelObject.SetActive (false);
	}
}
