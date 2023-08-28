using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspectRatioHandler : MonoBehaviour
{
    public Camera targetCamera;
    public float originalAspect = 1080f / 1920f; // Example: Original aspect ratio (width / height)
    public float targetAspect = (float)Screen.width / (float)Screen.height;

    private void Start()
    {
        if (targetCamera == null)
        {
            targetCamera = Camera.main;
        }

        AdjustCamera();
    }

    void AdjustCamera()
    {
        float currentAspect = (float)Screen.width / Screen.height;
        float aspectRatioFactor = targetAspect / originalAspect;

        float desiredFOV = CalculateDesiredFOV();

        targetCamera.fieldOfView = desiredFOV;

        float cameraDistance = Vector3.Distance(targetCamera.transform.position, transform.position);
        float newCameraDistance = cameraDistance * aspectRatioFactor;

        targetCamera.transform.position = transform.position - targetCamera.transform.forward * newCameraDistance;
    }

    float CalculateDesiredFOV()
    {
        // Calculate the desired FOV based on the original and target aspect ratios
        float originalFOV = targetCamera.fieldOfView;
        float calculatedFOV = originalFOV * (targetAspect / originalAspect);
        return calculatedFOV;
    }
}
