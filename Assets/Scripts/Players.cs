using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public GameObject PlayerOne;
    public GameObject PlayerTwo;
    private bool getDownW = false;
    private bool getDownS = false;
    private bool getDownUpArrow = false;
    private bool getDownDownArrow = false;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        // Nothing to do here (yet)
    }

    // Update is called once per frame
    void Update()
    {
        // Player 1
        movePlayerOne();

        // Player 2
        movePlayerTwo();

        // TODO: Create a "Move" function and make it dynamic
    }
    void movePlayerOne() {

        // UP
        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("GetDownW");
            getDownW = true;
        } 
        if (Input.GetKeyUp(KeyCode.W)) {
            Debug.Log("GetUpW");
            getDownW = false;
        }

        // DOWN
        if (Input.GetKey(KeyCode.S)) {
            Debug.Log("GetDownS");
            getDownS = true;
        } 
        if (Input.GetKeyUp(KeyCode.S)) {
            Debug.Log("GetUpS");
            getDownS = false;
        }
        // Move the board
        if (getDownS == true && getDownW == true) return;
        if (getDownW == true) {PlayerOne.transform.Translate(0, speed*Time.deltaTime, 0);}
        if (getDownS == true) {PlayerOne.transform.Translate(0, -speed*Time.deltaTime, 0);}
    }
    void movePlayerTwo() {
        // UP
        if (Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("GetDownW");
            getDownUpArrow = true;
        } 
        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            Debug.Log("GetUpW");
            getDownUpArrow = false;
        }

        // DOWN
        if (Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("GetDownS");
            getDownDownArrow = true;
        } 
        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            Debug.Log("GetUpS");
            getDownDownArrow = false;
        }
        // Move the board
        if (getDownUpArrow == true && getDownDownArrow == true) return;
        if (getDownUpArrow == true) {PlayerTwo.transform.Translate(0, speed*Time.deltaTime, 0);}
        if (getDownDownArrow == true) {PlayerTwo.transform.Translate(0, -speed*Time.deltaTime, 0);}
    }

}
