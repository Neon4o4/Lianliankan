﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace UGUIBase {
	public class GameObjectLink : MonoBehaviour {

		[SerializeField]
		public List<LinkObject> links = new List<LinkObject>();
		public Dictionary<string, GameObject> dLinks= new Dictionary<string, GameObject>();
		bool initialized = false;

		private void Initialize()
		{
			if (!initialized)
			{
				foreach (var link in links)
					dLinks[link.name] = link.go;
				initialized = true;
			}
		}

		public GameObject GetLinkGameObject(string key)
		{
			Initialize();
			GameObject go = null;
			dLinks.TryGetValue(key, out go);
			return go;
		}

		[Serializable]
		public class LinkObject
		{
            public LinkObject() { }
            public LinkObject(string _name, GameObject _go)
            {
                name = _name;
                go = _go;
            }
			public string name;
			public GameObject go;
		}
	}
}
