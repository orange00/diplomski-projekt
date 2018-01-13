using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	public void SceneChange(string sceneName) {
        if (sceneName == "MainMenu") {
            Destroy(GameObject.Find("CharacterSelected"));
        }
        SceneManager.LoadScene(sceneName);
    }
}
