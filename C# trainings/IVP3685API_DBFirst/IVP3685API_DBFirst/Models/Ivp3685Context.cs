using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IVP3685API_DBFirst.Models;

public partial class Ivp3685Context : DbContext
{
    public Ivp3685Context()
    {
    }

    public Ivp3685Context(DbContextOptions<Ivp3685Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrator> Administrators { get; set; }

    public virtual DbSet<AuditBank> AuditBanks { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<CreditCard> CreditCards { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<GrpA> GrpAs { get; set; }

    public virtual DbSet<GrpB> GrpBs { get; set; }

    public virtual DbSet<Hod> Hods { get; set; }

    public virtual DbSet<HomeLoan> HomeLoans { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<NewBank> NewBanks { get; set; }

    public virtual DbSet<ProdBank> ProdBanks { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Product1> Products1 { get; set; }

    public virtual DbSet<Stdbank> Stdbanks { get; set; }

    public virtual DbSet<Stream> Streams { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Student1> Students1 { get; set; }

    public virtual DbSet<VuCurrentAccount> VuCurrentAccounts { get; set; }

    public virtual DbSet<VuEmpDept> VuEmpDepts { get; set; }

    public virtual DbSet<VuEmpDeptInfo> VuEmpDeptInfos { get; set; }

    public virtual DbSet<VuEmpInfoKhumar> VuEmpInfoKhumars { get; set; }

    public virtual DbSet<VuEmpManager> VuEmpManagers { get; set; }

    public virtual DbSet<VuJointAccount> VuJointAccounts { get; set; }

    public virtual DbSet<VuPremiumCustomer> VuPremiumCustomers { get; set; }

    public virtual DbSet<VuSavingAccount> VuSavingAccounts { get; set; }

    public virtual DbSet<VuStudentDetail> VuStudentDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=192.168.0.13\\\\\\\\sqlexpress,49753; Database = IVP3685; User Id = sa; Password = sa@12345678; TrustServerCertificate = True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrator>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Administ__719FE4E87D06FF84");

            entity.ToTable("Administrator", "MinProj");

            entity.HasIndex(e => e.UserId, "UQ__Administ__1788CCAD22EA0EAB").IsUnique();

            entity.HasIndex(e => e.AdminContact, "UQ__Administ__8286ECDC8685F11B").IsUnique();

            entity.HasIndex(e => e.AdminEmail, "UQ__Administ__F2AA7AD91608B908").IsUnique();

            entity.Property(e => e.AdminId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AdminID");
            entity.Property(e => e.AdminContact)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AdminEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AdminName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<AuditBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AuditBank");

            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.NewAccType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OldAccType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.XnDate).HasColumnType("datetime");
            entity.Property(e => e.XnType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__Bank__C1F8DC59E74D2FE1");

            entity.ToTable("Bank");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CID");
            entity.Property(e => e.AccType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CName");
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("India");
        });

        modelBuilder.Entity<CreditCard>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__CreditCa__C1F8DC591879723F");

            entity.ToTable("CreditCard");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CID");
            entity.Property(e => e.CardType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CName");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("DEPT_ID_PK");

            entity.ToTable("DEPARTMENTS");

            entity.Property(e => e.DepartmentId)
                .ValueGeneratedNever()
                .HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(30)
                .HasColumnName("DEPARTMENT_NAME");
            entity.Property(e => e.ManagerId).HasColumnName("MANAGER_ID");

            entity.HasOne(d => d.Manager).WithMany(p => p.Departments)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("DEPT_MGR_FK");
        });

        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PK__Dept__C0365630C484C6D9");

            entity.ToTable("Dept");

            entity.Property(e => e.Did)
                .ValueGeneratedNever()
                .HasColumnName("DID");
            entity.Property(e => e.Dname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DName");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("Emp_EID_PK");

            entity.ToTable("Emp");

            entity.HasIndex(e => e.AdharCard, "Emp_AC_UK").IsUnique();

            entity.HasIndex(e => e.Email, "Emp_mail_UK").IsUnique();

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("EID");
            entity.Property(e => e.AdharCard)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("India");
            entity.Property(e => e.Did).HasColumnName("DID");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Mid).HasColumnName("MID");

            entity.HasOne(d => d.DidNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Did)
                .HasConstraintName("Emp_DID_FK");

            entity.HasOne(d => d.MidNavigation).WithMany(p => p.InverseMidNavigation)
                .HasForeignKey(d => d.Mid)
                .HasConstraintName("Emp_MID_FK");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("EMP_EMP_ID_PK");

            entity.ToTable("EMPLOYEES");

            entity.HasIndex(e => e.DepartmentId, "EMPLOYEES_DEPARTMENT_ID_NCI");

            entity.HasIndex(e => e.Email, "EMP_EMAIL_UK").IsUnique();

            entity.HasIndex(e => e.EmployeeId, "employees_FIDX").HasFilter("([COMMISSION_PCT] IS NOT NULL)");

            entity.HasIndex(e => new { e.LastName, e.JobId, e.HireDate }, "employees_UCI");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.CommissionPct).HasColumnName("COMMISSION_PCT");
            entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.HireDate)
                .HasColumnType("datetime")
                .HasColumnName("HIRE_DATE");
            entity.Property(e => e.JobId)
                .HasMaxLength(10)
                .HasColumnName("JOB_ID");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.ManagerId).HasColumnName("MANAGER_ID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE_NUMBER");
            entity.Property(e => e.Salary).HasColumnName("SALARY");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("EMP_DEPT_FK");

            entity.HasOne(d => d.Job).WithMany(p => p.Employees)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EMP_JOB_FK");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("EMP_MANAGER_FK");
        });

