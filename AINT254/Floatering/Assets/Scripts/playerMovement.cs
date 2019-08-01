using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    CharacterController characterController;

    public int score;
    public int updatedScore;

    public float movementSpeed = 6.0f;
    public float floating = 0.5f;
    public float gravity = 10f;

   

    private Vector3 directionalMovement = Vector3.zero;

    
    // Start is called before the first frame update
    void Start()
    {

        score = 10;

        float moveUP = floating + 5.0f;

        characterController = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {

        float moveUP = floating + 5.0f;

        if (characterController.isGrounded)
        {
            score = (score - 1);
        }

        if (Input.GetButton("Jump") == true)
        {
            directionalMovement.y = moveUP;
        }

        directionalMovement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

       // directionalMovement.y -= gravity * Time.deltaTime;

        characterController.Move(directionalMovement * Time.deltaTime);
        


    }

    void FixedUpdate()
    {
        
    }
}
