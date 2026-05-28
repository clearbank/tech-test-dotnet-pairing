using ClearBank.PaymentEngine.Services;
using ClearBank.PaymentEngine.Types;
using Xunit;

namespace ClearBank.PaymentEngine.Tests
{
    public class PaymentServiceTests
    {
        [Fact]
        public void MakePayment_WhenAccountDoesNotAllowScheme_Fails()
        {
            var service = new PaymentService();

            var result = service.MakePayment(new MakePaymentRequest
            {
                DebtorAccountNumber = "12345",
                Amount = 100m,
                PaymentScheme = PaymentScheme.Bacs
            });

            Assert.False(result.Success);
        }
    }
}
