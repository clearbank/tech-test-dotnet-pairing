using ClearBank.PaymentEngine.Types;

namespace ClearBank.PaymentEngine.Data
{
    public class BackupAccountDataStore
    {
        public Account GetAccount(string accountNumber)
        {
            // Access backup database to retrieve account, code removed for brevity
            return new Account();
        }

        public void UpdateAccount(Account account)
        {
            // Update account in backup database, code removed for brevity
        }
    }
}