        modelBuilder.Entity<GrpA>(entity =>
        {
            entity.HasKey(e => e.TeamId).HasName("PK__grpA__123AE7B920D7ACD0");

            entity.ToTable("grpA");

            entity.Property(e => e.TeamId).HasColumnName("TeamID");
            entity.Property(e => e.TeamName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GrpB>(entity =>
        {
            entity.HasKey(e => e.TeamId).HasName("PK__grpB__123AE7B9F26CA441");

            entity.ToTable("grpB");

            entity.Property(e => e.TeamId).HasColumnName("TeamID");
            entity.Property(e => e.TeamName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hod>(entity =>
        {
            entity.HasKey(e => e.Hodid).HasName("PK__HOD__402E7AE593F32CAA");

            entity.ToTable("HOD", "MinProj");

            entity.HasIndex(e => e.Email, "UQ__HOD__A9D10534ABF009C5").IsUnique();

            entity.Property(e => e.Hodid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HODID");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HireDate).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StreamId).HasColumnName("StreamID");

            entity.HasOne(d => d.Stream).WithMany(p => p.Hods)
                .HasForeignKey(d => d.StreamId)
                .HasConstraintName("FK__HOD__StreamID__3D2915A8");
        });

        modelBuilder.Entity<HomeLoan>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__HomeLoan__C1F8DC59D64876CC");

            entity.ToTable("HomeLoan");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CName");
            entity.Property(e => e.LoanType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("JOBS_ID_PK");

            entity.ToTable("JOBS");

            entity.Property(e => e.JobId)
                .HasMaxLength(10)
                .HasColumnName("JOB_ID");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(50)
                .HasColumnName("JOB_TITLE");
            entity.Property(e => e.MaxSalary).HasColumnName("MAX_SALARY");
            entity.Property(e => e.MinSalary).HasColumnName("MIN_SALARY");
        });

        modelBuilder.Entity<NewBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NewBank");

            entity.Property(e => e.AccType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CName");
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProdBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Prod_Bank");

            entity.Property(e => e.AccType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CName");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Product");

            entity.HasIndex(e => e.Pcategory, "Product_PCat_NCI");

            entity.Property(e => e.Pcategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PCategory");
            entity.Property(e => e.Pid).HasColumnName("PID");
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PName");
        });

        modelBuilder.Entity<Product1>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Product__C57755209A582938");

            entity.ToTable("Product", "Sales");

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("PID");
            entity.Property(e => e.Pname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PName");
        });

        modelBuilder.Entity<Stdbank>(entity =>
        {
            entity.HasKey(e => e.Cid)
                .HasName("STDBANK_PK")
                .IsClustered(false);

            entity.ToTable("STDBANK");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CID");
            entity.Property(e => e.AccType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CName");
            entity.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Stream>(entity =>
        {
            entity.HasKey(e => e.StreamId).HasName("PK__Stream__07C87AB2212F0503");

            entity.ToTable("Stream", "MinProj");

            entity.Property(e => e.StreamId).HasColumnName("StreamID");
            entity.Property(e => e.StreamName)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("student");

            entity.HasIndex(e => new { e.Branch, e.Marks }, "Student_Branch_Marks_NCI");

            entity.HasIndex(e => e.Branch, "Student_Branch_NCI");

            entity.HasIndex(e => e.Marks, "Student_Marks_NCI");

            entity.HasIndex(e => e.Sid, "Student_SID_UCI")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => new { e.Sname, e.Marks }, "Student_SName_Marks_NCI");

            entity.HasIndex(e => e.Sname, "Student_SName_NCI");

            entity.Property(e => e.Branch)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SName");
        });

        modelBuilder.Entity<Student1>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Student__CA195970A9478EEE");

            entity.ToTable("Student", "MinProj");

            entity.HasIndex(e => e.Email, "UQ__Student__A9D1053490CF5F48").IsUnique();

            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.AdmissionDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grade)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StreamId).HasColumnName("StreamID");

            entity.HasOne(d => d.Stream).WithMany(p => p.Student1s)
                .HasForeignKey(d => d.StreamId)
                .HasConstraintName("FK__Student__StreamI__37703C52");
        });

        modelBuilder.Entity<VuCurrentAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuCurrentAccount");

            entity.Property(e => e.AccType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cid).HasColumnName("CID");
        });

        modelBuilder.Entity<VuEmpDept>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuEmpDept");

            entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(30)
                .HasColumnName("DEPARTMENT_NAME");
            entity.Property(e => e.EmpName)
                .HasMaxLength(46)
                .IsUnicode(false)
                .HasColumnName("EMP_NAME");
            entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.HireDate)
                .HasColumnType("datetime")
                .HasColumnName("HIRE_DATE");
            entity.Property(e => e.JobId)
                .HasMaxLength(10)
                .HasColumnName("JOB_ID");
            entity.Property(e => e.Salary).HasColumnName("SALARY");
        });

        modelBuilder.Entity<VuEmpDeptInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuEmpDeptInfo");

            entity.Property(e => e.DeptName).HasMaxLength(30);
        });

        modelBuilder.Entity<VuEmpInfoKhumar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuEmpInfo_Khumar");

            entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.HireDate)
                .HasColumnType("datetime")
                .HasColumnName("HIRE_DATE");
            entity.Property(e => e.HireMonth).HasMaxLength(30);
            entity.Property(e => e.JobId)
                .HasMaxLength(10)
                .HasColumnName("JOB_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(46)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnName("SALARY");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<VuEmpManager>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuEmpManager");

            entity.Property(e => e.ManagerId).HasColumnName("manager_id");
            entity.Property(e => e.ManagerName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("manager_name");
            entity.Property(e => e.WorkerName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("worker_name");
            entity.Property(e => e.WorkerSalary).HasColumnName("worker_salary");
        });

        modelBuilder.Entity<VuJointAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuJointAccount");

            entity.Property(e => e.AccType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CName");
        });

        modelBuilder.Entity<VuPremiumCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuPremiumCustomers");

            entity.Property(e => e.AccType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CName");
        });

        modelBuilder.Entity<VuSavingAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuSavingAccount");

            entity.Property(e => e.AccType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CName");
        });

        modelBuilder.Entity<VuStudentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vuStudentDetails", "MinProj");

            entity.Property(e => e.AdmissionDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grade)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Hodname)
                .HasMaxLength(41)
                .IsUnicode(false)
                .HasColumnName("HODName");
            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.StreamName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(101)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
