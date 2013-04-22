﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("LibraryDBModel", "FK_Books_BooksModels", "BooksModels", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Team6A_LibraryManagementSystem.BooksModel), "Books", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Team6A_LibraryManagementSystem.Book), true)]
[assembly: EdmRelationshipAttribute("LibraryDBModel", "FK_LibTrans_Books", "Books", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Team6A_LibraryManagementSystem.Book), "LibTrans", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Team6A_LibraryManagementSystem.LibTran), true)]
[assembly: EdmRelationshipAttribute("LibraryDBModel", "FK_LibTrans_Members", "Members", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Team6A_LibraryManagementSystem.Member), "LibTrans", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Team6A_LibraryManagementSystem.LibTran), true)]

#endregion

namespace Team6A_LibraryManagementSystem
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LibraryDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LibraryDBEntities object using the connection string found in the 'LibraryDBEntities' section of the application configuration file.
        /// </summary>
        public LibraryDBEntities() : base("name=LibraryDBEntities", "LibraryDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibraryDBEntities object.
        /// </summary>
        public LibraryDBEntities(string connectionString) : base(connectionString, "LibraryDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibraryDBEntities object.
        /// </summary>
        public LibraryDBEntities(EntityConnection connection) : base(connection, "LibraryDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Book> Books
        {
            get
            {
                if ((_Books == null))
                {
                    _Books = base.CreateObjectSet<Book>("Books");
                }
                return _Books;
            }
        }
        private ObjectSet<Book> _Books;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<BooksModel> BooksModels
        {
            get
            {
                if ((_BooksModels == null))
                {
                    _BooksModels = base.CreateObjectSet<BooksModel>("BooksModels");
                }
                return _BooksModels;
            }
        }
        private ObjectSet<BooksModel> _BooksModels;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<LibTran> LibTrans
        {
            get
            {
                if ((_LibTrans == null))
                {
                    _LibTrans = base.CreateObjectSet<LibTran>("LibTrans");
                }
                return _LibTrans;
            }
        }
        private ObjectSet<LibTran> _LibTrans;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Member> Members
        {
            get
            {
                if ((_Members == null))
                {
                    _Members = base.CreateObjectSet<Member>("Members");
                }
                return _Members;
            }
        }
        private ObjectSet<Member> _Members;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Books EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBooks(Book book)
        {
            base.AddObject("Books", book);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the BooksModels EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBooksModels(BooksModel booksModel)
        {
            base.AddObject("BooksModels", booksModel);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the LibTrans EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToLibTrans(LibTran libTran)
        {
            base.AddObject("LibTrans", libTran);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Members EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMembers(Member member)
        {
            base.AddObject("Members", member);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryDBModel", Name="Book")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="bookID">Initial value of the BookID property.</param>
        /// <param name="bookModelID">Initial value of the BookModelID property.</param>
        /// <param name="bookStatus">Initial value of the BookStatus property.</param>
        public static Book CreateBook(global::System.Int32 bookID, global::System.Int32 bookModelID, global::System.Int16 bookStatus)
        {
            Book book = new Book();
            book.BookID = bookID;
            book.BookModelID = bookModelID;
            book.BookStatus = bookStatus;
            return book;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BookID
        {
            get
            {
                return _BookID;
            }
            set
            {
                if (_BookID != value)
                {
                    OnBookIDChanging(value);
                    ReportPropertyChanging("BookID");
                    _BookID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("BookID");
                    OnBookIDChanged();
                }
            }
        }
        private global::System.Int32 _BookID;
        partial void OnBookIDChanging(global::System.Int32 value);
        partial void OnBookIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BookModelID
        {
            get
            {
                return _BookModelID;
            }
            set
            {
                OnBookModelIDChanging(value);
                ReportPropertyChanging("BookModelID");
                _BookModelID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BookModelID");
                OnBookModelIDChanged();
            }
        }
        private global::System.Int32 _BookModelID;
        partial void OnBookModelIDChanging(global::System.Int32 value);
        partial void OnBookModelIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 BookStatus
        {
            get
            {
                return _BookStatus;
            }
            set
            {
                OnBookStatusChanging(value);
                ReportPropertyChanging("BookStatus");
                _BookStatus = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BookStatus");
                OnBookStatusChanged();
            }
        }
        private global::System.Int16 _BookStatus;
        partial void OnBookStatusChanging(global::System.Int16 value);
        partial void OnBookStatusChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_Books_BooksModels", "BooksModels")]
        public BooksModel BooksModel
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BooksModel>("LibraryDBModel.FK_Books_BooksModels", "BooksModels").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BooksModel>("LibraryDBModel.FK_Books_BooksModels", "BooksModels").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BooksModel> BooksModelReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BooksModel>("LibraryDBModel.FK_Books_BooksModels", "BooksModels");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BooksModel>("LibraryDBModel.FK_Books_BooksModels", "BooksModels", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_LibTrans_Books", "LibTrans")]
        public EntityCollection<LibTran> LibTrans
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<LibTran>("LibraryDBModel.FK_LibTrans_Books", "LibTrans");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<LibTran>("LibraryDBModel.FK_LibTrans_Books", "LibTrans", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryDBModel", Name="BooksModel")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class BooksModel : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new BooksModel object.
        /// </summary>
        /// <param name="bookModelId">Initial value of the BookModelId property.</param>
        /// <param name="bookTitle">Initial value of the BookTitle property.</param>
        /// <param name="author">Initial value of the Author property.</param>
        /// <param name="bookCategory">Initial value of the BookCategory property.</param>
        public static BooksModel CreateBooksModel(global::System.Int32 bookModelId, global::System.String bookTitle, global::System.String author, global::System.String bookCategory)
        {
            BooksModel booksModel = new BooksModel();
            booksModel.BookModelId = bookModelId;
            booksModel.BookTitle = bookTitle;
            booksModel.Author = author;
            booksModel.BookCategory = bookCategory;
            return booksModel;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BookModelId
        {
            get
            {
                return _BookModelId;
            }
            set
            {
                if (_BookModelId != value)
                {
                    OnBookModelIdChanging(value);
                    ReportPropertyChanging("BookModelId");
                    _BookModelId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("BookModelId");
                    OnBookModelIdChanged();
                }
            }
        }
        private global::System.Int32 _BookModelId;
        partial void OnBookModelIdChanging(global::System.Int32 value);
        partial void OnBookModelIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BookTitle
        {
            get
            {
                return _BookTitle;
            }
            set
            {
                OnBookTitleChanging(value);
                ReportPropertyChanging("BookTitle");
                _BookTitle = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("BookTitle");
                OnBookTitleChanged();
            }
        }
        private global::System.String _BookTitle;
        partial void OnBookTitleChanging(global::System.String value);
        partial void OnBookTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String BookDescription
        {
            get
            {
                return _BookDescription;
            }
            set
            {
                OnBookDescriptionChanging(value);
                ReportPropertyChanging("BookDescription");
                _BookDescription = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("BookDescription");
                OnBookDescriptionChanged();
            }
        }
        private global::System.String _BookDescription;
        partial void OnBookDescriptionChanging(global::System.String value);
        partial void OnBookDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Author
        {
            get
            {
                return _Author;
            }
            set
            {
                OnAuthorChanging(value);
                ReportPropertyChanging("Author");
                _Author = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Author");
                OnAuthorChanged();
            }
        }
        private global::System.String _Author;
        partial void OnAuthorChanging(global::System.String value);
        partial void OnAuthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PublisherName
        {
            get
            {
                return _PublisherName;
            }
            set
            {
                OnPublisherNameChanging(value);
                ReportPropertyChanging("PublisherName");
                _PublisherName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PublisherName");
                OnPublisherNameChanged();
            }
        }
        private global::System.String _PublisherName;
        partial void OnPublisherNameChanging(global::System.String value);
        partial void OnPublisherNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> PublishDate
        {
            get
            {
                return _PublishDate;
            }
            set
            {
                OnPublishDateChanging(value);
                ReportPropertyChanging("PublishDate");
                _PublishDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PublishDate");
                OnPublishDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _PublishDate;
        partial void OnPublishDateChanging(Nullable<global::System.DateTime> value);
        partial void OnPublishDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BookCategory
        {
            get
            {
                return _BookCategory;
            }
            set
            {
                OnBookCategoryChanging(value);
                ReportPropertyChanging("BookCategory");
                _BookCategory = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("BookCategory");
                OnBookCategoryChanged();
            }
        }
        private global::System.String _BookCategory;
        partial void OnBookCategoryChanging(global::System.String value);
        partial void OnBookCategoryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> MaxAvailableDayToRent
        {
            get
            {
                return _MaxAvailableDayToRent;
            }
            set
            {
                OnMaxAvailableDayToRentChanging(value);
                ReportPropertyChanging("MaxAvailableDayToRent");
                _MaxAvailableDayToRent = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MaxAvailableDayToRent");
                OnMaxAvailableDayToRentChanged();
            }
        }
        private Nullable<global::System.Int16> _MaxAvailableDayToRent;
        partial void OnMaxAvailableDayToRentChanging(Nullable<global::System.Int16> value);
        partial void OnMaxAvailableDayToRentChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_Books_BooksModels", "Books")]
        public EntityCollection<Book> Books
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Book>("LibraryDBModel.FK_Books_BooksModels", "Books");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Book>("LibraryDBModel.FK_Books_BooksModels", "Books", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryDBModel", Name="LibTran")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class LibTran : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new LibTran object.
        /// </summary>
        /// <param name="transactionID">Initial value of the TransactionID property.</param>
        /// <param name="bookID">Initial value of the BookID property.</param>
        /// <param name="memberID">Initial value of the MemberID property.</param>
        /// <param name="lendDate">Initial value of the LendDate property.</param>
        /// <param name="returnDate">Initial value of the ReturnDate property.</param>
        /// <param name="chargeAmount">Initial value of the ChargeAmount property.</param>
        public static LibTran CreateLibTran(global::System.Int32 transactionID, global::System.Int32 bookID, global::System.Int32 memberID, global::System.DateTime lendDate, global::System.DateTime returnDate, global::System.Decimal chargeAmount)
        {
            LibTran libTran = new LibTran();
            libTran.TransactionID = transactionID;
            libTran.BookID = bookID;
            libTran.MemberID = memberID;
            libTran.LendDate = lendDate;
            libTran.ReturnDate = returnDate;
            libTran.ChargeAmount = chargeAmount;
            return libTran;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TransactionID
        {
            get
            {
                return _TransactionID;
            }
            set
            {
                if (_TransactionID != value)
                {
                    OnTransactionIDChanging(value);
                    ReportPropertyChanging("TransactionID");
                    _TransactionID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("TransactionID");
                    OnTransactionIDChanged();
                }
            }
        }
        private global::System.Int32 _TransactionID;
        partial void OnTransactionIDChanging(global::System.Int32 value);
        partial void OnTransactionIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BookID
        {
            get
            {
                return _BookID;
            }
            set
            {
                OnBookIDChanging(value);
                ReportPropertyChanging("BookID");
                _BookID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BookID");
                OnBookIDChanged();
            }
        }
        private global::System.Int32 _BookID;
        partial void OnBookIDChanging(global::System.Int32 value);
        partial void OnBookIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MemberID
        {
            get
            {
                return _MemberID;
            }
            set
            {
                OnMemberIDChanging(value);
                ReportPropertyChanging("MemberID");
                _MemberID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MemberID");
                OnMemberIDChanged();
            }
        }
        private global::System.Int32 _MemberID;
        partial void OnMemberIDChanging(global::System.Int32 value);
        partial void OnMemberIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LendDate
        {
            get
            {
                return _LendDate;
            }
            set
            {
                OnLendDateChanging(value);
                ReportPropertyChanging("LendDate");
                _LendDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LendDate");
                OnLendDateChanged();
            }
        }
        private global::System.DateTime _LendDate;
        partial void OnLendDateChanging(global::System.DateTime value);
        partial void OnLendDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ReturnDate
        {
            get
            {
                return _ReturnDate;
            }
            set
            {
                OnReturnDateChanging(value);
                ReportPropertyChanging("ReturnDate");
                _ReturnDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ReturnDate");
                OnReturnDateChanged();
            }
        }
        private global::System.DateTime _ReturnDate;
        partial void OnReturnDateChanging(global::System.DateTime value);
        partial void OnReturnDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal ChargeAmount
        {
            get
            {
                return _ChargeAmount;
            }
            set
            {
                OnChargeAmountChanging(value);
                ReportPropertyChanging("ChargeAmount");
                _ChargeAmount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ChargeAmount");
                OnChargeAmountChanged();
            }
        }
        private global::System.Decimal _ChargeAmount;
        partial void OnChargeAmountChanging(global::System.Decimal value);
        partial void OnChargeAmountChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_LibTrans_Books", "Books")]
        public Book Book
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("LibraryDBModel.FK_LibTrans_Books", "Books").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("LibraryDBModel.FK_LibTrans_Books", "Books").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Book> BookReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("LibraryDBModel.FK_LibTrans_Books", "Books");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Book>("LibraryDBModel.FK_LibTrans_Books", "Books", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_LibTrans_Members", "Members")]
        public Member Member
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("LibraryDBModel.FK_LibTrans_Members", "Members").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("LibraryDBModel.FK_LibTrans_Members", "Members").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Member> MemberReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("LibraryDBModel.FK_LibTrans_Members", "Members");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Member>("LibraryDBModel.FK_LibTrans_Members", "Members", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryDBModel", Name="Member")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Member : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Member object.
        /// </summary>
        /// <param name="memberID">Initial value of the MemberID property.</param>
        /// <param name="memberName">Initial value of the MemberName property.</param>
        /// <param name="phoneNumber">Initial value of the PhoneNumber property.</param>
        /// <param name="nIRC">Initial value of the NIRC property.</param>
        public static Member CreateMember(global::System.Int32 memberID, global::System.String memberName, global::System.String phoneNumber, global::System.String nIRC)
        {
            Member member = new Member();
            member.MemberID = memberID;
            member.MemberName = memberName;
            member.PhoneNumber = phoneNumber;
            member.NIRC = nIRC;
            return member;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MemberID
        {
            get
            {
                return _MemberID;
            }
            set
            {
                if (_MemberID != value)
                {
                    OnMemberIDChanging(value);
                    ReportPropertyChanging("MemberID");
                    _MemberID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("MemberID");
                    OnMemberIDChanged();
                }
            }
        }
        private global::System.Int32 _MemberID;
        partial void OnMemberIDChanging(global::System.Int32 value);
        partial void OnMemberIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MemberName
        {
            get
            {
                return _MemberName;
            }
            set
            {
                OnMemberNameChanging(value);
                ReportPropertyChanging("MemberName");
                _MemberName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MemberName");
                OnMemberNameChanged();
            }
        }
        private global::System.String _MemberName;
        partial void OnMemberNameChanging(global::System.String value);
        partial void OnMemberNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                OnPhoneNumberChanging(value);
                ReportPropertyChanging("PhoneNumber");
                _PhoneNumber = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PhoneNumber");
                OnPhoneNumberChanged();
            }
        }
        private global::System.String _PhoneNumber;
        partial void OnPhoneNumberChanging(global::System.String value);
        partial void OnPhoneNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NIRC
        {
            get
            {
                return _NIRC;
            }
            set
            {
                OnNIRCChanging(value);
                ReportPropertyChanging("NIRC");
                _NIRC = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NIRC");
                OnNIRCChanged();
            }
        }
        private global::System.String _NIRC;
        partial void OnNIRCChanging(global::System.String value);
        partial void OnNIRCChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryDBModel", "FK_LibTrans_Members", "LibTrans")]
        public EntityCollection<LibTran> LibTrans
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<LibTran>("LibraryDBModel.FK_LibTrans_Members", "LibTrans");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<LibTran>("LibraryDBModel.FK_LibTrans_Members", "LibTrans", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
