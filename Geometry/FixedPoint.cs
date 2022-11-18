/**
 * 定点数
 */

namespace GameBaseFramework.Geometry
{
    public struct FP
    {
        #region const
        public const int TOTAL_BITS = 64;
        public const int FRACTIONAL_BITS = 16;
        public const long ONE = 1L << FRACTIONAL_BITS;
        #endregion

        #region static
        public static readonly FP Zero = 0;
        public static readonly FP One = 1;
        #endregion

        #region value
        public long Value;
        #endregion

        #region 类型转换
        public static explicit operator long(FP value)
        {
            return value.Value >> FRACTIONAL_BITS;
        }

        public static implicit operator FP(long value)
        {
            FP result;
            result.Value = value << FRACTIONAL_BITS;
            return result;
        }

        public static explicit operator int(FP value)
        {
            return (int)(value.Value >> FRACTIONAL_BITS);
        }

        public static implicit operator FP(int value)
        {
            FP result;
            result.Value = (long)value << FRACTIONAL_BITS;
            return result;
        }

        public static explicit operator float(FP value)
        {
            return (float)value.Value / ONE;
        }

        public static implicit operator FP(float value)
        {
            FP result;
            result.Value = (long)(value * ONE);
            return result;
        }

        public override string ToString()
        {
            return ((float)this).ToString();
        }
        #endregion

        #region 运算
        public static FP operator +(FP x, FP y)
        {
            FP result;
            result.Value = x.Value + y.Value;
            return result;
        }

        public static FP operator -(FP x, FP y)
        {
            FP result;
            result.Value = x.Value - y.Value;
            return result;
        }

        public static FP operator *(FP x, FP y)
        {
            FP result;
            result.Value = x.Value * y.Value >> FRACTIONAL_BITS;
            return result;
        }

        public static FP operator /(FP x, FP y)
        {
            FP result;
            result.Value = (x.Value << FRACTIONAL_BITS) / y.Value;
            return result;
        }

        public static FP operator -(FP x)
        {
            x.Value = -x.Value;
            return x;
        }
        #endregion

        #region 比较
        public static bool operator <(FP x, FP y)
        {
            return x.Value < y.Value;
        }

        public static bool operator >(FP x, FP y)
        {
            return x.Value > y.Value;
        }
        #endregion
    }
}