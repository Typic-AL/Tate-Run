using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVAdjustment : MonoBehaviour
{
    public Camera targetCamera;
    public float originalAspect = 16f / 9f; // Example: Original aspect ratio (width / height)
    public float targetAspect = 9f / 5f;   // Example: Target aspect ratio (width / height)

    private void Start()
    {
        AdjustFOV();
    }

    void AdjustFOV()
    {
        float originalFOV = targetCamera.fieldOfView;

        // Calculate the angle needed to adjust FOV
        float angle = Mathf.Rad2Deg * Mathf.Atan(Mathf.Tan(Mathf.Deg2Rad * originalFOV / 2f) * originalAspect / targetAspect) * 2f;

        targetCamera.fieldOfView = angle;
    }


}
