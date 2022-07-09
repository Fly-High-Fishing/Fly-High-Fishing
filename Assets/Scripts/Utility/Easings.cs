namespace Utility
{
    public static class Easings
    {
        public static float EaseInOutSine(float t)
        {
            return -((float)System.Math.Cos(System.Math.PI * t) - 1) / 2.0f;
        }
    }
}