using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform heroTransform; // Reference to the HeroKnight transform
    public float smoothSpeed = 0.125f; // Smoothing speed for the camera to follow
    public Vector3 offset; // Offset from the hero position
    public bool followYAxis = true; // Should the camera follow the hero on the Y axis?

    private Vector3 currentVelocity;

    private void LateUpdate()
    {
        Vector3 targetPosition = heroTransform.position + offset;
        // If we don't want to follow on the Y axis, we keep the camera's current y position.
        if (!followYAxis)
        {
            targetPosition.y = transform.position.y;
        }

        Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothSpeed);
        transform.position = smoothPosition;
    }
}
