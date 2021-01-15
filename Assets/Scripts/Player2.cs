using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private bool getDownW = false;
    private bool getDownS = false;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // For going UP
        if (Input.GetKey(KeyCode.UpArrow)) {
            getDownW = true;
        } 
        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            getDownW = false;
        }

        // For going DOWN
        if (Input.GetKey(KeyCode.DownArrow)) {
            getDownS = true;
        } 
        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            getDownS = false;
        }
        
        // If both buttons are pressed at the same time, dont prioritize, just return
        if (getDownS == true && getDownW == true) return;

        // Move the player's board
        if (getDownW == true) {transform.Translate(0, speed*Time.deltaTime, 0);}
        if (getDownS == true) {transform.Translate(0, -speed*Time.deltaTime, 0);}
        // transform.Translate(
        
    }
}
