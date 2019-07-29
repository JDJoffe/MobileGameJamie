using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float movementSped = 15f;
    public Joystick joystick;
    public GameObject sphere;
    public Vector2 vecc;
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        vecc = new Vector2(joystick.Horizontal,  joystick.Vertical);
        vecc = transform.TransformDirection(vecc);
        vecc *= movementSped;

        characterController.Move(vecc * Time.deltaTime);

    }
   

    
    
}
