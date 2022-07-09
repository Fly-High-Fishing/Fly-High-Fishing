using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
    public static class Bezier
    {
        private static Vector3 ConstructRecurse(ref List<Vector3> points, float t)
        {
            if (points.Count == 2)
            {
                return Vector3.Lerp(points[0], points[1], t);
            }

            for (int i = 0; i < points.Count - 1; i++)
            {
                points[i] = Vector3.Lerp(points[i], points[i + 1], t);
            }
            points.RemoveAt(points.Count - 1);
            return ConstructRecurse(ref points, t);
        }
        /// <summary>
        /// Returns the position 't' on the bezier curve defined by 'points'.
        /// </summary>
        /// <param name="points"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Vector3 Construct(List<Vector3> points, float t)
        {
            return ConstructRecurse(ref points, t);
        }
    }
}