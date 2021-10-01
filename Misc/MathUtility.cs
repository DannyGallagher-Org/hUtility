namespace hUtility
{
    public static class MathUtility
    {
        public static float ConvertRange(
            float originalStart, float originalEnd, // original range
            float newStart, float newEnd, // desired range
            float value) // value to convert
        {
            var scale = (newEnd - newStart) / (originalEnd - originalStart);
            return newStart + (value - originalStart) * scale;
        }
    }
}