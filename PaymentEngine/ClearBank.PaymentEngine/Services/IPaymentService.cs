using ClearBank.PaymentEngine.Types;

namespace ClearBank.PaymentEngine.Services
{
    public interface IPaymentService
    {
        MakePaymentResult MakePayment(MakePaymentRequest request);
    }
}
