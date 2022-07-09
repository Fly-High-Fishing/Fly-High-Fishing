using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
    public static class PointsOnSphere
    {
        private static readonly float _TurnFraction = (1.0f + Mathf.Sqrt(5.0f)) / 2.0f;

        public static Vector3[] GeneratePoints(int pointCount)
        {
            var points = new Vector3[pointCount];

            for (var i = 0; i < pointCount; i++)
            {
                var t = i / (pointCount - 1f);
                var inclination = Mathf.Acos(1 - 2 * t);
                var azimuth = 2 * Mathf.PI * _TurnFraction * i;

                points[i] = new Vector3(
                    Mathf.Sin(inclination) * Mathf.Cos(azimuth),
                    Mathf.Sin(inclination) * Mathf.Sin(azimuth),
                    Mathf.Cos(inclination));
            }

            return points;
        }
    }
}
