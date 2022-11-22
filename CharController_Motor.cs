using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharController_Motor : MonoBehaviour {

	public float speed = 5.0f;
    public float run= 20.0f;
	public float sensitivity = 50f;
	public float WaterHeight = 15.5f;
	CharacterController character;
	public GameObject cam;
	float moveFB, moveLR,runFB,runLR;
	float rotX, rotY;
	public bool webGLRightClickRotation = true;
	float gravity = -9.8f;
	public float jump=300;
	public GameObject foco;
	Vector3 move = Vector3.zero;
	private bool isfocoactive = true;
	float stamina = 0f;
	float NumeroStamina;
	public Slider slider;

	public GameObject player;
    Vector3 List1;


    void Start(){
		
		//LockCursor ();
		character = GetComponent<CharacterController> ();
		if (Application.isEditor) {
			webGLRightClickRotation = false;
			sensitivity = sensitivity * 1.5f;
		}
		Cursor.lockState = CursorLockMode.Locked;

		NumeroStamina = run;
		
	}


	void CheckForWaterHeight(){
		if (transform.position.y < WaterHeight) {
			gravity = 0f;			
		} else {
			gravity = -9.8f;
		}
	}



	void Update(){
		

		

		rotX = Input.GetAxis ("Mouse X") * sensitivity;
		rotY = Input.GetAxis ("Mouse Y") * sensitivity;

		

        //rotX = Input.GetKey (KeyCode.Joystick1Button4);
        //rotY = Input.GetKey (KeyCode.Joystick1Button5);

        CheckForWaterHeight ();

		if (character.isGrounded)
		{

			print("simon");

			if (Input.GetButton("Jump"))
				move.y = Mathf.Sqrt(jump * -2f * gravity);
		}
        else
        {
			print("vuela el perro");
        }
		move.y += gravity * Time.deltaTime;
		Vector3 movement;

        if (Input.GetButton("Run"))
        {
            moveFB = Input.GetAxis("Horizontal") * run;
            moveLR = Input.GetAxis("Vertical") * run;
			if(stamina>= 0)
			{
				stamina+= 5f * Time.deltaTime;
			}

			
			
           
        }
        else
        {
            moveFB = Input.GetAxis("Horizontal") * speed; 
            moveLR = Input.GetAxis("Vertical") * speed;
            if (stamina > 0f)
            {
                stamina -= 2f * Time.deltaTime;
            }

        }
		print("stamina "+stamina);
        if (stamina >= 50f)
        {
			player.GetComponent<AudioSource>().enabled = true;
        }
        else
        {
            if (stamina < 50f)
            {
                player.GetComponent<AudioSource>().enabled = false;
            }
        }
        slider.value = stamina;

		movement = new(moveFB, gravity, moveLR);


        CameraRotation(cam, rotX, rotY);

        movement = transform.rotation * movement;
		character.Move (movement * Time.deltaTime);


	}
	private void FixedUpdate()
    {
        if (Input.GetButton("Light"))
        {
            if (isfocoactive == true)
            {
                foco.SetActive(false);
                isfocoactive = false;
            }
            else
            {
                foco.SetActive(true);
                isfocoactive = true;
            }
        }

    }


	void CameraRotation(GameObject cam, float rotX, float rotY){
		
		transform.Rotate (0, rotX * Time.deltaTime, 0);
		//cam.transform.Rotate (-rotY * Time.deltaTime, 0, 0);
		cam.transform.localEulerAngles = List1;
		List1.x -= rotY* Time.deltaTime;
		if(List1.x >= 80)
		{
			List1.x = 80;
		}else if(List1.x <= -80)
		{
			List1.x = -80;
		}


	}

	public void PlayerJump()
    {
		/*if(character.isGrounded)
        {
			
			if(Input.GetButtonDown("Jump"))
			move.y = Mathf.Sqrt(jump * -2f * gravity);
        }
		move.y += gravity * Time.deltaTime;
		character.Move (move* Time.deltaTime);*/
    }
    
    }
