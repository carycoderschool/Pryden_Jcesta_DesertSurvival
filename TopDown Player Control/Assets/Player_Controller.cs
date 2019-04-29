using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    //Inspector Variables
    float playerSpeed = 10.0F; //speed player moves
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveForward(); // Player Movement 
       
    }

    void MoveForward()
    {
        if (Input.GetKey("w"))//Press w key to move forward on the Y AXIS
        {
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey("s"))//Press s key to move downward on the Y AXIS
        {
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey("a"))//Press a to move forward on the Y AXIS
        {
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("d"))//Press d key to move forward on the Y AXIS
        {
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
        }

    }
      
}
