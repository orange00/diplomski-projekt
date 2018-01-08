using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotsScript : MonoBehaviour {
	public List<GameObject> slots;

	public GameObject FirstEmpty ()
	{
		foreach(GameObject slot in slots) {
			if (slot.activeSelf) {
				return slot;
			}
		}

		return null;
	}

	public bool IsFull ()
	{
		return FirstEmpty () == null;
	}

	public void MoveToSlot (GameObject gameObject)
	{
		GameObject firstEmptySlot = FirstEmpty ();
		gameObject.transform.position = firstEmptySlot.transform.position;
		firstEmptySlot.SetActive (false);
	}

	public int FirstEmptyIndex ()
	{
		GameObject firstEmpty = FirstEmpty ();

		if (firstEmpty == null) {
			return -1;
		} else {
			return slots.IndexOf (firstEmpty);
		}
	}
}
