using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour {

    private Transform characterTransform;
    private Rigidbody2D charRigidbody;
    public float speed = 3f;
    public Camera mainCamera;
    private float offset;
    private SpriteRenderer spriteRenderer;
    private Animator characterAnimator;
    private float moveX, moveY;

    // True -> right, False -> left
    private bool checkDirection = true;

    private void Start() {
        charRigidbody = GetComponent<Rigidbody2D>();
        characterTransform = GetComponent<Transform>();
        offset = mainCamera.transform.position.z - characterTransform.position.z;
        //mainCamera.transform.position = new Vector3(character.transform.position.x, character.transform.position.y, offset);
        spriteRenderer = GetComponent<SpriteRenderer>();
        characterAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {

        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        if (moveX == 0 && moveY == 0) {

            //characterAnimator.Play("IdleStand");
            characterAnimator.SetBool("isMoving", false);
        }

        if (moveX != 0) {
            characterAnimator.SetBool("isMoving", true);
        }
        if (moveY != 0) {
            characterAnimator.SetBool("isMoving", true);
        }
    }

    //private void LateUpdate() {
        
    //    mainCamera.transform.position = new Vector3(character.transform.position.x, character.transform.position.y, offset);
    //}

    private void FixedUpdate() {
        MoveCharacter();
    }

    void MoveCharacter() {
        

        if (moveX != 0) {
            CheckDirection(moveX);
            characterTransform.position += new Vector3(moveX * speed * Time.deltaTime, 0, 0);
            //characterAnimator.SetBool("isMoving", true);
        }
        if (moveY != 0) {
            characterTransform.position += new Vector3(0, moveY * speed * Time.deltaTime, 0);
            //characterAnimator.SetBool("isMoving", true);
        }      
    }

    void CheckDirection(float moveValue) {
        if(moveValue < 0.0f) {
            spriteRenderer.flipX = true;
            checkDirection = false;
        } else {
            spriteRenderer.flipX = false;
            checkDirection = true;
        }
    }
}
