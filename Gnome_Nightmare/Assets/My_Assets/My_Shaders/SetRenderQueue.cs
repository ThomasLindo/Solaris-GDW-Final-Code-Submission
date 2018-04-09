﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
	SetRenderQueue.cs
 
	Sets the RenderQueue of an object's materials on Awake. This will instance
	the materials, so the script won't interfere with other renderers that
	reference the same materials.
*/
[AddComponentMenu("Rendering/SetRenderQueue")]

public class SetRenderQueue : MonoBehaviour {


    public bool Toggle = true;

    [SerializeField]
    protected int[] m_queues = new int[] { 3000 };

    protected void Awake() {
        if (!Toggle) { return; }
        Material[] materials = GetComponent<Renderer>().materials;
        for (int i = 0; i < materials.Length && i < m_queues.Length; ++i) {
            materials[i].renderQueue = m_queues[i];
        }
    }
}