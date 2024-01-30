using Microsoft.EntityFrameworkCore;

namespace Pre_emince.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            

          
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ContactNumber> ContactNumbers { get; set; }
        public DbSet<BankDetail> BankDetails { get; set; }
        public DbSet<EmploymentDetail> EmploymentDetails { get; set;}
        public DbSet<NextOfKin> NextOfKins { get; set; }
        public DbSet<DebitOrderInstruction> DebitOrderInstructions { get; set;}
        public DbSet<Payment> Payments { get; set; }
        public DbSet<LoanApplication> LoanApplications { get; set; }
        public DbSet<LoanBalance> LoanBalances { get; set;}
    }
}
