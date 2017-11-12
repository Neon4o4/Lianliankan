﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManager
{
    public class UICanvasManager
    {
        public static UICanvasManager Instance = null;

        public GameObject UICanvas = null;
        public Transform UICanvasRectTransform = null;

        public UICanvasManager()
        {
            UICanvas = ResourceManager.CreatePersistGameObejct("StartRes/UICanvas");
            UICanvasRectTransform = UICanvas.transform;
        }
    }
}
