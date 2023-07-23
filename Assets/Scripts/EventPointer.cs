using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Utils;

public class EventPointer : MonoBehaviour
{
    public Vector2d EventLocation;

    EventPanelController eventPanelController;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Event Pointed initiated");
        eventPanelController = GameObject.Find("Canvas").GetComponent<EventPanelController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown() 
    {
        Debug.Log("Clicked on PC. location: " + EventLocation);
        eventPanelController.OpenEventPanel();
    }

    private void OnTouchDown() 
    {
        Debug.Log("Tapped on mobile");
    }
}
