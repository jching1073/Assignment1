using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float smoothTime = 0.3f;
    [SerializeField] private float posY;

    [SerializeField] private float minX;
    [SerializeField] private float maxX;

    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    private Vector3 veloccity = Vector3.zero;

    void Update()
    {
        Vector3 targetPosition = player.TransformPoint(new Vector3(0, posY, -10));
        Vector3 desiredPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref veloccity, smoothTime);

        transform.position = new Vector3 (Mathf.Clamp(desiredPosition.x, minX,maxX), Mathf.Clamp(desiredPosition.y, minY, maxY), desiredPosition.z);
    }
}
