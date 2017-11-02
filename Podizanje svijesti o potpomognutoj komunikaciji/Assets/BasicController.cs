using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour {

    public GameObject character;
    public float speed = 3.0f;
    public Camera mainCamera;
    private float offset;

    private void Start() {
        offset = mainCamera.transform.position.z - character.transform.position.z;
        mainCamera.transform.position = new Vector3(character.transform.position.x, character.transform.position.y, offset);
    }

    // Update is called once per frame
    void Update () {
        MoveCharacter();
    }

    private void LateUpdate() {
        mainCamera.transform.position = new Vector3(character.transform.position.x, character.transform.position.y, offset);
    }

    void MoveCharacter() {

        if (Input.GetKey(KeyCode.UpArrow)) {
            character.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            character.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            character.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            character.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        
    }
}
