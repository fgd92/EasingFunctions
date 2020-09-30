using System;

namespace Classes
{
    public class EasingF
    {
        const float c1 = 1.70158f;
        const float c2 = c1 * 1.525f;
        const float c3 = c1 + 1;
        const float c4 = (float)(2 * Math.PI) / 3;
        const float c5 = (float)((2 * Math.PI) / 4.5);
        const float n1 = 7.5625f;
        const float d1 = 2.75f;


        /// <summary>
        /// https://easings.net/ru#easeInSine
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInSine(float x)
        {
            return (float)(1 - Math.Cos((x * Math.PI) / 2));
        }
        /// <summary>
        /// https://easings.net/ru#easeOutSine
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseOutSine(float x)
        {
            return (float)Math.Sin((x * Math.PI) / 2);
        }
        /// <summary>
        /// https://easings.net/ru#easeInOutSine
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInOutSine(float x)
        {
            return (float)-(Math.Cos(Math.PI * x) - 1) / 2;
        }
        /// <summary>
        /// https://easings.net/ru#easeInQuad
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInQuad(float x)
        {
            return x * x;
        }
        /// <summary>
        /// https://easings.net/ru#easeOutQuad
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseOutQuad(float x)
        {
            return 1 - (1 - x) * (1 - x);
        }
        /// <summary>
        /// https://easings.net/ru#easeInOutQuad
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInOutQuad(float x)
        {
            return (float)(x < 0.5 ? 2 * x * x : 1 - Math.Pow(-2 * x + 2, 2) / 2);
        }
        /// <summary>
        /// https://easings.net/ru#easeInCubic
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInCubic(float x)
        {
            return x * x * x;
        }
        /// <summary>
        /// https://easings.net/ru#easeOutCubic
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseOutCubic(float x)
        {
            return (float)(1 - Math.Pow(1 - x, 3));
        }
        /// <summary>
        /// https://easings.net/ru#easeInOutCubic
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInOutCubic(float x)
        {
            return (float)(x < 0.5 ? 4 * x * x * x : 1 - Math.Pow(-2 * x + 2, 3) / 2);
        }
        /// <summary>
        /// https://easings.net/ru#easeInQuart
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInQuart(float x)
        {
            return x * x * x * x;
        }
        /// <summary>
        /// https://easings.net/ru#easeOutQuart
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseOutQuart(float x)
        {
            return (float)(1 - Math.Pow(1 - x, 4));
        }
        /// <summary>
        /// https://easings.net/ru#easeInOutQuart
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInOutQuart(float x)
        {
            return (float)(x < 0.5 ? 8 * x * x * x * x : 1 - Math.Pow(-2 * x + 2, 4) / 2);
        }
        /// <summary>
        /// https://easings.net/ru#easeInQuint
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInQuint(float x)
        {
            return x * x * x * x * x;
        }
        /// <summary>
        /// https://easings.net/ru#easeOutQuint
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseOutQuint(float x)
        {
            return (float)(1 - Math.Pow(1 - x, 5));
        }
        /// <summary>
        /// https://easings.net/ru#easeInOutQuint
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInOutQuint(float x)
        {
            return (float)(x < 0.5 ? 16 * x * x * x * x * x : 1 - Math.Pow(-2 * x + 2, 5) / 2);
        }
        /// <summary>
        /// https://easings.net/ru#easeInExpo
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInExpo(float x)
        {
            return (float)(x == 0 ? 0 : Math.Pow(2, 10 * x - 10));
        }
        /// <summary>
        /// https://easings.net/ru#easeOutExpo
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseOutExpo(float x)
        {
            return (float)(x == 1 ? 1 : 1 - Math.Pow(2, -10 * x));
        }
        /// <summary>
        /// https://easings.net/ru#easeInOutExpo
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float EaseInOutExpo(float x)
        {
            return (float)(x == 0
                ? 0
                : x == 1
                    ? 1
                    : x < 0.5 ? Math.Pow(2, 20 * x - 10) / 2
                        : (2 - Math.Pow(2, -20 * x + 10)) / 2);
        }
        /// <summary>
        /// https://easings.net/ru#easeInCirc
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseInCirc(float x)
        {
            return (float)(1 - Math.Sqrt(1 - Math.Pow(x, 2)));
        }
        /// <summary>
        /// https://easings.net/ru#easeOutCirc
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseOutCirc(float x)
        {
            return (float)Math.Sqrt(1 - Math.Pow(x - 1, 2));
        }
        /// <summary>
        /// https://easings.net/ru#easeInOutCirc
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseInOutCirc(float x)
        {
            return (float)(x < 0.5
            ? (1 - Math.Sqrt(1 - Math.Pow(2 * x, 2))) / 2
            : ( Math.Sqrt(1 -  Math.Pow(-2 * x + 2, 2)) + 1) / 2);
        }
        /// <summary>
        /// https://easings.net/ru#easeInBack
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseInBack(float x)
        {
            return c3 * x * x * x - c1 * x * x;
        }
        /// <summary>
        /// https://easings.net/ru#easeOutBack
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseOutBack(float x)
        {
            return (float)(1 + c3 * Math.Pow(x - 1, 3) + c1 * Math.Pow(x - 1, 2));
        }
        /// <summary>
        /// https://easings.net/ru#easeInOutBack
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseInOutBack(float x)
        {
            return (float)(x < 0.5
                ? (Math.Pow(2 * x, 2) * ((c2 + 1) * 2 * x - c2)) / 2
                : (Math.Pow(2 * x - 2, 2) * ((c2 + 1) * (x * 2 - 2) + c2) + 2) / 2);
        }
        /// <summary>
        /// https://easings.net/ru#easeInElastic
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseInElastic(float x)
        {
            return (float)(x == 0
                ? 0 : x == 1 ? 1 : - Math.Pow(2, 10 * x - 10) * Math.Sin((x * 10 - 10.75) * c4));
        }
        /// <summary>
        /// https://easings.net/ru#easeOutElastic
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseOutElastic(float x)
        {
            return (float)(x == 0
                ? 0
                : x == 1
                    ? 1
                    : Math.Pow(2, -10 * x) * Math.Sin((x * 10 - 0.75) * c4) + 1);
        }
        /// <summary>
        /// https://easings.net/ru#easeInOutElastic
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseInOutElastic(float x)
        {
            return (float)(x == 0 ? 0
                : x == 1 ? 1 : x < 0.5
                        ? -(Math.Pow(2, 20 * x - 10) * Math.Sin((20 * x - 11.125) * c5)) / 2
                        : (Math.Pow(2, -20 * x + 10) * Math.Sin((20 * x - 11.125) * c5)) / 2 + 1);
        }
        /// <summary>
        /// https://easings.net/ru#easeInBounce
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseInBounce(float x)
        {
            return 1 - EaseOutBounce(1 - x);
        }
        /// <summary>
        /// https://easings.net/ru#easeOutBounce
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseOutBounce(float x)
        {
            if (x < 1 / d1) 
            {
                return n1 * x * x;
            } 
            else if (x < 2 / d1)
            {
                return n1 * (x -= 1.5f / d1) * x + 0.75f;
            } 
            else if (x < 2.5 / d1) 
            {
                return n1 * (x -= 2.25f / d1) * x + 0.9375f;
            } 
            else
            {
                return n1 * (x -= 2.625f / d1) * x + 0.984375f;
            }
        }
        /// <summary>
        /// https://easings.net/ru#easeInOutBounce
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public  static  float EaseInOutBounce(float x)
        {
            return x < 0.5
                ? (1 - EaseOutBounce(1 - 2 * x)) / 2
                : (1 + EaseOutBounce(2 * x - 1)) / 2;
        }
    }
}