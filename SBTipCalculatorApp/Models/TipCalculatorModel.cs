using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//Here, I have used Validation attributes of the DataAnnotations namespace to add Validation rules to my model.

namespace SBTipCalculatorApp.Models
{
    public class TipCalculatorModel
    {
        //This model c# class has 3 properties to get Cost of the meal and set tips for 15, 20 or 25 percent of the meal cost for this App.
        //Making the value as required for the property.
        //Hence, if the user doesn't enter a value for this property, the MVC framework generates a error msg.

        [Required (ErrorMessage = "Please enter the total Cost of your Meal.")]
        //Value of the property must be within the specified range of values.
        [Range(0,100000,ErrorMessage = "The Cost of the Meal must be greater than $0.00.")]
        public decimal? costOfMeal { get; set; }

        /// <summary>
        /// Custom method to calculate tips based on percentage.
        /// </summary>
        /// <returns></returns>
        public double? CalculateTips_15()
        {

            //define variables
            decimal? fifteenPT = 0;
            //For loop to validate the cost of the meal and calculate the tip.
            for (decimal i=0; i < costOfMeal; i++)
            {
                fifteenPT = 15 * costOfMeal / 100;
            }
            return (double?)fifteenPT;
        }
        /// <summary>
        /// Custom method for 20 % tip calculation
        /// </summary>
        /// <returns></returns>
        public decimal? CalculateTips_20()
        {
            //Defined the initial value of the variable to 0.
            decimal? twentyPT = 0;
            //For loop to validate the cost of the meal and calculate the tip.
            for (decimal i = 0; i < costOfMeal; i++)
            {
                twentyPT = 20 * costOfMeal / 100;
            }
            return twentyPT;
        }
        public decimal? CalculateTips_25()
        {
            //Defined the initial value of the variable to 0.

            decimal? twenty_5_PT = 0;
            //For loop to validate the cost of the meal and calculate the tip.
            for (decimal i = 0; i < costOfMeal; i++)
            {
                twenty_5_PT = 25 * costOfMeal / 100;
            }
            return twenty_5_PT;
        }

    }
}
