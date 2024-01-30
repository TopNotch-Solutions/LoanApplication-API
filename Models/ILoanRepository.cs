namespace Pre_emince.Models
{
    public interface ILoanRepository
    {

       // Registration
        Task<IEnumerable<User>> SearchUser(string firstName, string? lastName);
        Task<User> GetSingleUser(int userID);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetASingleUserByEmail(string email);
        Task<User> AddAUser(User user);
        Task<ContactNumber> AddContactNumber(ContactNumber contactNumber);
        Task<BankDetail> AddBankDetail(BankDetail bankDetail);
        Task<EmploymentDetail> AddEmploymentDetail(EmploymentDetail employmentDetail);
        Task<NextOfKin> AddNextOfKin(NextOfKin nextOfKin);
        Task<DebitOrderInstruction> AddDebitOrderInstruction(DebitOrderInstruction debitOrderInstruction);
        Task<Admin> AddAnAdmin(Admin adminID);
        Task<Admin> GetASingleAdminByEmail(string email);
        Task<User> UpdateUserDetails(User user);
        Task<Admin> GetSingleAdmin(int userID);
        Task DeleteAUser(int userID);
        Task DeleteAnAdmin(int adminID);

        //Loan Application
        Task<LoanApplication> ApplyForLoan(LoanApplication loanApplication);
        //update only the record that is pending
        Task<LoanApplication> UpdateLoan(LoanApplication loanApplication);
        Task ChangePassportOrID(int userID, string document);
        Task ChangeBankStatement(int userID, string document);
        Task ChangePaySlip(int userID, string document);
        Task ChangeUttilityBill(int userID, string document);
        Task DeleteLoan(int userID);
        Task<int> GetTotalLoans();
        Task<int> GetToalLoansApproved();
        Task<int> GETotalLoansPending();
        Task<int> GetTotalLoansInProgress();
        Task<int> GetTotalLoansRejected();
        Task<IEnumerable<LoanApplication>> GetAllLoanApplication();
        Task<LoanApplication> GetASingleLoanApplication(int userID);
        Task<IEnumerable<LoanApplication>> SearchLoanApplication(string firstName, string? lastName);


        //Loan Review inprogress, approved, rejected
        Task LoanApplicationStatusReview(int userID, int status);
        Task WithDrawal(Payment payment);
        Task Deposit(int loanID, double amount);
        Task GetOustandingAmount(int userID);
        Task<string> ForgetPassworkuser(string email);
        Task<string> ForgetPassworkAdmin(string email);

        //Login
        Task<Admin> LoginAdmin(string email, string password);
        Task<User> LoginUser(string email, string password);
    }
}
