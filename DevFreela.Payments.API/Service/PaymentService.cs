﻿using DevFreela.Payments.API.Models;
using System.Threading.Tasks;

namespace DevFreela.Payments.API.Service
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel)
        {
            return Task.FromResult(true);
        }

        public void ProcessMessageBus(PaymentInfoInputModel paymentInfoInputModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
