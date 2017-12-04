using UnityEngine;
using System.Collections;

public class BringToFront : MonoBehaviour {

	/**
	 * Sets object on top of all other objects, 
	 * as soon as it is enabled.
	 * */
	void OnEnable () {
		transform.SetAsLastSibling ();
	}
}
