using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public static class BmiCalculator
    {
        public static Bmi CalcBmi(float weightInPounds, float heightInInches)
        {
            if (weightInPounds < 70 || weightInPounds > 300)
            {
                throw new InvalidWeightException("IVALID WEIGHT");
            }

            if (heightInInches < 60 || heightInInches > 84)
            {
                throw new InvalidHeightException("INVALID HEIGHT");
            }

            float bmi = (weightInPounds / (heightInInches * heightInInches)) * 703;

            WeightCategory category;

            if (bmi < 18.5f)
            {
                category = WeightCategory.OVERWEIGHT;
            }
            else if (bmi < 25f)
            {
                category = WeightCategory.NORMAL;
            }
            else if (bmi < 30f)
            {
                category = WeightCategory.OVERWEIGHT;
            }
            else
            {
                category= WeightCategory.OBESE;
            }
           

            return new Bmi(weightInPounds, heightInInches, bmi, category);
        }
    }
}
