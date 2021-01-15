using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
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
        Debug.Log(Input.GetKey(KeyCode.W));
        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("GetDownW");
            getDownW = true;
        } 
        if (Input.GetKeyUp(KeyCode.W)) {
            Debug.Log("GetUpW");
            getDownW = false;
        }

        // For going DOWN
        if (Input.GetKey(KeyCode.S)) {
            Debug.Log("GetDownS");
            getDownS = true;
        } 
        if (Input.GetKeyUp(KeyCode.S)) {
            Debug.Log("GetUpS");
            getDownS = false;
        }
        // Move the player board
        Debug.Log("Test1");
        if (getDownS == true && getDownW == true) return;
        Debug.Log("Test2");
        if (getDownW == true) {transform.Translate(0, speed*Time.deltaTime, 0);}
        if (getDownS == true) {transform.Translate(0, -speed*Time.deltaTime, 0);}
        // transform.Translate(
        
    }
}
