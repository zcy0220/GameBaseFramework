/**
 * 定点数3维向量
 */

namespace GameBaseFramework.FixedPoint
{
    public struct FPVector3
    {
        #region static
        public static readonly FPVector3 zero = new FPVector3(FP.Zero, FP.Zero, FP.Zero);
        public static readonly FPVector3 one = new FPVector3(FP.One, FP.One, FP.One);
        public static readonly FPVector3 left = new FPVector3(-FP.One, FP.Zero, FP.Zero);
        public static readonly FPVector3 right = new FPVector3(FP.One, FP.Zero, FP.Zero);
        public static readonly FPVector3 up = new FPVector3(FP.Zero, FP.One, FP.Zero);
        public static readonly FPVector3 down = new FPVector3(FP.Zero, -FP.One, FP.Zero);
        public static readonly FPVector3 forward = new FPVector3(FP.Zero, FP.Zero, FP.One);
        public static readonly FPVector3 back = new FPVector3(FP.Zero, FP.Zero, -FP.One);
        #endregion

        #region value
        public FP x;
        public FP y;
        public FP z;
        #endregion

        #region 构造函数
        public FPVector3(FP x, FP y, FP z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        #endregion
    }
}