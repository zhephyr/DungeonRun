﻿using UnityEngine;

namespace Assets.Scripts
{
    public class FloorGenerator : MonoBehaviour
    {
        void Start()
        {
            Mesh mesh = GetComponent<MeshFilter>().mesh;
            Vector3[] vertices = mesh.vertices;
            Vector2[] uvs = new Vector2[vertices.Length];

            for (int i = 0; i < uvs.Length; i++)
            {
                uvs[i] = new Vector2(vertices[i].x, vertices[i].z);
            }
            mesh.uv = uvs;
        }
    }
}