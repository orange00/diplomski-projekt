using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonToSlotScript : MonoBehaviour {
	public GameObject slots;
	public Button button;

	public int buttonOrder;

	public GameObject wrongAnswerAlert;

	public void moveToSlot() {
		slots.GetComponent<SlotsScript> ().MoveToSlot (button.gameObject);
		button.interactable = false;
	}

	public void moveToSlotOrdered() {
		//the right button at the right time
		if (slots.GetComponent<SlotsScript> ().FirstEmptyIndex () == buttonOrder) {
			moveToSlot ();
			this.GetComponent<MultipleTaskModalScript> ().NextTaskOrFinish ();
		} else {
			StartCoroutine ("ShowcaseWrongAnswerAlert");
		}
	}

	public IEnumerator ShowcaseWrongAnswerAlert ()
	{
		wrongAnswerAlert.SetActive (true);
		yield return new WaitForSeconds(1.2f);
		wrongAnswerAlert.SetActive (false);
	}
}
