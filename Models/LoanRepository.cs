using Microsoft.EntityFrameworkCore;

namespace Pre_emince.Models
{
    public class LoanRepository : ILoanRepository
    {
        private readonly AppDbContext appDbContext;
        public LoanRepository(AppDbContext appDbContext) {
            this.appDbContext = appDbContext;
                }

        async Task<Admin> ILoanRepository.AddAnAdmin(Admin admin)
        {
            var result = await appDbContext.Admins.AddAsync(admin);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        async Task<User> ILoanRepository.AddAUser(User user)
        {
            
          var result = await appDbContext.Users.AddAsync(user);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        async Task<BankDetail> ILoanRepository.AddBankDetail(BankDetail bankDetail)
        {
            var re = await appDbContext.Users.FirstOrDefaultAsync(e => e.UserID == bankDetail.UserID);
            if(re != null)
            {
                var result = await appDbContext.BankDetails.AddAsync(bankDetail);
                await appDbContext.SaveChangesAsync();
                return result.Entity;
            }
            return null;
        }

        async Task<ContactNumber> ILoanRepository.AddContactNumber(ContactNumber contactNumber)
        {
            var re = await appDbContext.Users.FirstOrDefaultAsync(e => e.UserID == contactNumber.UserID);
            if (re != null)
            {
                var result = await appDbContext.ContactNumbers.AddAsync(contactNumber);
                await appDbContext.SaveChangesAsync();
                return result.Entity;
            }
            return null;
        }

        async Task<DebitOrderInstruction> ILoanRepository.AddDebitOrderInstruction(DebitOrderInstruction debitOrderInstruction)
        {
            var re = await appDbContext.Users.FirstOrDefaultAsync(e => e.UserID == debitOrderInstruction.UserID);
            if (re != null)
            {

                var result = await appDbContext.DebitOrderInstructions.AddAsync(debitOrderInstruction);
                await appDbContext.SaveChangesAsync();
                return result.Entity;
            }
            return null;
        }

        async Task<EmploymentDetail> ILoanRepository.AddEmploymentDetail(EmploymentDetail employmentDetail)
        {
            var re = await appDbContext.Users.FirstOrDefaultAsync(e => e.UserID == employmentDetail.UserID);
            if (re != null)
            {
                var result = await appDbContext.EmploymentDetails.AddAsync(employmentDetail);
                await appDbContext.SaveChangesAsync();
                return result.Entity;
            }
            return null;  
        }

        async Task<NextOfKin> ILoanRepository.AddNextOfKin(NextOfKin nextOfKin)
        {
            var re = await appDbContext.Users.FirstOrDefaultAsync(e => e.UserID == nextOfKin.UserID);
            if (re != null)
            {
                var result = await appDbContext.NextOfKins.AddAsync(nextOfKin);
                await appDbContext.SaveChangesAsync();
                return result.Entity;
            }
            return null;   
        }

        async Task<LoanApplication> ILoanRepository.ApplyForLoan(LoanApplication loanApplication)
        {
          var result = await appDbContext.Users.FirstOrDefaultAsync(e =>e.UserID == loanApplication.UserID);
            if(result != null)
            {
                var re = await appDbContext.DebitOrderInstructions.FirstOrDefaultAsync(e => e.InstructionID == loanApplication.InstructionID);
                if (re != null)
                {

                    var res = await appDbContext.LoanApplications.AddAsync(loanApplication);
                    await appDbContext.SaveChangesAsync();
                    return res.Entity;
                }
            }
            return null;
        }

        async Task ILoanRepository.ChangeBankStatement(int loanID, string document)
        {
         
            
              var re = await appDbContext.LoanApplications.FirstOrDefaultAsync(e => e.LoanID == loanID);
                if(re != null)
                {
                    re.BankStatement = document;
                    await appDbContext.SaveChangesAsync();
                }
                
            
        }

        async Task ILoanRepository.ChangePassportOrID(int loanID, string document)
        {

            var re = await appDbContext.LoanApplications.FirstOrDefaultAsync(e => e.LoanID == loanID);
            if (re != null)
                {
                    re.PassportOrID = document;
                    await appDbContext.SaveChangesAsync();
                }

            
        }

       async Task ILoanRepository.ChangePaySlip(int loanID, string document)
        {

            var re = await appDbContext.LoanApplications.FirstOrDefaultAsync(e => e.LoanID == loanID);
            if (re != null)
                {
                    re.PaySlip = document;
                    await appDbContext.SaveChangesAsync();
                }

            
        }

       async Task ILoanRepository.ChangeUttilityBill(int loanID, string document)
        {

            var re = await appDbContext.LoanApplications.FirstOrDefaultAsync(e => e.LoanID == loanID);
            if (re != null)
                {
                    re.UtilityBill = document;
                    await appDbContext.SaveChangesAsync();
                }

            
        }

        async Task ILoanRepository.DeleteAnAdmin(int adminID)
        {
            var result = await appDbContext.Admins.FirstOrDefaultAsync(e => e.AdminID == adminID);
            if (result != null)
            {
                appDbContext.Admins.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

            async Task ILoanRepository.DeleteAUser(int userID)
        {
            var result = await appDbContext.Users.FirstOrDefaultAsync(e =>e.UserID == userID);
            if(result != null)
            {
                appDbContext.Users.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }
        //delete only when it is still pending
        async Task ILoanRepository.DeleteLoan(int userID)
        {
            var result = await appDbContext.Users.FirstOrDefaultAsync(e => e.UserID == userID);
            if(result != null)
            {
                var re = await appDbContext.LoanApplications.FirstOrDefaultAsync(e => e.UserID == userID);
                if(re != null)
                {
                    if(re.AppliactionStatus ==AppliactionStatus.Pending)
                    {
                        appDbContext.LoanApplications.Remove(re);
                        await appDbContext.SaveChangesAsync();
                    }
                }
            }
        }

        async Task ILoanRepository.Deposit(int loanID, double amount)
        {
            var result = await appDbContext.LoanApplications.FirstOrDefaultAsync(e => e.LoanID == loanID);

            if (result != null)
            {
                var re = await appDbContext.Payments.FirstOrDefaultAsync(e => e.LoanID == result.LoanID);
                if (re != null)
                {
                    re.AmountPaid += (decimal)amount;
                    await appDbContext.SaveChangesAsync();
                }

            }

        }

        async Task<string> ILoanRepository.ForgetPassworkAdmin(string email)
        {
            var result = await appDbContext.Admins.FirstOrDefaultAsync(e => e.Email == email);
            if (result != null)
            {
                return result.Password;
            }
            return null;
        }

        async Task<string> ILoanRepository.ForgetPassworkuser(string email)
        {
            var result = await appDbContext.Users.FirstOrDefaultAsync(e => e.Email == email);
            if (result != null)
            {
                return result.Password;
            }
            return null;
        }

        async Task<IEnumerable<LoanApplication>> ILoanRepository.GetAllLoanApplication()
        {
            return await appDbContext.LoanApplications.ToListAsync();
        }

        async Task<IEnumerable<User>> ILoanRepository.GetAllUsers()
        {
            return await appDbContext.Users.ToListAsync();
        }

        async Task<Admin> ILoanRepository.GetASingleAdminByEmail(string email)
        {
            return await appDbContext.Admins.FirstOrDefaultAsync(e => e.Email == email);
        }

        async Task<LoanApplication> ILoanRepository.GetASingleLoanApplication(int userID)
        {
           var results = await appDbContext.Users.FirstOrDefaultAsync(e => e.UserID == userID);
            if(results != null)
            {
                return await appDbContext.LoanApplications.FirstOrDefaultAsync(e => e.UserID == userID);
            }
            return null;
        }

        async Task<User> ILoanRepository.GetASingleUserByEmail(string email)
        {
           return await appDbContext.Users.FirstOrDefaultAsync(e => e.Email == email);
        }

        async Task<int> ILoanRepository.GETotalLoansPending()
        {
            return await appDbContext.LoanApplications.CountAsync(e => e.AppliactionStatus == AppliactionStatus.Pending);
        }

        Task ILoanRepository.GetOustandingAmount(int userID)
        {
            throw new NotImplementedException();
        }

        async Task<Admin> ILoanRepository.GetSingleAdmin(int userID)
        {
            return await appDbContext.Admins.FirstOrDefaultAsync(e => e.AdminID == userID);
        }

        async Task<User> ILoanRepository.GetSingleUser(int userID)
        {
            return await appDbContext.Users.FirstOrDefaultAsync(e => e.UserID == userID);
        }

        async Task<int> ILoanRepository.GetToalLoansApproved()
        {
            return await appDbContext.LoanApplications.CountAsync(e => e.AppliactionStatus == AppliactionStatus.Approved);
        }

        async Task<int> ILoanRepository.GetTotalLoans()
        {
            return await appDbContext.LoanApplications.CountAsync();
        }

        async Task<int> ILoanRepository.GetTotalLoansInProgress()
        {
            return await appDbContext.LoanApplications.CountAsync(e => e.AppliactionStatus == AppliactionStatus.InProgress);
        }

        async Task<int> ILoanRepository.GetTotalLoansRejected()
        {
            return await appDbContext.LoanApplications.CountAsync(e => e.AppliactionStatus == AppliactionStatus.Rejected);
        }

        async Task ILoanRepository.LoanApplicationStatusReview(int loanID, int status)
        {
            var result = await appDbContext.LoanApplications.FirstOrDefaultAsync(e =>e.LoanID == loanID);
            if(result != null)
            {
                if(status == 1)
                {
                    result.AppliactionStatus = AppliactionStatus.InProgress;
                    await appDbContext.SaveChangesAsync();
                }else if(status == 2)
                {
                    result.AppliactionStatus = AppliactionStatus.Approved;
                    await appDbContext.SaveChangesAsync();
                }else if(status == 3)
                {
                    result.AppliactionStatus = AppliactionStatus.Rejected;
                    await appDbContext.SaveChangesAsync();
                }
            }
        }

        async Task<Admin> ILoanRepository.LoginAdmin(string email, string password)
        {
            return await appDbContext.Admins.FirstOrDefaultAsync(e => e.Email == email && e.Password == password);
           
        }

        async Task<User> ILoanRepository.LoginUser(string email, string password)
        {
          return  await appDbContext.Users.FirstOrDefaultAsync(e => e.Email == email && e.Password == password);
        }

        async Task<IEnumerable<LoanApplication>> ILoanRepository.SearchLoanApplication(string firstName, string? lastName)

        {
            IQueryable<LoanApplication> query = appDbContext.LoanApplications;
           var result1= await appDbContext.Users.FirstOrDefaultAsync(e => e.FirstName == firstName);
            var result2 = await appDbContext.Users.FirstOrDefaultAsync(e => e.LastName == lastName);
            if (result1 != null)
            {
                query = query.Where(e => e.UserID == result1.UserID);
            }
            if(lastName != null)
            {
                if(result2 != null)
                {
                    query = query.Where(e => e.UserID == result2.UserID);
                }
            }
            return await query.ToListAsync();
        }

        async Task<IEnumerable<User>> ILoanRepository.SearchUser(string firstName, string? lastName)
        {
            IQueryable<User> query = appDbContext.Users;
            if (!string.IsNullOrEmpty(firstName))
            {
                query = query.Where(e => e.FirstName.Contains(firstName) || e.LastName.Contains(firstName));
            }
            if(lastName != null)
            {
                query = query.Where(e => e.FirstName.Contains(lastName) || e.LastName.Contains(lastName));
            }
            return await query.ToListAsync() ;
        }

        async Task<LoanApplication> ILoanRepository.UpdateLoan(LoanApplication loanApplication)
        {
            var result = await appDbContext.Users.FirstOrDefaultAsync(e =>e.UserID == loanApplication.UserID);
            if(result != null)
            {
                var re = await appDbContext.LoanApplications.FirstOrDefaultAsync(e => e.UserID == loanApplication.UserID);
                if(re != null)
                {
                    if(re.AppliactionStatus == AppliactionStatus.Pending)
                    {
                        re.LoanType = loanApplication.LoanType;
                        re.Amount = loanApplication.Amount;
                        re.NetIncomePerMonth = loanApplication.NetIncomePerMonth;
                        re.ReasonForLoan = loanApplication.ReasonForLoan;
                        re.MaritalStatus = loanApplication.MaritalStatus;
                        re.IDNumber = loanApplication.IDNumber;
                        re.AppliactionStatus = AppliactionStatus.Pending;
                         await appDbContext.SaveChangesAsync();
                    }
                }
                return null;
            }
            return null;
        }

        async Task<User> ILoanRepository.UpdateUserDetails(User user)
        {
            var result = await appDbContext.Users.FirstOrDefaultAsync(e => e.UserID == user.UserID);
            if(result != null)
            {
                result.FirstName = user.FirstName;
                result.LastName = user.LastName;
                result.Email = user.Email;
                result.BusinessName = user.BusinessName;
                result.MobileNumber = user.MobileNumber;
                result.Password = user.Password;
                result.Gender = user.Gender;
                result.Address = user.Address;
                result.ZipCode = user.ZipCode;
                await appDbContext.SaveChangesAsync();
            }
            return null;
        }

        async Task ILoanRepository.WithDrawal(Payment payment)
        {
            
            var result = await appDbContext.LoanApplications.FirstOrDefaultAsync(e => e.LoanID == payment.LoanID);
            if (result != null)
            {
                await appDbContext.Payments.AddAsync(payment);
                await appDbContext.SaveChangesAsync();
            }
        }
    }
}
