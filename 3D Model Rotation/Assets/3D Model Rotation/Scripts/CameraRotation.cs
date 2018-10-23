﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float cameraSpeed;

    // Update is called once per frame
    void Update ()
    {
        transform.Rotate(0, cameraSpeed * Time.deltaTime, 0);
	}
}
