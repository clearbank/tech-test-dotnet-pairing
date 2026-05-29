using ClearBank.PaymentEngine.Services;
using ClearBank.PaymentEngine.Types;
using Xunit;

namespace ClearBank.PaymentEngine.Tests
{
    public class PaymentServiceTests
    {
        [Fact]
        public void MakePayment_Bacs_AccountDoesNotAllowBacs_Fails()
        {
            var service = new PaymentService();

            var result = service.MakePayment(CreateRequest(PaymentScheme.Bacs));

            Assert.False(result.Success);
        }

        [Fact]
        public void MakePayment_FasterPayments_AccountDoesNotAllowFasterPayments_Fails()
        {
            var service = new PaymentService();

            var result = service.MakePayment(CreateRequest(PaymentScheme.FasterPayments));

            Assert.False(result.Success);
        }

        [Fact]
        public void MakePayment_Chaps_AccountDoesNotAllowChaps_Fails()
        {
            var service = new PaymentService();

            var result = service.MakePayment(CreateRequest(PaymentScheme.Chaps));

            Assert.False(result.Success);
        }

        private static MakePaymentRequest CreateRequest(
            PaymentScheme scheme,
            decimal amount = 100m,
            string debtorAccountNumber = "12345") => new MakePaymentRequest
        {
            DebtorAccountNumber = debtorAccountNumber,
            Amount = amount,
            PaymentScheme = scheme
        };
    }
}
