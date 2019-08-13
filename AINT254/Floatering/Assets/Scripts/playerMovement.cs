using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{

    new Rigidbody rigidbody;

    public int score;
    public int updatedScore;
    public bool enter = true;
    public bool win = true;
    public float movementSpeed = 1.0f;
    public float floating = 0.2f;
    public float gravity = 10f;

    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody>();

    }
    

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        Vector3 movement1 = rigidbody.transform.rotation * Vector3.forward;

        

        rigidbody.AddForce(movement * movementSpeed);
       // transform.position += transform.forward * Time.deltaTime * movementSpeed;
        if (Input.GetButton("Jump"))
        {
            rigidbody.AddForce(transform.up * floating);
        }

        if (Input.GetButton("Sink"))
        {
            rigidbody.AddForce(transform.up * -floating);
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "walls")
        {
            SceneManager.LoadScene("loseScreen");
        }

        if(other.gameObject.tag == "greenWall")
        {
            SceneManager.LoadScene("winScreen");
        }
    }

    
}
