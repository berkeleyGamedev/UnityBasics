using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour
{
    private Camera cam;

    private void Awake() {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    private void Update() {
        Vector2 viewportPosition = cam.WorldToViewportPoint(transform.position);
        Vector2 newPosition = transform.position;

        if (viewportPosition.x > 1 || viewportPosition.x < 0) {
            newPosition.x = -newPosition.x;
        }

        if (viewportPosition.y > 1 || viewportPosition.y < 0) {
            newPosition.y = -newPosition.y;
        }

        transform.position = newPosition;
    }
}
