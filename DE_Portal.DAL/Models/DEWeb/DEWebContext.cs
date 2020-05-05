using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class DEWebContext : DbContext
    {
        public DEWebContext()
        {
        }

        public DEWebContext(DbContextOptions<DEWebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blogs> Blogs { get; set; }
        public virtual DbSet<BlogsAuthor> BlogsAuthor { get; set; }
        public virtual DbSet<BlogsResponse> BlogsResponse { get; set; }
        public virtual DbSet<BlogsSubscription> BlogsSubscription { get; set; }
        public virtual DbSet<BootCamp> BootCamp { get; set; }
        public virtual DbSet<NewsLetter> NewsLetter { get; set; }
        public virtual DbSet<NewsLetterBlock> NewsLetterBlock { get; set; }
        public virtual DbSet<NewsLetterBlockLink> NewsLetterBlockLink { get; set; }
        public virtual DbSet<NewsLetterGroup> NewsLetterGroup { get; set; }
        public virtual DbSet<NewsLetterUnsubscribe> NewsLetterUnsubscribe { get; set; }
        public virtual DbSet<NewsletterCampaignClick> NewsletterCampaignClick { get; set; }
        public virtual DbSet<RegistrationForm> RegistrationForm { get; set; }
        public virtual DbSet<Rumcapplications> Rumcapplications { get; set; }
        public virtual DbSet<RumcapplicationsForPasswords> RumcapplicationsForPasswords { get; set; }
        public virtual DbSet<RumcapplicationsOld> RumcapplicationsOld { get; set; }
        public virtual DbSet<Rumcbadges> Rumcbadges { get; set; }
        public virtual DbSet<Rumcmodules> Rumcmodules { get; set; }
        public virtual DbSet<Rumcsupervisors> Rumcsupervisors { get; set; }
        public virtual DbSet<Rumcvips> Rumcvips { get; set; }
        public virtual DbSet<SiteContent> SiteContent { get; set; }
        public virtual DbSet<SiteData> SiteData { get; set; }
        public virtual DbSet<SiteReusableParts> SiteReusableParts { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<SurveyQuestion> SurveyQuestion { get; set; }
        public virtual DbSet<SurveyQuestionAnswer> SurveyQuestionAnswer { get; set; }
        public virtual DbSet<SurveyQuestionManager> SurveyQuestionManager { get; set; }
        public virtual DbSet<SurveyQuestionType> SurveyQuestionType { get; set; }
        public virtual DbSet<SurveySubmission> SurveySubmission { get; set; }
        public virtual DbSet<SurveySubmissionAnswer> SurveySubmissionAnswer { get; set; }
        public virtual DbSet<VSiteContent> VSiteContent { get; set; }
        public virtual DbSet<WhitePaper> WhitePaper { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=DEWebNew;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.BlogText)
                    .HasColumnName("blog_text")
                    .HasColumnType("text");

                entity.Property(e => e.DatetimeCreated)
                    .HasColumnName("datetime_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatetimeModified)
                    .HasColumnName("datetime_modified")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatetimePublished)
                    .HasColumnName("datetime_published")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsPublished).HasColumnName("is_published");

                entity.Property(e => e.ShortText)
                    .HasColumnName("short_text")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlogsAuthor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlogsResponse>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BlogId).HasColumnName("blog_id");

                entity.Property(e => e.DatetimeCreated)
                    .HasColumnName("datetime_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseText)
                    .HasColumnName("response_text")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<BlogsSubscription>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.DatetimeCreated)
                    .HasColumnName("datetime_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BootCamp>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Attend)
                    .HasColumnName("attend")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Event)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Transport)
                    .HasColumnName("transport")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewsLetter>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Draft)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowOnSite)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TitleColor).HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<NewsLetterBlock>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.NewsLetterNavigation)
                    .WithMany(p => p.NewsLetterBlock)
                    .HasForeignKey(d => d.NewsLetter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewsLetterBlock");
            });

            modelBuilder.Entity<NewsLetterBlockLink>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Visited).HasColumnType("datetime");

                entity.HasOne(d => d.BlockNavigation)
                    .WithMany(p => p.NewsLetterBlockLink)
                    .HasForeignKey(d => d.Block)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewsLetterBlockLink");
            });

            modelBuilder.Entity<NewsLetterGroup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.NewsLetterNavigation)
                    .WithMany(p => p.NewsLetterGroup)
                    .HasForeignKey(d => d.NewsLetter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewsLetterGroup");
            });

            modelBuilder.Entity<NewsLetterUnsubscribe>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.NewsLetterNavigation)
                    .WithMany(p => p.NewsLetterUnsubscribe)
                    .HasForeignKey(d => d.NewsLetter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewsLetterUnsubscribe");
            });

            modelBuilder.Entity<NewsletterCampaignClick>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Campaign)
                    .HasColumnName("campaign")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignCid)
                    .HasColumnName("campaign_cid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignCompany)
                    .HasColumnName("campaign_company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignEmail)
                    .HasColumnName("campaign_email")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignName)
                    .HasColumnName("campaign_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignOption1).HasColumnName("campaign_option1");

                entity.Property(e => e.CampaignOption2).HasColumnName("campaign_option2");

                entity.Property(e => e.CampaignOption3).HasColumnName("campaign_option3");

                entity.Property(e => e.CampaignOption4).HasColumnName("campaign_option4");

                entity.Property(e => e.CampaignOption5).HasColumnName("campaign_option5");

                entity.Property(e => e.CampaignOption6).HasColumnName("campaign_option6");

                entity.Property(e => e.CampaignOption7).HasColumnName("campaign_option7");

                entity.Property(e => e.CampaignOption8).HasColumnName("campaign_option8");

                entity.Property(e => e.CampaignPhone)
                    .HasColumnName("campaign_phone")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignRegistered).HasColumnName("campaign_registered");

                entity.Property(e => e.ClickedCid)
                    .HasColumnName("clicked_cid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClickedLink)
                    .HasColumnName("clicked_link")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DatetimeCreated)
                    .HasColumnName("datetime_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserAgent)
                    .HasColumnName("user_agent")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegistrationForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Campaign)
                    .IsRequired()
                    .HasColumnName("campaign")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rumcapplications>(entity =>
            {
                entity.ToTable("RUMCApplications");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrder).HasDefaultValueSql("((100))");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RumcapplicationsForPasswords>(entity =>
            {
                entity.ToTable("RUMCApplicationsForPasswords");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrder).HasDefaultValueSql("((100))");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RumcapplicationsOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RUMCApplicationsOLD");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Rumcbadges>(entity =>
            {
                entity.ToTable("RUMCBadges");

                entity.Property(e => e.BadgeId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rumcmodules>(entity =>
            {
                entity.ToTable("RUMCModules");

                entity.Property(e => e.EscalateTo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rumcsupervisors>(entity =>
            {
                entity.ToTable("RUMCSupervisors");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Rumcvips>(entity =>
            {
                entity.ToTable("RUMCVIPs");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiteContent>(entity =>
            {
                entity.HasIndex(e => e.SiteContentPath)
                    .HasName("IX_SiteContent_Path");

                entity.Property(e => e.SiteContentId).HasColumnName("SiteContent_ID");

                entity.Property(e => e.SiteContentClear).HasColumnName("SiteContent_Clear");

                entity.Property(e => e.SiteContentContent)
                    .HasColumnName("SiteContent_Content")
                    .IsUnicode(false);

                entity.Property(e => e.SiteContentLocation)
                    .HasColumnName("SiteContent_Location")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SiteContentName)
                    .HasColumnName("SiteContent_Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SiteContentPath)
                    .IsRequired()
                    .HasColumnName("SiteContent_Path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SiteContentTitle)
                    .HasColumnName("SiteContent_Title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SiteReusablePartsName)
                    .HasColumnName("SiteReusableParts_Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiteData>(entity =>
            {
                entity.HasKey(e => e.SiteDataName);

                entity.Property(e => e.SiteDataName)
                    .HasColumnName("SiteData_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteDataData)
                    .HasColumnName("SiteData_Data")
                    .HasColumnType("xml");

                entity.Property(e => e.SiteDataTs)
                    .IsRequired()
                    .HasColumnName("SiteData_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<SiteReusableParts>(entity =>
            {
                entity.HasKey(e => e.SiteReusablePartsName);

                entity.Property(e => e.SiteReusablePartsName)
                    .HasColumnName("SiteReusableParts_Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SiteReusablePartsContent)
                    .HasColumnName("SiteReusableParts_Content")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.HasIndex(e => e.SurveyName)
                    .HasName("UNQ_Survey_SurveyName")
                    .IsUnique();

                entity.Property(e => e.SurveyDescription)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SurveyQuestion>(entity =>
            {
                entity.Property(e => e.SurveryQuestionlText2)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyQuestionText)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.SurveyQuestionType)
                    .WithMany(p => p.SurveyQuestion)
                    .HasForeignKey(d => d.SurveyQuestionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyQuestion_SurveyQuestionType");
            });

            modelBuilder.Entity<SurveyQuestionAnswer>(entity =>
            {
                entity.Property(e => e.SurveyQuestionAnswerText)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.SurveyQuestion)
                    .WithMany(p => p.SurveyQuestionAnswer)
                    .HasForeignKey(d => d.SurveyQuestionId)
                    .HasConstraintName("FK_SurveyQuestionAnswer_SurveyQuestion");
            });

            modelBuilder.Entity<SurveyQuestionManager>(entity =>
            {
                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyQuestionManager)
                    .HasForeignKey(d => d.SurveyId)
                    .HasConstraintName("FK_SurveyQuestionManager_Survey");

                entity.HasOne(d => d.SurveyQuestion)
                    .WithMany(p => p.SurveyQuestionManager)
                    .HasForeignKey(d => d.SurveyQuestionId)
                    .HasConstraintName("FK_SurveyQuestionManager_SurveyQuestion");
            });

            modelBuilder.Entity<SurveyQuestionType>(entity =>
            {
                entity.Property(e => e.SurveyQuestionTypeId).ValueGeneratedNever();

                entity.Property(e => e.SurveyQuestionTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SurveySubmission>(entity =>
            {
                entity.Property(e => e.SurveySubmissionClientIp)
                    .HasColumnName("SurveySubmissionClientIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SurveySubmissionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SurveySubmissionEntryPage)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SurveySubmissionEntryReferer)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SurveySubmissionPage)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SurveySubmissionReferer)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveySubmission)
                    .HasForeignKey(d => d.SurveyId)
                    .HasConstraintName("FK_SurveySubmission_Survey");
            });

            modelBuilder.Entity<SurveySubmissionAnswer>(entity =>
            {
                entity.Property(e => e.SurveySubmissionAnswerValue)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.SurveyQuestion)
                    .WithMany(p => p.SurveySubmissionAnswer)
                    .HasForeignKey(d => d.SurveyQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveySubmissionAnswer_SurveyQuestion");

                entity.HasOne(d => d.SurveySubmission)
                    .WithMany(p => p.SurveySubmissionAnswer)
                    .HasForeignKey(d => d.SurveySubmissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveySubmissionAnswer_SurveySubmission");
            });

            modelBuilder.Entity<VSiteContent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSiteContent");

                entity.Property(e => e.SiteContentClear).HasColumnName("SiteContent_Clear");

                entity.Property(e => e.SiteContentContent)
                    .HasColumnName("SiteContent_Content")
                    .IsUnicode(false);

                entity.Property(e => e.SiteContentId).HasColumnName("SiteContent_ID");

                entity.Property(e => e.SiteContentLocation)
                    .HasColumnName("SiteContent_Location")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SiteContentName)
                    .HasColumnName("SiteContent_Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SiteContentPath)
                    .IsRequired()
                    .HasColumnName("SiteContent_Path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SiteContentTitle)
                    .HasColumnName("SiteContent_Title")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SiteReusablePartsName)
                    .HasColumnName("SiteReusableParts_Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WhitePaper>(entity =>
            {
                entity.Property(e => e.WhitePaperDate).HasColumnType("datetime");

                entity.Property(e => e.WhitePaperShortText)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.WhitePaperSurveyName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Basic2')");

                entity.Property(e => e.WhitePaperText).IsUnicode(false);

                entity.Property(e => e.WhitePaperTitle)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
