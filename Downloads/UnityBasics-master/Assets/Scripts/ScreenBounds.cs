using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour
{
    private Camera cam;
    private float wrapMargin = 5f;

    private void Awake() {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    private void Update() {
        Vector2 screenPosition = cam.WorldToScreenPoint(transform.position);

        if(screenPosition.x < 0)
        {
            screenPosition.x = Screen.width - wrapMargin;
        }

        if(screenPosition.x > Screen.width)
        {
            screenPosition.x = wrapMargin;
        }

        if (screenPosition.y < 0)
        {
            screenPosition.y = Screen.height - wrapMargin;
        }

        if (screenPosition.y > Screen.height)
        {
            screenPosition.y = wrapMargin;
        }

        transform.position = (Vector2) cam.ScreenToWorldPoint(screenPosition);
    }
}
