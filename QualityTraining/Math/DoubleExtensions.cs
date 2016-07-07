﻿namespace QualityTraining.Math
{
    /*
     * How to unit test this extension method ?
     * Can you explain what is the purpose of this extension and why we are doing that ?
     * Réponse : Cette extension permet de tester si deux objets de type double sont égaux entre eux, à un epsilon près qui part défaut vaut la plus petite valeur de double possible multipliée par 1000
     */

    public static class DoubleExtensions
    {
        public static bool IsEqualTo(this double self, double other, double epsilon = double.Epsilon * 1000)
        {
            return System.Math.Abs(self - other) < epsilon;
        }
    }
}
