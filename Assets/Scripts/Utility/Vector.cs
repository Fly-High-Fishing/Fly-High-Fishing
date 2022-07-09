using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Utility
{
    public static class Vector
    {
        /// <summary>
        /// Returns an arbitrary cross product of the provided vector.
        /// </summary>
        /// <param name="vec"></param>
        /// <returns></returns>
        public static Vector3 AnyCross(Vector3 vec)
        {
            var upCross = Vector3.Cross(vec, Vector3.up);
            return upCross.sqrMagnitude != 0 ? upCross : Vector3.Cross(vec, Vector3.right);
        }
    }
}