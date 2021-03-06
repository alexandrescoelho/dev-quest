﻿using MyMath.API.Domain.DTO;
using MyMath.API.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMath.API.Domain.Services
{
    public class CalculatorService : ICalculatorService
    {
        public Task<DivisorCaluculationDTO> GetAllDivisorsAndPrimeNumber(int number)
        {

            var divisors = AwesomeMath.GetDivisorsFromPositiveNumber(number);
            var primes = divisors.Where(AwesomeMath.IsPrime);

            return Task.FromResult(new DivisorCaluculationDTO { Number = number, Divisors = divisors, Primes = primes });
        }
    }
}
