using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BodyAnalyser
    {
        // Given the weight and height of a person, return the BMI
        public double CalculateBMI(double heightInMeters, double weightInKilo)
        {
            double bmi = weightInKilo / (heightInMeters * heightInMeters);
            return bmi;
        }

        // Given the weight and height of a person, return a brief analysis
        // of the BMI of that person
        public String AnalyseBMI(double heightInMeters, double weightInKilo)
        {
            // The below code must be changed
            double bmi = CalculateBMI(heightInMeters, weightInKilo);
            string analysis = "Din BMI er : " + bmi + ", ";

            if (bmi < 15)
            {
                analysis = analysis + "You are way to skinny";
            }

            if ((15 >= bmi) && (bmi <= 22))
            {            
                analysis = analysis + "You are a bit skinny";
            }

            if ((22 >= bmi) && (bmi <= 28))
            {
                analysis = analysis + "You are just fine";
            }

            if ((28 >= bmi) && (bmi <= 35))
            {
                analysis = analysis + "You are a bit overweight";
            }

            if (bmi > 35)
            {
                analysis = analysis + "You are way too fat, you fat fuck";
            }

            return analysis;
        }

    }
}
