using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputType : MonoBehaviour
{
    public GameObject sphere;
    public RaycastHit hit;
    public float swipeDistance;
    Vector3 prevPos;

    private void LateUpdate()
    {
      //  prevPos = Input.GetTouch(0).deltaPosition / Time.deltaTime;
    }
    // Start is called before the first frame update
    void OnTouchDown(Vector3 pos)
    {
        Debug.Log("Down");


    }

    // Update is called once per frame
    void OnTouchStay(Vector3 pos)
    {
        Debug.Log("Stay");
        sphere.transform.position = pos;
        //prevPos = pos;



        sphere.GetComponent<Rigidbody>().velocity = prevPos;

       
    }

    void OnTouchUp(Vector3 pos)
    {
        Debug.Log("SADDAd");

        sphere.GetComponent<Rigidbody>().velocity = prevPos;
    }

    void OnTouchExit()
    {
        Debug.Log("Exit");
    }



}
