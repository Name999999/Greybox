using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float translation;
    private float straife;

    public bool controlActive;

    // Use this for initialization
    void Start()
    {
        controlActive = true;
        // turn off the cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxis() is used to get the user's input
        // You can furthor set it on Unity. (Edit, Project Settings, Input)

        if (controlActive)
        {
            translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            straife = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Translate(straife, 0, translation);
        }


        if (Input.GetKeyDown("escape"))
        {
            // turn on the cursor
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
