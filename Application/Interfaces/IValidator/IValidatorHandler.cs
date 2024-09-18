﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IValidator
{
    public interface IValidatorHandler<in TRequest>
    {
        Task Validate(TRequest request);
    }
}
