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
        eventPanelController = GameObject.Find("Canvas").GetComponent<EventPanelController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown() 
    {
        eventPanelController.OpenEventPanel();
    }

    private void OnTouchDown() 
    {
    }
}
