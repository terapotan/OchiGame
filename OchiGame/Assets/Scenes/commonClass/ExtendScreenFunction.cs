using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace common
{
    public class ExtendScreenFunction
    {
        private Camera mainCamera;
        public ExtendScreenFunction()
        {
            mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        }

        public float GetScreenBottom()
        {
            Vector3 bottomRight = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));
            bottomRight.Scale(new Vector3(1f, -1f, 1f));
            return bottomRight.y;
        }

    }

}
