using Microsoft.AspNetCore.Mvc;
using Pre_emince.Models;

namespace Pre_emince.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILoanRepository loanRepository;
        public LoanController(ILoanRepository loanRepository)
        {
            this.loanRepository = loanRepository;
        }
        [HttpPost("AddAnAdmin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Admin>> AddAnAdmin(Admin admin)
        {
            try
            {
                if (admin == null)
                {
                    return BadRequest();
                }

                var result = await loanRepository.GetASingleAdminByEmail(admin.Email);

                if (result != null)
                {
                    return BadRequest("User already exists");
                }

                var createUser = await loanRepository.AddAnAdmin(admin);

                return CreatedAtAction(nameof(ILoanRepository.GetSingleAdmin), new { id = createUser.AdminID }, createUser);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPost("AddAUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<User>> AddAUser(User user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("Enter all the fields");
                }

                var result = await loanRepository.GetASingleUserByEmail(user.Email);

                if (result != null)
                {
                    return BadRequest("User already exists");
                }

                var createUser = await loanRepository.AddAUser(user);

                return CreatedAtAction(nameof(ILoanRepository.GetSingleUser), new { id = createUser.UserID }, createUser);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPost("AddBankDetail")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<User>> AddBankDetail(BankDetail bankDetail)
        {
            try
            {
                if (AddBankDetail == null)
                {
                    return BadRequest("Enter all the fields");
                }

                var result = await loanRepository.GetSingleUser(bankDetail.UserID);

                if (result == null)
                {
                    return BadRequest("User does not exists");
                }

                var createUser = await loanRepository.AddBankDetail(bankDetail);

                return CreatedAtAction(nameof(ILoanRepository.GetSingleUser), new { id = createUser.UserID }, createUser);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPost("AddContactNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<User>> AddContactNumber(ContactNumber bankDetail)
        {
            try
            {
                if (AddBankDetail == null)
                {
                    return BadRequest("Enter all the fields");
                }

                var result = await loanRepository.GetSingleUser(bankDetail.UserID);

                if (result == null)
                {
                    return BadRequest("User does not exists");
                }

                var createUser = await loanRepository.AddContactNumber(bankDetail);

                return CreatedAtAction(nameof(ILoanRepository.GetSingleUser), new { id = createUser.UserID }, createUser);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPost("AddDebitOrderInstruction")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<User>> AddDebitOrderInstruction(DebitOrderInstruction bankDetail)
        {
            try
            {
                if (AddBankDetail == null)
                {
                    return BadRequest("Enter all the fields");
                }

                var result = await loanRepository.GetSingleUser(bankDetail.UserID);

                if (result == null)
                {
                    BadRequest("User does not exists");
                }

                var createUser = await loanRepository.AddDebitOrderInstruction(bankDetail);

                return CreatedAtAction(nameof(ILoanRepository.GetSingleUser), new { id = createUser.UserID }, createUser);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPost("AddEmploymentDetail")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<User>> AddEmploymentDetail(EmploymentDetail bankDetail)
        {
            try
            {
                if (AddBankDetail == null)
                {
                    return BadRequest("Enter all the fields");
                }

                var result = await loanRepository.GetSingleUser(bankDetail.UserID);

                if (result == null)
                {
                    return BadRequest("User does not exists");
                }

                var createUser = await loanRepository.AddEmploymentDetail(bankDetail);

                return CreatedAtAction(nameof(ILoanRepository.GetSingleUser), new { id = createUser.UserID }, createUser);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPost("AddNextOfKin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<User>> AddNextOfKin(NextOfKin bankDetail)
        {
            try
            {
                if (AddBankDetail == null)
                {
                    return BadRequest("Enter all the fields");
                }

                var result = await loanRepository.GetSingleUser(bankDetail.UserID);

                if (result == null)
                {
                    return BadRequest("User does not exists");
                }

                var createUser = await loanRepository.AddNextOfKin(bankDetail);

                return CreatedAtAction(nameof(ILoanRepository.GetSingleUser), new { id = createUser.UserID }, createUser);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }

        [HttpPost("ApplyForALoan")]
        
        public async Task<ActionResult<LoanApplication>> ApplyForLoan(LoanApplication app)
        {
            try
            {
                if (!ModelState.IsValid || app == null)
                {
                   return BadRequest(ModelState);
                }
                var createLoan = await loanRepository.ApplyForLoan(app);
                return CreatedAtAction(nameof(ILoanRepository.GetASingleLoanApplication), new { id = createLoan.InstructionID }, createLoan);
           }
           catch (Exception ex)
           {
               return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPatch("ChangeBankStatement/{loanID:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> ChangeBankStatement(int loanID, string document)
        {
            try
            {
                if (loanID == 0 || string.IsNullOrEmpty(document))
                {
                    return BadRequest();
                }
                await loanRepository.ChangeBankStatement(loanID, document);
                return Ok("Bank Statement successfully changed!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPatch("ChangePassportOrID/{loanID:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> ChangePassportOrID(int loanID, string document)
        {
            try
            {
                if (loanID == 0 || string.IsNullOrEmpty(document))
                {
                    return BadRequest();
                }
                await loanRepository.ChangePassportOrID(loanID, document);
                return Ok("Bank Statement successfully changed!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPatch("ChangePaySlip/{loanID:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> ChangePaySlip(int loanID, string document)
        {
            try
            {
                if (loanID == 0 || string.IsNullOrEmpty(document))
                {
                    return BadRequest();
                }
                await loanRepository.ChangePaySlip(loanID, document);
                return Ok("Bank Statement successfully changed!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPatch("ChangeUttilityBill/{loanID:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> ChangeUttilityBill(int loanID, string document)
        {
            try
            {
                if (loanID == 0 || string.IsNullOrEmpty(document))
                {
                    return BadRequest();
                }
                await loanRepository.ChangeUttilityBill(loanID, document);
                return Ok("Bank Statement successfully changed!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpDelete("DeleteUser/{userID:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteAUser(int userID)
        {
            try
            {

                var result = await loanRepository.GetSingleUser(userID);
                if(result == null)
                {
                    return NotFound("User not found");
                }
                await loanRepository.DeleteAUser(userID);
                return Ok($"User {userID} has been deleted");
            }catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpDelete("DeleteAnAdmin/{userID:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteAnAdmin(int userID)
        {
            try
            {

                var result = await loanRepository.GetSingleAdmin(userID);
                if (result == null)
                {
                    return NotFound("User not found");
                }
                await loanRepository.DeleteAnAdmin(userID);
                return Ok($"User {userID} has been deleted");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpDelete("DeleteALoan/{userID:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> DeleteLoan(int userID)
        {
            try
            {

                var result = await loanRepository.GetASingleLoanApplication(userID);
                if (result == null)
                {
                    return NotFound("Loan not found");
                }
                await loanRepository.DeleteLoan(userID);
                return Ok($"Loan {userID} has been deleted");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPatch("DepositMoney/{userID:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Deposit(int userID, double amount)
        {
            try
            {
                if (userID == 0 || amount <= 0)
                {
                    return BadRequest();
                }
                await loanRepository.Deposit(userID, amount);
                return Ok("Amount successfully deposite!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("ForgetPassworkAdmin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> ForgetPassworkAdmin(string email)
        {
            try
            {
                if (email == null)
                {
                    return BadRequest();
                }

                var result = await loanRepository.GetASingleAdminByEmail(email);

                if (result == null)
                {
                    return BadRequest("User already exists");
                }

                var password = await loanRepository.ForgetPassworkAdmin(email);

                return Ok(password);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("ForgetPassworkuser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> ForgetPassworkuser(string email)
        {
            try
            {
                if (email == null)
                {
                    return BadRequest();
                }

                var result = await loanRepository.GetASingleUserByEmail(email);

                if (result == null)
                {
                    return BadRequest("User already exists");
                }

                var password = await loanRepository.ForgetPassworkuser(email);

                return Ok(password);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GetAllLoanApplication")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
     
        public async Task<ActionResult> GetAllLoanApplication()
        {
            try
            {
                return Ok(await loanRepository.GetAllLoanApplication());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GetAllUsers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> GetAllUsers()
        {
            try
            {
                return Ok(await loanRepository.GetAllUsers());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GetASingleAdminByEmail")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> GetASingleAdminByEmail(string email)
        {
            try
            {
                if(email == null)
                {
                    return BadRequest();
                }
                var result = await loanRepository.GetASingleAdminByEmail(email);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GetASingleLoanApplication")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> GetASingleLoanApplication(int userID)
        {
            try
            {
               
                var result = await loanRepository.GetASingleLoanApplication(userID);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GetASingleUserByEmail")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> GetASingleUserByEmail(string email)
        {
            try
            {
                if (email == null)
                {
                    return BadRequest();
                }
                var result = await loanRepository.GetASingleUserByEmail(email);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GETotalLoansPending")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> GETotalLoansPending()
        {
            try
            {
                return Ok(await loanRepository.GETotalLoansPending());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GetSingleAdmin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
       // [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> GetSingleAdmin(int adminID)
        {
            try
            {
                
                var result = await loanRepository.GetSingleAdmin(adminID);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GetSingleUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> GetSingleUser(int userID)
        {
            try
            {

                var result = await loanRepository.GetSingleUser(userID);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GetToalLoansApproved")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> GetToalLoansApproved()
        {
            try
            {
                return Ok(await loanRepository.GetToalLoansApproved());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GetTotalLoans")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> GetTotalLoans()
        {
            try
            {
                return Ok(await loanRepository.GetTotalLoans());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GetTotalLoansInProgress")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> GetTotalLoansInProgress()
        {
            try
            {
                return Ok(await loanRepository.GetTotalLoansInProgress());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("GetTotalLoansRejected")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> GetTotalLoansRejected()
        {
            try
            {
                return Ok(await loanRepository.GetTotalLoansRejected());
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPatch("LoanApplicationStatusReview/{loanID:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> LoanApplicationStatusReview(int loanID, int status)
        {
            try
            {
                if (loanID == 0 || status ==0)
                {
                    return BadRequest();
                }
                await loanRepository.LoanApplicationStatusReview(loanID, status);
                return Ok("Loan status Changed");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("LoginAdmin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> LoginAdmin(string email, string password)
        {
            try
            {
                if (email == null || password == null)
                {
                    return BadRequest();
                }
                return Ok(await loanRepository.LoginAdmin(email,password));
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("LoginUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> LoginUser(string email, string password)
        {
            try
            {
                if (email == null || password == null)
                {
                    return BadRequest();
                }
                return Ok(await loanRepository.LoginUser(email, password));
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("LearchLoanApplication")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> SearchLoanApplication(string firstName, string? lastName)
        {
            try
            {
                var result = await loanRepository.SearchLoanApplication(firstName, lastName);
                if (result.Any())
                {
                    return Ok(result);
                }
                
                    return NotFound();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpGet("SearchUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> SearchUser(string firstName, string? lastName)
        {
            try
            {
                var result = await loanRepository.SearchUser(firstName, lastName);
                if (result.Any())
                {
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPut("UpdateLoan")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> UpdateLoan(LoanApplication loanApplication)
        {
            try
            {
                if(loanApplication == null)
                {
                    return BadRequest();
                }
                var studentUpdate = await loanRepository.GetASingleLoanApplication(loanApplication.LoanID);
                if(studentUpdate == null) {
                    return NotFound();
                }
                return Ok("Loan application successfully updated");
            }catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPut("UpdateUserDetails")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> UpdateUserDetails(User user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest();
                }
                var studentUpdate = await loanRepository.GetSingleUser(user.UserID);
                if (studentUpdate == null)
                {
                    return NotFound();
                }
                return Ok("User details successfully updated");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
        [HttpPost("WithDrawal")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Admin>> WithDrawal(Payment payment)
        {
            try
            {
                if (payment == null)
                {
                    return BadRequest();
                }

                var result = await loanRepository.GetSingleAdmin(payment.AdminID);

                if (result != null)
                {
                    await loanRepository.WithDrawal(payment);

                    return Ok($"Withdrawal by {payment.AdminID}");
                    
                }
                return NotFound("Admin to found");

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }
    }
}
