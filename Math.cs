namespace System{
    public partial class MathExtension{
        public static int MinMax(int from, int value, int to){
            return Math.Max(Math.Min(to, value), from);
        }

    }
}
