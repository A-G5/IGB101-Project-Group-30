using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementAG : MonoBehaviour{

    public Animator anim;

    public float rotSpeed = 10;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

        ForwardMovement();

        Turning();

        Actions();

    }

    private void ForwardMovement(){
        if(Input.GetKey("w")){
            anim.SetBool("Walking", true);
            if (Input.GetKey(KeyCode.LeftShift)){
                anim.SetBool("Running", true);
            } else{
                anim.SetBool("Running", false);
            }
        } else if (Input.GetKeyUp("w")) {
            anim.SetBool("Walking", false);
            anim.SetBool("Running", false);
        }
    }

    private void Turning(){
        if (Input.GetKey("a")) {
            transform.Rotate(0, -rotSpeed * 15 * Time.deltaTime, 0, Space.World);
            anim.SetBool("Turn Left", true);
        } else if (Input.GetKey("d")) {
            transform.Rotate(0, rotSpeed * 15 * Time.deltaTime, 0, Space.World);
            anim.SetBool("Turn Right", true);
        } else {
            anim.SetBool("Turn Left", false);
            anim.SetBool("Turn Right", false);
        }
    }

    private void Actions(){
        if(Input.GetKeyDown("e")){
            anim.SetBool("Waving", true);
        } else if(Input.GetKeyUp("e")){
            anim.SetBool("Waving", false);
        }
	
	if(Input.GetKeyDown("1")){
            anim.SetBool("Dancing", true);
        } else if(Input.GetKeyUp("1")){
            anim.SetBool("Dancing", false);
        }
	
	if(Input.GetKeyDown("2")){
            anim.SetBool("ChickDance", true);
        } else if(Input.GetKeyUp("2")){
            anim.SetBool("ChickDance", false);
        }

    if(Input.GetKeyDown("3")){
            anim.SetBool("WaveDance", true);
        } else if(Input.GetKeyUp("3")){
            anim.SetBool("WaveDance", false);
        }

    if(Input.GetKeyDown("4")){
            anim.SetBool("SwingDance", true);
        } else if(Input.GetKeyUp("4")){
            anim.SetBool("SwingDance", false);
        }
    }
}
