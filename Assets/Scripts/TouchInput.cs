using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    public LayerMask touchMask;
    private List<GameObject> touchList = new List<GameObject>();
    private GameObject[] oldTouch;
    private RaycastHit hit;

    private void Update()
    {
        #region Debugstuff


        #region foreditor
        //if in unity editor use mouse
        if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0))
        {
            oldTouch = new GameObject[touchList.Count];
            touchList.CopyTo(oldTouch);
            touchList.Clear();

            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, touchMask))
            {
                GameObject recipient = hit.transform.gameObject;
                touchList.Add(recipient);

                // send a debug message to let ya know mouse is "touching" in game test
                if (Input.GetMouseButtonDown(0))
                {
                    recipient.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
                    Debug.Log("OnTouchDown");
                }
                if (Input.GetMouseButton(0))
                {
                    recipient.SendMessage("OnTouchStay", hit.point, SendMessageOptions.DontRequireReceiver);
                    Debug.Log("OnTouchStay");
                }
                if (Input.GetMouseButtonUp(0))
                {
                    recipient.SendMessage("OnTouchUp", hit.point, SendMessageOptions.DontRequireReceiver);
                    Debug.Log("OnTouchUp");
                }
            }
            foreach (GameObject item in oldTouch)
            {
                if (!touchList.Contains(item))
                {                                    
                        item.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
                        Debug.Log("OnTouchExit");                   
                }
            }
        }
        #endregion
        //else use touch
        #region forphone
        if (Input.touchCount > 0)
        {
            oldTouch = new GameObject[touchList.Count];
            touchList.CopyTo(oldTouch);
            touchList.Clear();

            foreach (Touch touch in Input.touches)
            {
                Ray ray = GetComponent<Camera>().ScreenPointToRay(touch.position);

                if (Physics.Raycast(ray, out hit, touchMask))
                {
                    GameObject recipient = hit.transform.gameObject;
                    touchList.Add(recipient);

                    if (touch.phase == TouchPhase.Began)
                    {
                        recipient.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
                        Debug.Log("OnTouchDown");
                    }
                    if (touch.phase == TouchPhase.Ended)
                    {
                        recipient.SendMessage("OnTouchUp", hit.point, SendMessageOptions.DontRequireReceiver);
                        Debug.Log("OnTouchUp");
                    }
                    if (touch.phase == TouchPhase.Stationary)
                    {
                        recipient.SendMessage("OnTouchStay", hit.point, SendMessageOptions.DontRequireReceiver);
                        Debug.Log("OnTouchStay");
                    }
                    if (touch.phase == TouchPhase.Canceled)
                    {
                        recipient.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
                        Debug.Log("OnTouchExit");
                    }
                }
            }
            foreach (GameObject item in oldTouch)
            {
                if (!touchList.Contains(item))
                {
                    item.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
                    Debug.Log("OnTouchExit");
                }
            }
        }
        #endregion
        #endregion
    }


}
