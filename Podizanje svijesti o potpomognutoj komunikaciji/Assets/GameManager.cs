using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Sprite soundOff, soundOn;

	public void ChangeScene(string name) {
		SceneManager.LoadScene(name);
	}

    public void ChangeVolume(bool enableVolume) {
        if (!enableVolume) {

        } else {

        }
    }
}
