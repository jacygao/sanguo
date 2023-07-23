using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mapbox.Utils;

public class EventPanelController : MonoBehaviour
{
    private Vector2d focus;

    public GameObject eventPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenEventPanel() {
        bool isOpen = eventPanel.activeSelf;
        eventPanel.SetActive(!isOpen);
    }

    public void CloseEventPanel() {
        eventPanel.SetActive(false);
    }
}
