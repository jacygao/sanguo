using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float distance = 10.0f;
    public float xSpeed = 250.0f;
    public float ySpeed = 120.0f;
    public float yMinLimit = -20.0f;
    public float yMaxLimit = 80.0f;
    public float distanceMin = 0.5f;
    public float distanceMax = 15f;
    public float smoothSpeed = 1f;

    private float x = 0.0f;
    private float y = 0.0f;

    private Quaternion targetRotation;
    private Vector2 touchStartPos;

    void Start()
    {
        // Set the initial camera rotation
        targetRotation = Quaternion.Euler(15f, 0f, 0f);
    }

    void LateUpdate()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                touchStartPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                Vector2 swipeDelta = touch.position - touchStartPos;

                // Rotate the camera around the target based on swipe delta
                transform.RotateAround(target.position, Vector3.up, swipeDelta.x * xSpeed * Time.deltaTime);

                // Update the touch start position for the next frame
                touchStartPos = touch.position;
            }
        }

        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // Only move the camera up and down the Y axis
            float yDirection = deltaMagnitudeDiff * 0.05f;
            float newY = Mathf.Clamp(transform.position.y + yDirection, 7f, 30f);

            // Update the camera position
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);

            // Calculate the direction from the camera to the target
            Vector3 directionToTarget = (target.position - transform.position).normalized;
            
            // Calculate the rotation to look at the target
            targetRotation  = Quaternion.LookRotation(directionToTarget, Vector3.up);

            // Limit the x rotation angle between 15 and 60 degrees
            Vector3 eulerRotation = targetRotation.eulerAngles;
            eulerRotation.x = Mathf.Clamp(eulerRotation.x, 15f, 60f);
            targetRotation = Quaternion.Euler(eulerRotation);

            transform.rotation = targetRotation;
        }
    }

    static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}
