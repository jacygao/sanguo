using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Utilities;

public class PlayerCoordinate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Convert the position to latitude and longitude using Mapbox's API
        // Vector2d objectCoordinates = Conversions.Vector3ToLatLon(transform.position);

        // // Access the latitude and longitude values
        // double latitude = objectCoordinates.x;
        // double longitude = objectCoordinates.y;

        // // Print the coordinates
        // Debug.Log("Object Latitude: " + latitude);
        // Debug.Log("Object Longitude: " + longitude);
    }
}
