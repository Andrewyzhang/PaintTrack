using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallBackground : MonoBehaviour
{
    [SerializeField] private Vector2 EffectMultiplier;
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        transform.position += new Vector3(deltaMovement.x * EffectMultiplier.x,
            deltaMovement.y * EffectMultiplier.y);
        lastCameraPosition = cameraTransform.position;
    }

}
