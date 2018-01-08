using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelected : MonoBehaviour {

    public string characterName;

    private static CharacterSelected instance = null;
    public static CharacterSelected Instance {
        get { return Instance; }
    }

    private void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void CharacterSelection(string name) {
        characterName = name;
        SceneManager.LoadScene("Scene1");
    }
}
