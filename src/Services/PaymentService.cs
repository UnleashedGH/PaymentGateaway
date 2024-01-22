using Blueprints;
using Entities.Models;
using Infrastructure;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Services.Blueprints;

namespace Services
{
    public sealed class PaymentService : IPaymentService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IUnitOfWork _unitOfWork;
        public PaymentService(IRepositoryManager iRepositoryManager, IUnitOfWork unitOfWork)
        {
            _repositoryManager = iRepositoryManager;
            _unitOfWork = unitOfWork;
        }
        
        public IEnumerable<Payment> GetPayments()
        {

           return  _repositoryManager.PaymentRepository.GetAllPayments();
        }

        public async Task IssuePayment(Payment payment)
        {
            _repositoryManager.PaymentRepository.AddPayment(payment);
            await _unitOfWork.SaveAsync();
        }

        public string ReturnHello() => "Hello From Payment Service";
     
    }
}
