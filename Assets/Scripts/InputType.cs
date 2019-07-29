using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputType : MonoBehaviour
{
    public GameObject sphere;
    public RaycastHit hit;

    Vector3 prevPos;
   
    // Start is called before the first frame update
    void OnTouchDown()
    {
        Debug.Log("Down");
       
       
    }

    // Update is called once per frame
    void OnTouchStay(Vector3 pos)
    {
        sphere.GetComponent<Rigidbody>().useGravity = false;
        sphere.transform.position = pos;
        prevPos = pos;
    }

    void OnTouchUp(Vector3 pos)
    {
        Debug.Log("SADDAd");
        sphere.GetComponent<Rigidbody>().useGravity = true;
        sphere.GetComponent<Rigidbody>().velocity = sphere.transform.position - pos;
    }

    void OnTouchExit()
    {
        Debug.Log("Exit");
    }
}
