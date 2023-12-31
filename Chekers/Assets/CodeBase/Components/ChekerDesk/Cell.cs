﻿using UnityEngine;

namespace CodeBase.Components.ChekerDesk
{
    public class Cell
    {
        private const string ChekerTag = "Cheker";
    
        public Vector3 Center;
        public bool IsEmpty = true;
        public bool IsPlayable = true;
        public Transform Cheker;

        private float _cellSize;

        public Cell(Vector3 center, float cellSize)
        {
            Center = center;
            _cellSize = cellSize;
        }

        public void FindCheker()
        {
            Ray ray = new Ray(Center, Vector3.up * _cellSize);
            if (Physics.Raycast(ray, out RaycastHit hit, 1f))
            {
                if (hit.transform.CompareTag(ChekerTag))
                {
                    IsEmpty = false;
                    Cheker = hit.transform;
                }
            }
        }

        public void Clear()
        {
            IsEmpty = true;
            IsPlayable = true;
            Cheker = null;
        }
    }
}