using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace AgainPractice.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidatorTool
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="validator"> Business katmanında tanımladığımız kurallara göre gelen kurallardır.(CategoryValidatory, ProductValidator) </param>
        /// <param name="entity"> Gelen kuralın hangi nesneye göre validate edileceğini belirtir. </param>
        #region Fluent_Validator

        public static void FluentValidate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }


        #endregion
        

    }
}
