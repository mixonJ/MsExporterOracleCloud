using System;
using System.Collections.Generic;
using OracleCloud;
using OracleCloud.DTOs;
using OracleCloud.Interfaces;

namespace Tests {
    public class OracleRepositoryMock : IOracleRepository {
        private int companyId;
        public int CompanyId {
            get {
                return companyId;
            }

            set {
                companyId = value;
            }
        }

        public void Dispose() {
            this.Dispose();
        }

        public object GetCompanies(Company c, int runId) {
            return new {
                c.CompanyID
            };
        }

        

        public object GetCompanyBidStatuses(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new CompanyBidStatus() {
                    CompanyBidStatusID = 1,
                    CompanyBidStatusName = "UnitTest GetDeletedItems CompanyBidStatus.CompanyBidStatusName",
                    CompanyID = id,
                    SystemCode = "UnitTest GetDeletedItems CompanyBidStatus.SystemCode",
                    MSStatusID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new CompanyBidStatus() {
                    CompanyBidStatusID = 1,
                    CompanyBidStatusName = "UnitTest GetDeletedItems CompanyBidStatus.CompanyBidStatusName",
                    CompanyID = id,
                    SystemCode = "UnitTest GetDeletedItems CompanyBidStatus.SystemCode",
                    MSStatusID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new CompanyBidStatus() {
                    CompanyBidStatusID = 2,
                    CompanyBidStatusName = "UnitTest GetDeletedItems CompanyBidStatus.CompanyBidStatusName",
                    CompanyID = id,
                    SystemCode = "UnitTest GetDeletedItems CompanyBidStatus.SystemCode",
                    MSStatusID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public Company GetCompanyInfo(int companyId) {
            return new Company(){
                CompanyID = companyId,
                SourceSystem = new SourceSystem(){
                    SourceSystemID = 1,
                    SystemName = "UnitTest GetCompanyInfo SourceSystem.SystemName",
                    MsModificationDate = DateTime.Now
                }
            };
        }

        public object GetCompanyOrderStatuses(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new CompanyOrderStatus() {
                    CompanyOrderStatusID = 1,
                    CompanyOrderStatusName = "UnitTest GetCompanyOrderStatuses CompanyOrderStatus.CompanyOrderStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new CompanyOrderStatus() {
                    CompanyOrderStatusID = 1,
                    CompanyOrderStatusName = "UnitTest GetCompanyOrderStatuses CompanyOrderStatus.CompanyOrderStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new CompanyOrderStatus() {
                    CompanyOrderStatusID = 2,
                    CompanyOrderStatusName = "UnitTest GetCompanyOrderStatuses CompanyOrderStatus.CompanyOrderStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetCompanyProjectProductStatuses(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new CompanyProjectProductStatus() {
                    CompanyProjectProductStatusID = 1,
                    CompanyProjectProductStatusName = "UnitTest GetCompanyOrderStatuses CompanyProjectProductStatus.CompanyProjectProductStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new CompanyProjectProductStatus() {
                    CompanyProjectProductStatusID = 1,
                    CompanyProjectProductStatusName = "UnitTest GetCompanyOrderStatuses CompanyProjectProductStatus.CompanyProjectProductStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new CompanyProjectProductStatus() {
                    CompanyProjectProductStatusID = 2,
                    CompanyProjectProductStatusName = "UnitTest GetCompanyOrderStatuses CompanyProjectProductStatus.CompanyProjectProductStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetCompanyProjectStatuses(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new CompanyProjectStatus() {
                    CompanyProjectStatusID = 1,
                    CompanyProjectStatusName = "UnitTest GetCompanyOrderStatuses CompanyProjectStatus.CompanyProjectStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new CompanyProjectStatus() {
                    CompanyProjectStatusID = 1,
                    CompanyProjectStatusName = "UnitTest GetCompanyOrderStatuses CompanyProjectStatus.CompanyProjectStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new CompanyProjectStatus() {
                    CompanyProjectStatusID = 2,
                    CompanyProjectStatusName = "UnitTest GetCompanyOrderStatuses CompanyProjectStatus.CompanyProjectStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetCompanyQuoteStatuses(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new CompanyQuoteStatus() {
                    CompanyQuoteStatusID = 1,
                    CompanyQuoteStatusName = "UnitTest GetCompanyOrderStatuses CompanyQuoteStatus.CompanyQuoteStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new CompanyQuoteStatus() {
                    CompanyQuoteStatusID = 1,
                    CompanyQuoteStatusName = "UnitTest GetCompanyOrderStatuses CompanyQuoteStatus.CompanyQuoteStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new CompanyQuoteStatus() {
                    CompanyQuoteStatusID = 2,
                    CompanyQuoteStatusName = "UnitTest GetCompanyOrderStatuses CompanyQuoteStatus.CompanyQuoteStatusName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetCompanyUsers(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new CompanyUser() {
                    CompanyUserID = 1,
                    CompanyID = id,
                    UserID = 1,
                    SalesmanCode = "UnitTest GetCompanyOrderStatuses CompanyUser.SalesmanCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new CompanyUser() {
                    CompanyUserID = 1,
                    CompanyID = id,
                    UserID = 1,
                    SalesmanCode = "UnitTest GetCompanyOrderStatuses CompanyUser.SalesmanCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new CompanyUser() {
                    CompanyUserID = 2,
                    CompanyID = id,
                    UserID = 1,
                    SalesmanCode = "UnitTest GetCompanyOrderStatuses CompanyUser.SalesmanCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetCompetitorPlants(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new CompetitorPlant() {
                    CompetitorPlantID = 1,
                    CompetitorID = 1,
                    PlantName = "UnitTest GetCompanyOrderStatuses CompetitorPlant.PlantName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive_Flag = false,
                    PlantCost = 0,
                    DeliveryCost = 0,
                    MaterialCost = 0,
                    SGACost = 0,
                    Address1 = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Address1",
                    Address2 = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Address2",
                    City = "UnitTest GetCompanyOrderStatuses CompetitorPlant.City",
                    State = "UnitTest GetCompanyOrderStatuses CompetitorPlant.State",
                    Zip = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Zip",
                    Longitude = 0,
                    Latitude = 0,
                    LineOfBusinessID = 1,
                    DivisionID = 1,
                    Country = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new CompetitorPlant() {
                    CompetitorPlantID = 1,
                    CompetitorID = 1,
                    PlantName = "UnitTest GetCompanyOrderStatuses CompetitorPlant.PlantName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive_Flag = false,
                    PlantCost = 0,
                    DeliveryCost = 0,
                    MaterialCost = 0,
                    SGACost = 0,
                    Address1 = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Address1",
                    Address2 = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Address2",
                    City = "UnitTest GetCompanyOrderStatuses CompetitorPlant.City",
                    State = "UnitTest GetCompanyOrderStatuses CompetitorPlant.State",
                    Zip = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Zip",
                    Longitude = 0,
                    Latitude = 0,
                    LineOfBusinessID = 1,
                    DivisionID = 1,
                    Country = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new CompetitorPlant() {
                    CompetitorPlantID = 2,
                    CompetitorID = 1,
                    PlantName = "UnitTest GetCompanyOrderStatuses CompetitorPlant.PlantName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive_Flag = false,
                    PlantCost = 0,
                    DeliveryCost = 0,
                    MaterialCost = 0,
                    SGACost = 0,
                    Address1 = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Address1",
                    Address2 = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Address2",
                    City = "UnitTest GetCompanyOrderStatuses CompetitorPlant.City",
                    State = "UnitTest GetCompanyOrderStatuses CompetitorPlant.State",
                    Zip = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Zip",
                    Longitude = 0,
                    Latitude = 0,
                    LineOfBusinessID = 1,
                    DivisionID = 1,
                    Country = "UnitTest GetCompanyOrderStatuses CompetitorPlant.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetCompetitors(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Competitor() {
                    CompetitorID = 1,
                    CompanyID = id,
                    CompetitorName = "UnitTest GetCompanyOrderStatuses Competitor.CompetitorName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive = false,
                    UserID = 1,
                    Address1 = "UnitTest GetCompanyOrderStatuses Competitor.Address1",
                    Address2 = "UnitTest GetCompanyOrderStatuses Competitor.Address2",
                    City = "UnitTest GetCompanyOrderStatuses Competitor.City",
                    State = "UnitTest GetCompanyOrderStatuses Competitor.State",
                    Zip = "UnitTest GetCompanyOrderStatuses Competitor.Zip",
                    Longitude = 0,
                    Latitude = 0,
                    Country = "UnitTest GetCompanyOrderStatuses Competitor.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Competitor() {
                    CompetitorID = 1,
                    CompanyID = id,
                    CompetitorName = "UnitTest GetCompanyOrderStatuses Competitor.CompetitorName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive = false,
                    UserID = 1,
                    Address1 = "UnitTest GetCompanyOrderStatuses Competitor.Address1",
                    Address2 = "UnitTest GetCompanyOrderStatuses Competitor.Address2",
                    City = "UnitTest GetCompanyOrderStatuses Competitor.City",
                    State = "UnitTest GetCompanyOrderStatuses Competitor.State",
                    Zip = "UnitTest GetCompanyOrderStatuses Competitor.Zip",
                    Longitude = 0,
                    Latitude = 0,
                    Country = "UnitTest GetCompanyOrderStatuses Competitor.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Competitor() {
                    CompetitorID = 2,
                    CompanyID = id,
                    CompetitorName = "UnitTest GetCompanyOrderStatuses Competitor.CompetitorName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive = false,
                    UserID = 1,
                    Address1 = "UnitTest GetCompanyOrderStatuses Competitor.Address1",
                    Address2 = "UnitTest GetCompanyOrderStatuses Competitor.Address2",
                    City = "UnitTest GetCompanyOrderStatuses Competitor.City",
                    State = "UnitTest GetCompanyOrderStatuses Competitor.State",
                    Zip = "UnitTest GetCompanyOrderStatuses Competitor.Zip",
                    Longitude = 0,
                    Latitude = 0,
                    Country = "UnitTest GetCompanyOrderStatuses Competitor.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetContactNotes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ContactNote() {
                    ContactNoteID = 1,
                    ContactID = 1,
                    Note = "UnitTest GetCompanyOrderStatuses ContactNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    Subject = "UnitTest GetCompanyOrderStatuses ContactNote.Subject",
                    Source = "UnitTest GetCompanyOrderStatuses ContactNote.Source",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ContactNote() {
                    ContactNoteID = 1,
                    ContactID = 1,
                    Note = "UnitTest GetCompanyOrderStatuses ContactNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    Subject = "UnitTest GetCompanyOrderStatuses ContactNote.Subject",
                    Source = "UnitTest GetCompanyOrderStatuses ContactNote.Source",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ContactNote() {
                    ContactNoteID = 2,
                    ContactID = 1,
                    Note = "UnitTest GetCompanyOrderStatuses ContactNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    Subject = "UnitTest GetCompanyOrderStatuses ContactNote.Subject",
                    Source = "UnitTest GetCompanyOrderStatuses ContactNote.Source",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetContacts(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Contact() {
                    ContactID = 1,
                    Private = false,
                    OwnerID = 1,
                    FirstName = "UnitTest GetCompanyOrderStatuses Contact.FirstName",
                    LastName = "UnitTest GetCompanyOrderStatuses Contact.LastName",
                    Name = "UnitTest GetCompanyOrderStatuses Contact.Name",
                    ProspectID = 1,
                    Email = "UnitTest GetCompanyOrderStatuses Contact.Email",
                    MobilePhone = "UnitTest GetCompanyOrderStatuses Contact.MobilePhone",
                    Phone = "UnitTest GetCompanyOrderStatuses Contact.Phone",
                    Fax = "UnitTest GetCompanyOrderStatuses Contact.Fax",
                    Address = "UnitTest GetCompanyOrderStatuses Contact.Address",
                    FullName = "UnitTest GetCompanyOrderStatuses Contact.FullName",
                    Title = "UnitTest GetCompanyOrderStatuses Contact.Title",
                    StartingYearatCompany = "UnitTest GetCompanyOrderStatuses Contact.StartingYearatCompany",
                    Department = "UnitTest GetCompanyOrderStatuses Contact.Department",
                    Address2 = "UnitTest GetCompanyOrderStatuses Contact.Address2",
                    City = "UnitTest GetCompanyOrderStatuses Contact.City",
                    State = "UnitTest GetCompanyOrderStatuses Contact.State",
                    Zip = "UnitTest GetCompanyOrderStatuses Contact.Zip",
                    Salutation = "UnitTest GetCompanyOrderStatuses Contact.Salutation",
                    Notes = "UnitTest GetCompanyOrderStatuses Contact.Notes",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Country = "UnitTest GetCompanyOrderStatuses Contact.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Contact() {
                    ContactID = 1,
                    Private = false,
                    OwnerID = 1,
                    FirstName = "UnitTest GetCompanyOrderStatuses Contact.FirstName",
                    LastName = "UnitTest GetCompanyOrderStatuses Contact.LastName",
                    Name = "UnitTest GetCompanyOrderStatuses Contact.Name",
                    ProspectID = 1,
                    Email = "UnitTest GetCompanyOrderStatuses Contact.Email",
                    MobilePhone = "UnitTest GetCompanyOrderStatuses Contact.MobilePhone",
                    Phone = "UnitTest GetCompanyOrderStatuses Contact.Phone",
                    Fax = "UnitTest GetCompanyOrderStatuses Contact.Fax",
                    Address = "UnitTest GetCompanyOrderStatuses Contact.Address",
                    FullName = "UnitTest GetCompanyOrderStatuses Contact.FullName",
                    Title = "UnitTest GetCompanyOrderStatuses Contact.Title",
                    StartingYearatCompany = "UnitTest GetCompanyOrderStatuses Contact.StartingYearatCompany",
                    Department = "UnitTest GetCompanyOrderStatuses Contact.Department",
                    Address2 = "UnitTest GetCompanyOrderStatuses Contact.Address2",
                    City = "UnitTest GetCompanyOrderStatuses Contact.City",
                    State = "UnitTest GetCompanyOrderStatuses Contact.State",
                    Zip = "UnitTest GetCompanyOrderStatuses Contact.Zip",
                    Salutation = "UnitTest GetCompanyOrderStatuses Contact.Salutation",
                    Notes = "UnitTest GetCompanyOrderStatuses Contact.Notes",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Country = "UnitTest GetCompanyOrderStatuses Contact.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Contact() {
                    ContactID = 2,
                    Private = false,
                    OwnerID = 1,
                    FirstName = "UnitTest GetCompanyOrderStatuses Contact.FirstName",
                    LastName = "UnitTest GetCompanyOrderStatuses Contact.LastName",
                    Name = "UnitTest GetCompanyOrderStatuses Contact.Name",
                    ProspectID = 1,
                    Email = "UnitTest GetCompanyOrderStatuses Contact.Email",
                    MobilePhone = "UnitTest GetCompanyOrderStatuses Contact.MobilePhone",
                    Phone = "UnitTest GetCompanyOrderStatuses Contact.Phone",
                    Fax = "UnitTest GetCompanyOrderStatuses Contact.Fax",
                    Address = "UnitTest GetCompanyOrderStatuses Contact.Address",
                    FullName = "UnitTest GetCompanyOrderStatuses Contact.FullName",
                    Title = "UnitTest GetCompanyOrderStatuses Contact.Title",
                    StartingYearatCompany = "UnitTest GetCompanyOrderStatuses Contact.StartingYearatCompany",
                    Department = "UnitTest GetCompanyOrderStatuses Contact.Department",
                    Address2 = "UnitTest GetCompanyOrderStatuses Contact.Address2",
                    City = "UnitTest GetCompanyOrderStatuses Contact.City",
                    State = "UnitTest GetCompanyOrderStatuses Contact.State",
                    Zip = "UnitTest GetCompanyOrderStatuses Contact.Zip",
                    Salutation = "UnitTest GetCompanyOrderStatuses Contact.Salutation",
                    Notes = "UnitTest GetCompanyOrderStatuses Contact.Notes",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Country = "UnitTest GetCompanyOrderStatuses Contact.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetCreditStatuses(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new CreditStatus() {
                    CreditStatusID = 1,
                    CompanyID = id,
                    Code = "UnitTest GetCompanyOrderStatuses CreditStatus.Code",
                    Description = "UnitTest GetCompanyOrderStatuses CreditStatus.Description",
                    ColorCode = "UnitTest GetCompanyOrderStatuses CreditStatus.ColorCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new CreditStatus() {
                    CreditStatusID = 1,
                    CompanyID = id,
                    Code = "UnitTest GetCompanyOrderStatuses CreditStatus.Code",
                    Description = "UnitTest GetCompanyOrderStatuses CreditStatus.Description",
                    ColorCode = "UnitTest GetCompanyOrderStatuses CreditStatus.ColorCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new CreditStatus() {
                    CreditStatusID = 2,
                    CompanyID = id,
                    Code = "UnitTest GetCompanyOrderStatuses CreditStatus.Code",
                    Description = "UnitTest GetCompanyOrderStatuses CreditStatus.Description",
                    ColorCode = "UnitTest GetCompanyOrderStatuses CreditStatus.ColorCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetCustomerEvents(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new CustomerEvent() {
                    CustomerEventID = 1,
                    Private = false,
                    OwnerID = 1,
                    EventTypeID = 1,
                    EventStartDate = DateTime.Now,
                    EventEndDate = DateTime.Now,
                    CompletedDate = DateTime.Now,
                    Description = "UnitTest GetCompanyOrderStatuses CustomerEvent.Description",
                    ContactID = 1,
                    UserID = 1,
                    EventFrequencyID = 1,
                    ProjectID = 1,
                    MasterEventID = 1,
                    EventStatusID = 1,
                    Subject = "UnitTest GetCompanyOrderStatuses CustomerEvent.Subject",
                    ProspectID = 1,
                    RecurrenceEndDate = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new CustomerEvent() {
                    CustomerEventID = 1,
                    Private = false,
                    OwnerID = 1,
                    EventTypeID = 1,
                    EventStartDate = DateTime.Now,
                    EventEndDate = DateTime.Now,
                    CompletedDate = DateTime.Now,
                    Description = "UnitTest GetCompanyOrderStatuses CustomerEvent.Description",
                    ContactID = 1,
                    UserID = 1,
                    EventFrequencyID = 1,
                    ProjectID = 1,
                    MasterEventID = 1,
                    EventStatusID = 1,
                    Subject = "UnitTest GetCompanyOrderStatuses CustomerEvent.Subject",
                    ProspectID = 1,
                    RecurrenceEndDate = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new CustomerEvent() {
                    CustomerEventID = 2,
                    Private = false,
                    OwnerID = 1,
                    EventTypeID = 1,
                    EventStartDate = DateTime.Now,
                    EventEndDate = DateTime.Now,
                    CompletedDate = DateTime.Now,
                    Description = "UnitTest GetCompanyOrderStatuses CustomerEvent.Description",
                    ContactID = 1,
                    UserID = 1,
                    EventFrequencyID = 1,
                    ProjectID = 1,
                    MasterEventID = 1,
                    EventStatusID = 1,
                    Subject = "UnitTest GetCompanyOrderStatuses CustomerEvent.Subject",
                    ProspectID = 1,
                    RecurrenceEndDate = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
            
        }

        public object GetCustomerEventTypes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new CustomerEventType() {
                    EventTypeID = 1,
                    CompanyID = id,
                    EventType = "UnitTest GetCompanyOrderStatuses CustomerEventType.EventType",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new CustomerEventType() {
                    EventTypeID = 1,
                    CompanyID = id,
                    EventType = "UnitTest GetCompanyOrderStatuses CustomerEventType.EventType",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new CustomerEventType() {
                    EventTypeID = 2,
                    CompanyID = id,
                    EventType = "UnitTest GetCompanyOrderStatuses CustomerEventType.EventType",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetCustomerTypes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new CustomerType() {
                    CustomerTypeID = 1,
                    CompanyID = id,
                    CustomerTypeName = "UnitTest GetCompanyOrderStatuses CustomerType.CustomerTypeName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new CustomerType() {
                    CustomerTypeID = 1,
                    CompanyID = id,
                    CustomerTypeName = "UnitTest GetCompanyOrderStatuses CustomerType.CustomerTypeName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new CustomerType() {
                    CustomerTypeID = 2,
                    CompanyID = id,
                    CustomerTypeName = "UnitTest GetCompanyOrderStatuses CustomerType.CustomerTypeName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetDeletedItems(int id, DateTime startDate, DateTime endDate, int runId) {
            var retVal = new List<object>();

            var obj = new DeletedItem(){
                CompanyID = id,
                DateDeleted = startDate,
                KeyID = 1,
                TableName = "UnitTest GetDeletedItems DeletedItem.TableName"
            };
            retVal.Add(obj);
            return retVal.ToArray();
        }


        public object GetDeviationTypes(DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new DeviationType() {
                    DeviationTypeID = 1,
                    DeviationTypeName = "UnitTest GetDeletedItems DeletedItem.TableName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new DeviationType() {
                    DeviationTypeID = 1,
                    DeviationTypeName = "UnitTest GetDeletedItems DeletedItem.TableName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new DeviationType() {
                    DeviationTypeID = 2,
                    DeviationTypeName = "UnitTest GetDeletedItems DeletedItem.TableName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetDivisions(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Division() {
                    DivisionID = 1,
                    DivisionName = "UnitTest GetDeletedItems Division.DivisionName",
                    CompanyID = id,
                    Address1 = "UnitTest GetDeletedItems Division.Address1",
                    Address2 = "UnitTest GetDeletedItems Division.Address2",
                    City = "UnitTest GetDeletedItems Division.City",
                    ST = "UnitTest GetDeletedItems Division.ST",
                    Zip = "UnitTest GetDeletedItems Division.Zip",
                    Country = "UnitTest GetDeletedItems Division.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Division() {
                    DivisionID = 1,
                    DivisionName = "UnitTest GetDeletedItems Division.DivisionName",
                    CompanyID = id,
                    Address1 = "UnitTest GetDeletedItems Division.Address1",
                    Address2 = "UnitTest GetDeletedItems Division.Address2",
                    City = "UnitTest GetDeletedItems Division.City",
                    ST = "UnitTest GetDeletedItems Division.ST",
                    Zip = "UnitTest GetDeletedItems Division.Zip",
                    Country = "UnitTest GetDeletedItems Division.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Division() {
                    DivisionID = 2,
                    DivisionName = "UnitTest GetDeletedItems Division.DivisionName",
                    CompanyID = id,
                    Address1 = "UnitTest GetDeletedItems Division.Address1",
                    Address2 = "UnitTest GetDeletedItems Division.Address2",
                    City = "UnitTest GetDeletedItems Division.City",
                    ST = "UnitTest GetDeletedItems Division.ST",
                    Zip = "UnitTest GetDeletedItems Division.Zip",
                    Country = "UnitTest GetDeletedItems Division.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetEventFrequency(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new EventFrequency() {
                    EventFrequencyID = 1,
                    CompanyID = id,
                    EventFrequency1 = "UnitTest GetDeletedItems EventFrequency.EventFrequency1",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new EventFrequency() {
                    EventFrequencyID = 1,
                    CompanyID = id,
                    EventFrequency1 = "UnitTest GetDeletedItems EventFrequency.EventFrequency1",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new EventFrequency() {
                    EventFrequencyID = 2,
                    CompanyID = id,
                    EventFrequency1 = "UnitTest GetDeletedItems EventFrequency.EventFrequency1",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetEventStatuses(DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new EventStatu() {
                    EventStatusID = 1,
                    EventStatus = "UnitTest GetDeletedItems EventStatu.EventStatus",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new EventStatu() {
                    EventStatusID = 1,
                    EventStatus = "UnitTest GetDeletedItems EventStatu.EventStatus",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new EventStatu() {
                    EventStatusID = 2,
                    EventStatus = "UnitTest GetDeletedItems EventStatu.EventStatus",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            
            return retVal.ToArray();
        }

        public object GetLinesOfBusiness(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new LinesOfBusiness() {
                    LineOfBusinessID = 1,
                    Name = "UnitTest GetDeletedItems LinesOfBusiness.Name",
                    CompanyID = id,
                    LineOfBusinessCode = "UnitTest GetDeletedItems LinesOfBusiness.LineOfBusinessCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new LinesOfBusiness() {
                    LineOfBusinessID = 1,
                    Name = "UnitTest GetDeletedItems LinesOfBusiness.Name",
                    CompanyID = id,
                    LineOfBusinessCode = "UnitTest GetDeletedItems LinesOfBusiness.LineOfBusinessCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new LinesOfBusiness() {
                    LineOfBusinessID = 2,
                    Name = "UnitTest GetDeletedItems LinesOfBusiness.Name",
                    CompanyID = id,
                    LineOfBusinessCode = "UnitTest GetDeletedItems LinesOfBusiness.LineOfBusinessCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetLogins(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Login() {
                    LoginID = 1,
                    UserID = 1,
                    LoginDate = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Login() {
                    LoginID = 1,
                    UserID = 1,
                    LoginDate = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Login() {
                    LoginID = 2,
                    UserID = 1,
                    LoginDate = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetLostReasons(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new LostReason() {
                    LostReasonID = 1,
                    CompanyID = id,
                    LostReason1 = "UnitTest GetDeletedItems LostReason.LostReason1",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new LostReason() {
                    LostReasonID = 1,
                    CompanyID = id,
                    LostReason1 = "UnitTest GetDeletedItems LostReason.LostReason1",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new LostReason() {
                    LostReasonID = 2,
                    CompanyID = id,
                    LostReason1 = "UnitTest GetDeletedItems LostReason.LostReason1",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetManagersSalesmen(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ManagersSalesman() {
                    ManagerUserID = 1,
                    ManagerID = 1,
                    SalesmanID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ManagersSalesman() {
                    ManagerUserID = 1,
                    ManagerID = 1,
                    SalesmanID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ManagersSalesman() {
                    ManagerUserID = 2,
                    ManagerID = 1,
                    SalesmanID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public int GetNextRunId() {
            return 1;
        }

        public object GetOrderDetails(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new OrderDetail() {
                    OrderDetailID = 1,
                    OrderID = 1,
                    ProductID = 1,
                    Quantity = 1,
                    UnitPrice = 1,
                    Mix = true,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new OrderDetail() {
                    OrderDetailID = 1,
                    OrderID = 1,
                    ProductID = 1,
                    Quantity = 1,
                    UnitPrice = 1,
                    Mix = true,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new OrderDetail() {
                    OrderDetailID = 2,
                    OrderID = 1,
                    ProductID = 1,
                    Quantity = 1,
                    UnitPrice = 1,
                    Mix = true,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetOrders(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Order() {
                    OrderID = 1,
                    CompanyID = id,
                    ProjectID = 1,
                    year = DateTime.Now.Year,
                    month = DateTime.Now.Month,
                    YardsActual = 1,
                    MaterialCost = 1,
                    DollarsActual = 1,
                    OrderDate = DateTime.Now,
                    ShipDate = DateTime.Now,
                    YardsTicketed = 1,
                    OnJobTime = DateTime.Now,
                    LocationID = 1,
                    ProspectID = 1,
                    DispatchOrderID = 1,
                    DispatchOrderNumber = "UnitTest GetDeletedItems Order.DispatchOrderNumber",
                    SalesmanCode = "UnitTest GetDeletedItems Order.SalesmanCode",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Order() {
                    OrderID = 1,
                    CompanyID = id,
                    ProjectID = 1,
                    year = DateTime.Now.Year,
                    month = DateTime.Now.Month,
                    YardsActual = 1,
                    MaterialCost = 1,
                    DollarsActual = 1,
                    OrderDate = DateTime.Now,
                    ShipDate = DateTime.Now,
                    YardsTicketed = 1,
                    OnJobTime = DateTime.Now,
                    LocationID = 1,
                    ProspectID = 1,
                    DispatchOrderID = 1,
                    DispatchOrderNumber = "UnitTest GetDeletedItems Order.DispatchOrderNumber",
                    SalesmanCode = "UnitTest GetDeletedItems Order.SalesmanCode",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Order() {
                    OrderID = 2,
                    CompanyID = id,
                    ProjectID = 1,
                    year = DateTime.Now.Year,
                    month = DateTime.Now.Month,
                    YardsActual = 1,
                    MaterialCost = 1,
                    DollarsActual = 1,
                    OrderDate = DateTime.Now,
                    ShipDate = DateTime.Now,
                    YardsTicketed = 1,
                    OnJobTime = DateTime.Now,
                    LocationID = 1,
                    ProspectID = 1,
                    DispatchOrderID = 1,
                    DispatchOrderNumber = "UnitTest GetDeletedItems Order.DispatchOrderNumber",
                    SalesmanCode = "UnitTest GetDeletedItems Order.SalesmanCode",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetPaymentTerms(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new PaymentTerm() {
                    Terms_Discount_ID = 1,
                    CompanyID = id,
                    Description = "UnitTest GetDeletedItems PaymentTerm.Description",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new PaymentTerm() {
                    Terms_Discount_ID = 1,
                    CompanyID = id,
                    Description = "UnitTest GetDeletedItems PaymentTerm.Description",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new PaymentTerm() {
                    Terms_Discount_ID = 2,
                    CompanyID = id,
                    Description = "UnitTest GetDeletedItems PaymentTerm.Description",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetPlantLinesOfBusiness(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new PlantLinesOfBusiness() {
                    PlantLineOfBusinessID = 1,
                    LineOfBusinessID = 1,
                    PlantID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new PlantLinesOfBusiness() {
                    PlantLineOfBusinessID = 1,
                    LineOfBusinessID = 1,
                    PlantID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new PlantLinesOfBusiness() {
                    PlantLineOfBusinessID = 2,
                    LineOfBusinessID = 1,
                    PlantID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetPlantProductPrices(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new PlantProductPrice() {
                    PlantProductPriceID = 1,
                    PlantID = 1,
                    ProductID = 1,
                    ListPrice = 1,
                    Description = "UnitTest GetDeletedItems PlantProductPrice.Description",
                    PriceListID = 1,
                    MsModificationDate = DateTime.Now,
                    PriceExtensionCode = "UnitTest GetDeletedItems PlantProductPrice.PriceExtensionCode"
                };
                retVal.Add(obj);
            } else {
                var obj = new PlantProductPrice() {
                    PlantProductPriceID = 1,
                    PlantID = 1,
                    ProductID = 1,
                    ListPrice = 1,
                    Description = "UnitTest GetDeletedItems PlantProductPrice.Description",
                    PriceListID = 1,
                    MsModificationDate = DateTime.Now,
                    PriceExtensionCode = "UnitTest GetDeletedItems PlantProductPrice.PriceExtensionCode"
                };
                retVal.Add(obj);
                obj = new PlantProductPrice() {
                    PlantProductPriceID = 2,
                    PlantID = 1,
                    ProductID = 1,
                    ListPrice = 1,
                    Description = "UnitTest GetDeletedItems PlantProductPrice.Description",
                    PriceListID = 1,
                    MsModificationDate = DateTime.Now,
                    PriceExtensionCode = "UnitTest GetDeletedItems PlantProductPrice.PriceExtensionCode"
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetPlants(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Plant() {
                    PlantID = 1,
                    Description = "UnitTest GetDeletedItems Plant.Description",
                    SystechCompNbr = "UnitTest GetDeletedItems Plant.SystechCompNbr",
                    CSPlantCode = "UnitTest GetDeletedItems Plant.CSPlantCode",
                    CSShortName = "UnitTest GetDeletedItems Plant.CSShortName",
                    CSPlantName = "UnitTest GetDeletedItems Plant.CSPlantName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive_Flag = false,
                    DivisionID = 1,
                    LineOfBusinessID = 1,
                    PlantCost = 1,
                    DeliveryCost = 1,
                    MaterialCost = 1,
                    SGACost = 1,
                    Address1 = "UnitTest GetDeletedItems Plant.Address1",
                    Address2 = "UnitTest GetDeletedItems Plant.Address2",
                    City = "UnitTest GetDeletedItems Plant.City",
                    State = "UnitTest GetDeletedItems Plant.State",
                    Zip = "UnitTest GetDeletedItems Plant.Zip",
                    Longitude = 0,
                    Latitude = 0,
                    Country = "UnitTest GetDeletedItems Plant.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Plant() {
                    PlantID = 1,
                    Description = "UnitTest GetDeletedItems Plant.Description",
                    SystechCompNbr = "UnitTest GetDeletedItems Plant.SystechCompNbr",
                    CSPlantCode = "UnitTest GetDeletedItems Plant.CSPlantCode",
                    CSShortName = "UnitTest GetDeletedItems Plant.CSShortName",
                    CSPlantName = "UnitTest GetDeletedItems Plant.CSPlantName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive_Flag = false,
                    DivisionID = 1,
                    LineOfBusinessID = 1,
                    PlantCost = 1,
                    DeliveryCost = 1,
                    MaterialCost = 1,
                    SGACost = 1,
                    Address1 = "UnitTest GetDeletedItems Plant.Address1",
                    Address2 = "UnitTest GetDeletedItems Plant.Address2",
                    City = "UnitTest GetDeletedItems Plant.City",
                    State = "UnitTest GetDeletedItems Plant.State",
                    Zip = "UnitTest GetDeletedItems Plant.Zip",
                    Longitude = 0,
                    Latitude = 0,
                    Country = "UnitTest GetDeletedItems Plant.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Plant() {
                    PlantID = 2,
                    Description = "UnitTest GetDeletedItems Plant.Description",
                    SystechCompNbr = "UnitTest GetDeletedItems Plant.SystechCompNbr",
                    CSPlantCode = "UnitTest GetDeletedItems Plant.CSPlantCode",
                    CSShortName = "UnitTest GetDeletedItems Plant.CSShortName",
                    CSPlantName = "UnitTest GetDeletedItems Plant.CSPlantName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive_Flag = false,
                    DivisionID = 1,
                    LineOfBusinessID = 1,
                    PlantCost = 1,
                    DeliveryCost = 1,
                    MaterialCost = 1,
                    SGACost = 1,
                    Address1 = "UnitTest GetDeletedItems Plant.Address1",
                    Address2 = "UnitTest GetDeletedItems Plant.Address2",
                    City = "UnitTest GetDeletedItems Plant.City",
                    State = "UnitTest GetDeletedItems Plant.State",
                    Zip = "UnitTest GetDeletedItems Plant.Zip",
                    Longitude = 0,
                    Latitude = 0,
                    Country = "UnitTest GetDeletedItems Plant.Country",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProductLines(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProductLine() {
                    ProductLineID = 1,
                    CompanyID = id,
                    ProductLineCode = "UnitTest GetDeletedItems ProductLine.ProductLineCode",
                    ProductLineName = "UnitTest GetDeletedItems ProductLine.ProductLineName",
                    Active = true,
                    extProductLineCode = "UnitTest GetDeletedItems ProductLine.extProductLineCode",
                    LineOfBusinessID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProductLine() {
                    ProductLineID = 1,
                    CompanyID = id,
                    ProductLineCode = "UnitTest GetDeletedItems ProductLine.ProductLineCode",
                    ProductLineName = "UnitTest GetDeletedItems ProductLine.ProductLineName",
                    Active = true,
                    extProductLineCode = "UnitTest GetDeletedItems ProductLine.extProductLineCode",
                    LineOfBusinessID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProductLine() {
                    ProductLineID = 2,
                    CompanyID = id,
                    ProductLineCode = "UnitTest GetDeletedItems ProductLine.ProductLineCode",
                    ProductLineName = "UnitTest GetDeletedItems ProductLine.ProductLineName",
                    Active = true,
                    extProductLineCode = "UnitTest GetDeletedItems ProductLine.extProductLineCode",
                    LineOfBusinessID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProducts(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Product() {
                    ProductID = 1,
                    CompanyID = id,
                    ProductName = "UnitTest GetDeletedItems Product.extProductLineCode",
                    Active = true,
                    AU_ID = 1,
                    UnitOfMeasureID = 1,
                    ProductTypeID = 1,
                    ConnectionCode = "UnitTest GetDeletedItems Product.ConnectionCode",
                    ITEM_CAT = "UnitTest GetDeletedItems Product.ITEM_CAT",
                    Product_Code = "UnitTest GetDeletedItems Product.Product_Code",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    extProduct_Code = "UnitTest GetDeletedItems Product.extProduct_Code",
                    IsSellable = true,
                    MsModificationDate = DateTime.Now,
                    ProductShortName = "UnitTest GetDeletedItems Product.ProductShortName"
                };
                retVal.Add(obj);
            } else {
                var obj = new Product() {
                    ProductID = 1,
                    CompanyID = id,
                    ProductName = "UnitTest GetDeletedItems Product.extProductLineCode",
                    Active = true,
                    AU_ID = 1,
                    UnitOfMeasureID = 1,
                    ProductTypeID = 1,
                    ConnectionCode = "UnitTest GetDeletedItems Product.ConnectionCode",
                    ITEM_CAT = "UnitTest GetDeletedItems Product.ITEM_CAT",
                    Product_Code = "UnitTest GetDeletedItems Product.Product_Code",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    extProduct_Code = "UnitTest GetDeletedItems Product.extProduct_Code",
                    IsSellable = true,
                    MsModificationDate = DateTime.Now,
                    ProductShortName = "UnitTest GetDeletedItems Product.ProductShortName"
                };
                retVal.Add(obj);
                obj = new Product() {
                    ProductID = 2,
                    CompanyID = id,
                    ProductName = "UnitTest GetDeletedItems Product.extProductLineCode",
                    Active = true,
                    AU_ID = 1,
                    UnitOfMeasureID = 1,
                    ProductTypeID = 1,
                    ConnectionCode = "UnitTest GetDeletedItems Product.ConnectionCode",
                    ITEM_CAT = "UnitTest GetDeletedItems Product.ITEM_CAT",
                    Product_Code = "UnitTest GetDeletedItems Product.Product_Code",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    extProduct_Code = "UnitTest GetDeletedItems Product.extProduct_Code",
                    IsSellable = true,
                    MsModificationDate = DateTime.Now,
                    ProductShortName = "UnitTest GetDeletedItems Product.ProductShortName"
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProductTemplates(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProductTemplate() {
                    ProductTemplateID = 1,
                    TemplateName = "UnitTest GetDeletedItems ProductTemplate.TemplateName",
                    CompanyUserID = 1,
                    Inactive = false,
                    MsModificationDate = DateTime.Now,
                    Shared = true
                };
                retVal.Add(obj);
            } else {
                var obj = new ProductTemplate() {
                    ProductTemplateID = 1,
                    TemplateName = "UnitTest GetDeletedItems ProductTemplate.TemplateName",
                    CompanyUserID = 1,
                    Inactive = false,
                    MsModificationDate = DateTime.Now,
                    Shared = true
                };
                retVal.Add(obj);
                obj = new ProductTemplate() {
                    ProductTemplateID = 2,
                    TemplateName = "UnitTest GetDeletedItems ProductTemplate.TemplateName",
                    CompanyUserID = 1,
                    Inactive = false,
                    MsModificationDate = DateTime.Now,
                    Shared = true
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProductTypes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProductType() {
                    ProductTypeID = 1,
                    CompanyID = id,
                    ProductTypeName = "UnitTest GetDeletedItems ProductType.ProductTypeName",
                    ProductTypeCode = "UnitTest GetDeletedItems ProductType.ProductTypeCode",
                    ProductLineID = 1,
                    ListPrice = 1,
                    UOMID = 1,
                    Inactive = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProductType() {
                    ProductTypeID = 1,
                    CompanyID = id,
                    ProductTypeName = "UnitTest GetDeletedItems ProductType.ProductTypeName",
                    ProductTypeCode = "UnitTest GetDeletedItems ProductType.ProductTypeCode",
                    ProductLineID = 1,
                    ListPrice = 1,
                    UOMID = 1,
                    Inactive = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProductType() {
                    ProductTypeID = 2,
                    CompanyID = id,
                    ProductTypeName = "UnitTest GetDeletedItems ProductType.ProductTypeName",
                    ProductTypeCode = "UnitTest GetDeletedItems ProductType.ProductTypeCode",
                    ProductLineID = 1,
                    ListPrice = 1,
                    UOMID = 1,
                    Inactive = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProductUsage(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProductUsage() {
                    ProductUsageID = 1,
                    CompanyID = id,
                    ProductUsageName = "UnitTest GetDeletedItems ProductUsage.ProductUsageName",
                    ProductLineID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProductUsage() {
                    ProductUsageID = 1,
                    CompanyID = id,
                    ProductUsageName = "UnitTest GetDeletedItems ProductUsage.ProductUsageName",
                    ProductLineID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProductUsage() {
                    ProductUsageID = 2,
                    CompanyID = id,
                    ProductUsageName = "UnitTest GetDeletedItems ProductUsage.ProductUsageName",
                    ProductLineID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectBidderCharges(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectBidderCharge() {
                    ProjectBidderChargeID = 1,
                    ProjectBidderID = 1,
                    ProductLineID = 1,
                    ProjectChargeID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectBidderCharge() {
                    ProjectBidderChargeID = 1,
                    ProjectBidderID = 1,
                    ProductLineID = 1,
                    ProjectChargeID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProjectBidderCharge() {
                    ProjectBidderChargeID = 2,
                    ProjectBidderID = 1,
                    ProductLineID = 1,
                    ProjectChargeID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectBidderNotes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectBidderNote() {
                    NoteID = 1,
                    ProjectBidderID = 1,
                    Note = "UnitTest GetDeletedItems ProjectBidderNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectBidderNote() {
                    NoteID = 1,
                    ProjectBidderID = 1,
                    Note = "UnitTest GetDeletedItems ProjectBidderNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProjectBidderNote() {
                    NoteID = 2,
                    ProjectBidderID = 1,
                    Note = "UnitTest GetDeletedItems ProjectBidderNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectBidderProducts(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectBidderProduct() {
                    ProjectBidderProductID = 1,
                    ProjectBidderID = 1,
                    ProjectProductID = 1,
                    Price = 1,
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    SameAsList = true,
                    Forecasted = true,
                    Freight = 1,
                    FreightPay = 1,
                    ListPrice = 1,
                    CustomerPrice = 1,
                    Exported = false,
                    Quantity = 1,
                    StatusID = 1,
                    LineNbr = 1,
                    MsModificationDate = DateTime.Now,
                    PreviousPrice = 1,
                    PreviousDeliveredPrice = 1
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectBidderProduct() {
                    ProjectBidderProductID = 1,
                    ProjectBidderID = 1,
                    ProjectProductID = 1,
                    Price = 1,
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    SameAsList = true,
                    Forecasted = true,
                    Freight = 1,
                    FreightPay = 1,
                    ListPrice = 1,
                    CustomerPrice = 1,
                    Exported = false,
                    Quantity = 1,
                    StatusID = 1,
                    LineNbr = 1,
                    MsModificationDate = DateTime.Now,
                    PreviousPrice = 1,
                    PreviousDeliveredPrice = 1
                };
                retVal.Add(obj);
                obj = new ProjectBidderProduct() {
                    ProjectBidderProductID = 2,
                    ProjectBidderID = 1,
                    ProjectProductID = 1,
                    Price = 1,
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    SameAsList = true,
                    Forecasted = true,
                    Freight = 1,
                    FreightPay = 1,
                    ListPrice = 1,
                    CustomerPrice = 1,
                    Exported = false,
                    Quantity = 1,
                    StatusID = 1,
                    LineNbr = 1,
                    MsModificationDate = DateTime.Now,
                    PreviousPrice = 1,
                    PreviousDeliveredPrice = 1
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectBidders(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectBidder() {
                    ProjectBidderID = 1,
                    ProjectID = 1,
                    ProspectID = 1,
                    Quoted = false,
                    StatusSub = true,
                    QuoteDate = DateTime.Now,
                    NotLIkeLIst = true,
                    StatusID = 1,
                    PlantID = 1,
                    ProjectCode = "UnitTest GetDeletedItems ProjectBidder.ProjectCode",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    PONumber = "UnitTest GetDeletedItems ProjectBidder.PONumber",
                    MinLoadCharge = 1,
                    SundryCharge = 1,
                    SeasonalCharge = 1,
                    UnloadCharge = 1,
                    CustJobNbr = "UnitTest GetDeletedItems ProjectBidder.CustJobNbr",
                    MsModificationDate = DateTime.Now,
                    EffectiveDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectBidder() {
                    ProjectBidderID = 1,
                    ProjectID = 1,
                    ProspectID = 1,
                    Quoted = false,
                    StatusSub = true,
                    QuoteDate = DateTime.Now,
                    NotLIkeLIst = true,
                    StatusID = 1,
                    PlantID = 1,
                    ProjectCode = "UnitTest GetDeletedItems ProjectBidder.ProjectCode",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    PONumber = "UnitTest GetDeletedItems ProjectBidder.PONumber",
                    MinLoadCharge = 1,
                    SundryCharge = 1,
                    SeasonalCharge = 1,
                    UnloadCharge = 1,
                    CustJobNbr = "UnitTest GetDeletedItems ProjectBidder.CustJobNbr",
                    MsModificationDate = DateTime.Now,
                    EffectiveDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProjectBidder() {
                    ProjectBidderID = 2,
                    ProjectID = 1,
                    ProspectID = 1,
                    Quoted = false,
                    StatusSub = true,
                    QuoteDate = DateTime.Now,
                    NotLIkeLIst = true,
                    StatusID = 1,
                    PlantID = 1,
                    ProjectCode = "UnitTest GetDeletedItems ProjectBidder.ProjectCode",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    PONumber = "UnitTest GetDeletedItems ProjectBidder.PONumber",
                    MinLoadCharge = 1,
                    SundryCharge = 1,
                    SeasonalCharge = 1,
                    UnloadCharge = 1,
                    CustJobNbr = "UnitTest GetDeletedItems ProjectBidder.CustJobNbr",
                    MsModificationDate = DateTime.Now,
                    EffectiveDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectBidderStatuses(DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectBidderStatus() {
                    ProjectBidderStatusID = 1,
                    StatusName = "UnitTest GetDeletedItems ProjectBidderStatus.StatusName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectBidderStatus() {
                    ProjectBidderStatusID = 1,
                    StatusName = "UnitTest GetDeletedItems ProjectBidderStatus.StatusName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProjectBidderStatus() {
                    ProjectBidderStatusID = 2,
                    StatusName = "UnitTest GetDeletedItems ProjectBidderStatus.StatusName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectCharges(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectCharge() {
                    ChargeID = 1,
                    ChargeName = "UnitTest GetDeletedItems ProjectCharge.ChargeName",
                    ChargeType = 1,
                    ChargeCode = "UnitTest GetDeletedItems ProjectCharge.ChargeName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectCharge() {
                    ChargeID = 1,
                    ChargeName = "UnitTest GetDeletedItems ProjectCharge.ChargeName",
                    ChargeType = 1,
                    ChargeCode = "UnitTest GetDeletedItems ProjectCharge.ChargeName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProjectCharge() {
                    ChargeID = 2,
                    ChargeName = "UnitTest GetDeletedItems ProjectCharge.ChargeName",
                    ChargeType = 1,
                    ChargeCode = "UnitTest GetDeletedItems ProjectCharge.ChargeName",
                    CompanyID = id,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectChargeTypes(DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectChargeType() {
                    ChargeTypeID = 1,
                    ChargeTypeName = "UnitTest GetDeletedItems ProjectChargeType.ChargeTypeName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectChargeType() {
                    ChargeTypeID = 1,
                    ChargeTypeName = "UnitTest GetDeletedItems ProjectChargeType.ChargeTypeName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProjectChargeType() {
                    ChargeTypeID = 2,
                    ChargeTypeName = "UnitTest GetDeletedItems ProjectChargeType.ChargeTypeName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectDistances(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectDistance() {
                    ProjectDistanceID = 1,
                    ProjectID = 1,
                    PlantID = 1,
                    Miles = 1,
                    Kilometers = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectDistance() {
                    ProjectDistanceID = 1,
                    ProjectID = 1,
                    PlantID = 1,
                    Miles = 1,
                    Kilometers = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProjectDistance() {
                    ProjectDistanceID = 2,
                    ProjectID = 1,
                    PlantID = 1,
                    Miles = 1,
                    Kilometers = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectMapQtyRanges(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectMapQtyRange() {
                    ProjectMapQtyRangeID = 1,
                    CompanyID = id,
                    Min = 1,
                    Max = 1,
                    DisplayText = "UnitTest GetDeletedItems ProjectChargeType.ChargeTypeName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectMapQtyRange() {
                    ProjectMapQtyRangeID = 1,
                    CompanyID = id,
                    Min = 1,
                    Max = 1,
                    DisplayText = "UnitTest GetDeletedItems ProjectChargeType.ChargeTypeName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProjectMapQtyRange() {
                    ProjectMapQtyRangeID = 2,
                    CompanyID = id,
                    Min = 1,
                    Max = 1,
                    DisplayText = "UnitTest GetDeletedItems ProjectChargeType.ChargeTypeName",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectNotes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectNote() {
                    NoteID = 1,
                    ProjectID = 1,
                    Note = "UnitTest GetDeletedItems ProjectNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectNote() {
                    NoteID = 1,
                    ProjectID = 1,
                    Note = "UnitTest GetDeletedItems ProjectNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProjectNote() {
                    NoteID = 2,
                    ProjectID = 1,
                    Note = "UnitTest GetDeletedItems ProjectNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectProducts(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectProduct() {
                    ProjectProductID = 1,
                    ProjectID = 1,
                    Qty = 1,
                    UOMID = 1,
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Price = 1,
                    ProductLineID = 1,
                    ProductTypeID = 1,
                    ProductID = 1,
                    PsiID = 1,
                    ProductUsageID = 1,
                    Note = "UnitTest GetDeletedItems ProjectProduct.Note",
                    Forecasted = true,
                    PlantID = 1,
                    Freight = 1,
                    FreightPay = 1,
                    CompetitorPrice = 1,
                    Category = "UnitTest GetDeletedItems ProjectProduct.Category",
                    Description = "UnitTest GetDeletedItems ProjectProduct.Description",
                    LineOfBusinessID = 1,
                    StatusID = 1,
                    MsModificationDate = DateTime.Now,
                    PriceExtensionCode = "UnitTest GetDeletedItems ProjectProduct.PriceExtensionCode",
                    LostReasonID = 1,
                    LostToID = 1,
                    LostNote = "UnitTest GetDeletedItems ProjectProduct.LostNote",
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectProduct() {
                    ProjectProductID = 1,
                    ProjectID = 1,
                    Qty = 1,
                    UOMID = 1,
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Price = 1,
                    ProductLineID = 1,
                    ProductTypeID = 1,
                    ProductID = 1,
                    PsiID = 1,
                    ProductUsageID = 1,
                    Note = "UnitTest GetDeletedItems ProjectProduct.Note",
                    Forecasted = true,
                    PlantID = 1,
                    Freight = 1,
                    FreightPay = 1,
                    CompetitorPrice = 1,
                    Category = "UnitTest GetDeletedItems ProjectProduct.Category",
                    Description = "UnitTest GetDeletedItems ProjectProduct.Description",
                    LineOfBusinessID = 1,
                    StatusID = 1,
                    MsModificationDate = DateTime.Now,
                    PriceExtensionCode = "UnitTest GetDeletedItems ProjectProduct.PriceExtensionCode",
                    LostReasonID = 1,
                    LostToID = 1,
                    LostNote = "UnitTest GetDeletedItems ProjectProduct.LostNote",
                };
                retVal.Add(obj);
                obj = new ProjectProduct() {
                    ProjectProductID = 2,
                    ProjectID = 1,
                    Qty = 1,
                    UOMID = 1,
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Price = 1,
                    ProductLineID = 1,
                    ProductTypeID = 1,
                    ProductID = 1,
                    PsiID = 1,
                    ProductUsageID = 1,
                    Note = "UnitTest GetDeletedItems ProjectProduct.Note",
                    Forecasted = true,
                    PlantID = 1,
                    Freight = 1,
                    FreightPay = 1,
                    CompetitorPrice = 1,
                    Category = "UnitTest GetDeletedItems ProjectProduct.Category",
                    Description = "UnitTest GetDeletedItems ProjectProduct.Description",
                    LineOfBusinessID = 1,
                    StatusID = 1,
                    MsModificationDate = DateTime.Now,
                    PriceExtensionCode = "UnitTest GetDeletedItems ProjectProduct.PriceExtensionCode",
                    LostReasonID = 1,
                    LostToID = 1,
                    LostNote = "UnitTest GetDeletedItems ProjectProduct.LostNote",
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjects(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Project() {
                    ProjectID = 1,
                    Private = false,
                    OwnerID = 1,
                    CompanyID = id,
                    ProjectName = "UnitTest GetDeletedItems Project.ProjectName",
                    ProjectTypeID = 1,
                    StatusID = 1,
                    StatusChangeDate = DateTime.Now,
                    SourceID = 1,
                    Active = true,
                    Address1 = "UnitTest GetDeletedItems Project.Address1",
                    Address2 = "UnitTest GetDeletedItems Project.Address2",
                    City = "UnitTest GetDeletedItems Project.City",
                    County = "UnitTest GetDeletedItems Project.County",
                    State = "UnitTest GetDeletedItems Project.State",
                    ZipCode = "UnitTest GetDeletedItems Project.ZipCode",
                    PlantID = 1,
                    SalespersonID = 1,
                    BidDate = DateTime.Now,
                    LostReasonID = 1,
                    LostToID = 1,
                    LostNote = "UnitTest GetDeletedItems Project.ConnectionCode",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    PrevStatus = 1,
                    Exported = false,
                    WinningProjectBidderID = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    TotalYards = 1,
                    ConnectionCode = "UnitTest GetDeletedItems Project.ConnectionCode",
                    CustCode = "UnitTest GetDeletedItems Project.CustCode",
                    ProjectCode = "UnitTest GetDeletedItems Project.ProjectCode",
                    Longitude = 1,
                    Latitude = 1,
                    GeofenceID = 1,
                    Country = "UnitTest GetDeletedItems Project.Country",
                    ProjectDescription = "UnitTest GetDeletedItems Project.ProjectDescription",
                    ZoneCodeID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Project() {
                    ProjectID = 1,
                    Private = false,
                    OwnerID = 1,
                    CompanyID = id,
                    ProjectName = "UnitTest GetDeletedItems Project.ProjectName",
                    ProjectTypeID = 1,
                    StatusID = 1,
                    StatusChangeDate = DateTime.Now,
                    SourceID = 1,
                    Active = true,
                    Address1 = "UnitTest GetDeletedItems Project.Address1",
                    Address2 = "UnitTest GetDeletedItems Project.Address2",
                    City = "UnitTest GetDeletedItems Project.City",
                    County = "UnitTest GetDeletedItems Project.County",
                    State = "UnitTest GetDeletedItems Project.State",
                    ZipCode = "UnitTest GetDeletedItems Project.ZipCode",
                    PlantID = 1,
                    SalespersonID = 1,
                    BidDate = DateTime.Now,
                    LostReasonID = 1,
                    LostToID = 1,
                    LostNote = "UnitTest GetDeletedItems Project.ConnectionCode",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    PrevStatus = 1,
                    Exported = false,
                    WinningProjectBidderID = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    TotalYards = 1,
                    ConnectionCode = "UnitTest GetDeletedItems Project.ConnectionCode",
                    CustCode = "UnitTest GetDeletedItems Project.CustCode",
                    ProjectCode = "UnitTest GetDeletedItems Project.ProjectCode",
                    Longitude = 1,
                    Latitude = 1,
                    GeofenceID = 1,
                    Country = "UnitTest GetDeletedItems Project.Country",
                    ProjectDescription = "UnitTest GetDeletedItems Project.ProjectDescription",
                    ZoneCodeID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Project() {
                    ProjectID = 2,
                    Private = false,
                    OwnerID = 1,
                    CompanyID = id,
                    ProjectName = "UnitTest GetDeletedItems Project.ProjectName",
                    ProjectTypeID = 1,
                    StatusID = 1,
                    StatusChangeDate = DateTime.Now,
                    SourceID = 1,
                    Active = true,
                    Address1 = "UnitTest GetDeletedItems Project.Address1",
                    Address2 = "UnitTest GetDeletedItems Project.Address2",
                    City = "UnitTest GetDeletedItems Project.City",
                    County = "UnitTest GetDeletedItems Project.County",
                    State = "UnitTest GetDeletedItems Project.State",
                    ZipCode = "UnitTest GetDeletedItems Project.ZipCode",
                    PlantID = 1,
                    SalespersonID = 1,
                    BidDate = DateTime.Now,
                    LostReasonID = 1,
                    LostToID = 1,
                    LostNote = "UnitTest GetDeletedItems Project.ConnectionCode",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    PrevStatus = 1,
                    Exported = false,
                    WinningProjectBidderID = 1,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    TotalYards = 1,
                    ConnectionCode = "UnitTest GetDeletedItems Project.ConnectionCode",
                    CustCode = "UnitTest GetDeletedItems Project.CustCode",
                    ProjectCode = "UnitTest GetDeletedItems Project.ProjectCode",
                    Longitude = 1,
                    Latitude = 1,
                    GeofenceID = 1,
                    Country = "UnitTest GetDeletedItems Project.Country",
                    ProjectDescription = "UnitTest GetDeletedItems Project.ProjectDescription",
                    ZoneCodeID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
            
        }

        public object GetProjectTypes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProjectType() {
                    ProjectTypeID = 1,
                    CompanyID = id,
                    ConnectionCode = "UnitTest GetDeletedItems ProjectType.ConnectionCode",
                    SANL_Code = "UnitTest GetDeletedItems ProjectType.ConnectionCode",
                    ProjectTypeName = "UnitTest GetDeletedItems ProjectType.SANL_Code",
                    ShortName = "UnitTest GetDeletedItems ProjectType.ShortName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProjectType() {
                    ProjectTypeID = 1,
                    CompanyID = id,
                    ConnectionCode = "UnitTest GetDeletedItems ProjectType.ConnectionCode",
                    SANL_Code = "UnitTest GetDeletedItems ProjectType.ConnectionCode",
                    ProjectTypeName = "UnitTest GetDeletedItems ProjectType.SANL_Code",
                    ShortName = "UnitTest GetDeletedItems ProjectType.ShortName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProjectType() {
                    ProjectTypeID = 2,
                    CompanyID = id,
                    ConnectionCode = "UnitTest GetDeletedItems ProjectType.ConnectionCode",
                    SANL_Code = "UnitTest GetDeletedItems ProjectType.ConnectionCode",
                    ProjectTypeName = "UnitTest GetDeletedItems ProjectType.SANL_Code",
                    ShortName = "UnitTest GetDeletedItems ProjectType.ShortName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProspectNotes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ProspectNote() {
                    ProspectNoteID = 1,
                    ProspectID = 1,
                    Note = "UnitTest GetDeletedItems ProspectNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    Subject = "UnitTest GetDeletedItems ProspectNote.Subject",
                    Source = "UnitTest GetDeletedItems ProspectNote.Source",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ProspectNote() {
                    ProspectNoteID = 1,
                    ProspectID = 1,
                    Note = "UnitTest GetDeletedItems ProspectNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    Subject = "UnitTest GetDeletedItems ProspectNote.Subject",
                    Source = "UnitTest GetDeletedItems ProspectNote.Source",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ProspectNote() {
                    ProspectNoteID = 2,
                    ProspectID = 1,
                    Note = "UnitTest GetDeletedItems ProspectNote.Note",
                    Inserted = DateTime.Now,
                    CreatedBy = 1,
                    Subject = "UnitTest GetDeletedItems ProspectNote.Subject",
                    Source = "UnitTest GetDeletedItems ProspectNote.Source",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProspects(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Prospect() {
                    ProspectID = 1,
                    Private = false,
                    OwnerID = 1,
                    CompanyID = id,
                    ProspectName = "UnitTest GetDeletedItems Prospect.ProspectName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    ProspectCode = "UnitTest GetDeletedItems Prospect.ProspectCode",
                    ConnectionCode = "UnitTest GetDeletedItems Prospect.ConnectionCode",
                    LocalCustNumber = "UnitTest GetDeletedItems Prospect.LocalCustNumber",
                    LocalCustName = "UnitTest GetDeletedItems Prospect.LocalCustName",
                    IsCustomer = true,
                    Credit_Status_ID = 1,
                    CustomerStatus = "UnitTest GetDeletedItems Prospect.CustomerStatus",
                    Sales = 1,
                    Margin = 1,
                    MaterialMargin = 1,
                    JobCount = 1,
                    Address1 = "UnitTest GetDeletedItems Prospect.Address1",
                    Address2 = "UnitTest GetDeletedItems Prospect.Address2",
                    City = "UnitTest GetDeletedItems Prospect.City",
                    State = "UnitTest GetDeletedItems Prospect.State",
                    Zip = "UnitTest GetDeletedItems Prospect.Zip",
                    Phone = "UnitTest GetDeletedItems Prospect.Phone",
                    HighestBalance = 1,
                    AvgInvoiceAmt = 1,
                    AvgDaysToPay = 1,
                    AvgDaysPastDue = 1,
                    TotalDue = 1,
                    ZeroTo30Days = 1,
                    ThirtyOneTo60Days = 1,
                    SixtyOneTo90Days = 1,
                    NinetyOneTo120Days = 1,
                    Over120Days = 1,
                    CustomerTypeID = 1,
                    StatementFrequency = "UnitTest GetDeletedItems Prospect.StatementFrequency",
                    FinanceRate = 1,
                    PaymentTermsID = 1,
                    SalesmanCode = "UnitTest GetDeletedItems Prospect.SalesmanCode",
                    Fax = "UnitTest GetDeletedItems Prospect.Fax",
                    WebSite = "UnitTest GetDeletedItems Prospect.WebSite",
                    AvgRevenue = 1,
                    NumberofEmployees = "UnitTest GetDeletedItems Prospect.NumberofEmployees",
                    CompanyOriginDate = "UnitTest GetDeletedItems Prospect.CompanyOriginDate",
                    BusinessTypeID = 1,
                    Notes = "UnitTest GetDeletedItems Prospect.Notes",
                    Country = "UnitTest GetDeletedItems Prospect.Country",
                    PORequired = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Prospect() {
                    ProspectID = 1,
                    Private = false,
                    OwnerID = 1,
                    CompanyID = id,
                    ProspectName = "UnitTest GetDeletedItems Prospect.ProspectName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    ProspectCode = "UnitTest GetDeletedItems Prospect.ProspectCode",
                    ConnectionCode = "UnitTest GetDeletedItems Prospect.ConnectionCode",
                    LocalCustNumber = "UnitTest GetDeletedItems Prospect.LocalCustNumber",
                    LocalCustName = "UnitTest GetDeletedItems Prospect.LocalCustName",
                    IsCustomer = true,
                    Credit_Status_ID = 1,
                    CustomerStatus = "UnitTest GetDeletedItems Prospect.CustomerStatus",
                    Sales = 1,
                    Margin = 1,
                    MaterialMargin = 1,
                    JobCount = 1,
                    Address1 = "UnitTest GetDeletedItems Prospect.Address1",
                    Address2 = "UnitTest GetDeletedItems Prospect.Address2",
                    City = "UnitTest GetDeletedItems Prospect.City",
                    State = "UnitTest GetDeletedItems Prospect.State",
                    Zip = "UnitTest GetDeletedItems Prospect.Zip",
                    Phone = "UnitTest GetDeletedItems Prospect.Phone",
                    HighestBalance = 1,
                    AvgInvoiceAmt = 1,
                    AvgDaysToPay = 1,
                    AvgDaysPastDue = 1,
                    TotalDue = 1,
                    ZeroTo30Days = 1,
                    ThirtyOneTo60Days = 1,
                    SixtyOneTo90Days = 1,
                    NinetyOneTo120Days = 1,
                    Over120Days = 1,
                    CustomerTypeID = 1,
                    StatementFrequency = "UnitTest GetDeletedItems Prospect.StatementFrequency",
                    FinanceRate = 1,
                    PaymentTermsID = 1,
                    SalesmanCode = "UnitTest GetDeletedItems Prospect.SalesmanCode",
                    Fax = "UnitTest GetDeletedItems Prospect.Fax",
                    WebSite = "UnitTest GetDeletedItems Prospect.WebSite",
                    AvgRevenue = 1,
                    NumberofEmployees = "UnitTest GetDeletedItems Prospect.NumberofEmployees",
                    CompanyOriginDate = "UnitTest GetDeletedItems Prospect.CompanyOriginDate",
                    BusinessTypeID = 1,
                    Notes = "UnitTest GetDeletedItems Prospect.Notes",
                    Country = "UnitTest GetDeletedItems Prospect.Country",
                    PORequired = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Prospect() {
                    ProspectID = 2,
                    Private = false,
                    OwnerID = 1,
                    CompanyID = id,
                    ProspectName = "UnitTest GetDeletedItems Prospect.ProspectName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    ProspectCode = "UnitTest GetDeletedItems Prospect.ProspectCode",
                    ConnectionCode = "UnitTest GetDeletedItems Prospect.ConnectionCode",
                    LocalCustNumber = "UnitTest GetDeletedItems Prospect.LocalCustNumber",
                    LocalCustName = "UnitTest GetDeletedItems Prospect.LocalCustName",
                    IsCustomer = true,
                    Credit_Status_ID = 1,
                    CustomerStatus = "UnitTest GetDeletedItems Prospect.CustomerStatus",
                    Sales = 1,
                    Margin = 1,
                    MaterialMargin = 1,
                    JobCount = 1,
                    Address1 = "UnitTest GetDeletedItems Prospect.Address1",
                    Address2 = "UnitTest GetDeletedItems Prospect.Address2",
                    City = "UnitTest GetDeletedItems Prospect.City",
                    State = "UnitTest GetDeletedItems Prospect.State",
                    Zip = "UnitTest GetDeletedItems Prospect.Zip",
                    Phone = "UnitTest GetDeletedItems Prospect.Phone",
                    HighestBalance = 1,
                    AvgInvoiceAmt = 1,
                    AvgDaysToPay = 1,
                    AvgDaysPastDue = 1,
                    TotalDue = 1,
                    ZeroTo30Days = 1,
                    ThirtyOneTo60Days = 1,
                    SixtyOneTo90Days = 1,
                    NinetyOneTo120Days = 1,
                    Over120Days = 1,
                    CustomerTypeID = 1,
                    StatementFrequency = "UnitTest GetDeletedItems Prospect.StatementFrequency",
                    FinanceRate = 1,
                    PaymentTermsID = 1,
                    SalesmanCode = "UnitTest GetDeletedItems Prospect.SalesmanCode",
                    Fax = "UnitTest GetDeletedItems Prospect.Fax",
                    WebSite = "UnitTest GetDeletedItems Prospect.WebSite",
                    AvgRevenue = 1,
                    NumberofEmployees = "UnitTest GetDeletedItems Prospect.NumberofEmployees",
                    CompanyOriginDate = "UnitTest GetDeletedItems Prospect.CompanyOriginDate",
                    BusinessTypeID = 1,
                    Notes = "UnitTest GetDeletedItems Prospect.Notes",
                    Country = "UnitTest GetDeletedItems Prospect.Country",
                    PORequired = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetQuoteDetails(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new QuoteDetail() {
                    QuoteDetailID = 1,
                    QuoteID = 1,
                    ProjectProductID = 1,
                    Price = 1,
                    Qty = 1,
                    Freight = 1,
                    FreightPay = 1,
                    ListPrice = 1,
                    CustomerPrice = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new QuoteDetail() {
                    QuoteDetailID = 1,
                    QuoteID = 1,
                    ProjectProductID = 1,
                    Price = 1,
                    Qty = 1,
                    Freight = 1,
                    FreightPay = 1,
                    ListPrice = 1,
                    CustomerPrice = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new QuoteDetail() {
                    QuoteDetailID = 2,
                    QuoteID = 1,
                    ProjectProductID = 1,
                    Price = 1,
                    Qty = 1,
                    Freight = 1,
                    FreightPay = 1,
                    ListPrice = 1,
                    CustomerPrice = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetQuotes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Quote() {
                    QuoteID = 1,
                    ProjectBidderID = 1,
                    ContactID = 1,
                    TermsID = 1,
                    Attention = "UnitTest GetDeletedItems Quote.Attention",
                    Phone = "UnitTest GetDeletedItems Quote.Phone",
                    CellPhone = "UnitTest GetDeletedItems Quote.CellPhone",
                    Fax = "UnitTest GetDeletedItems Quote.Fax",
                    Email = "UnitTest GetDeletedItems Quote.Email",
                    QuoteDate = DateTime.Now,
                    FirmUntilDate = DateTime.Now,
                    QuoteSequenceNumber = 1,
                    QuoteTypeID = 1,
                    DateCreated = DateTime.Now,
                    DateLastModified = DateTime.Now,
                    CustomerQuoteID = "UnitTest GetDeletedItems Quote.CustomerQuoteID",
                    Exported = true,
                    EscalationDate = DateTime.Now,
                    QuoteNote = "UnitTest GetDeletedItems Quote.QuoteNote",
                    EscalationAmount = "UnitTest GetDeletedItems Quote.EscalationAmount",
                    QuoteStatusID = 1,
                    Notes = "UnitTest GetDeletedItems Quote.Notes",
                    CreatedByID = 1,
                    OrderDate = DateTime.Now,
                    StartOrderDate = DateTime.Now,
                    ExpireOrderDate = DateTime.Now,
                    VehicleTypeID_1 = 1,
                    VehicleTypeID_2 = 1,
                    VehicleTypeID_3 = 1,
                    VehicleTypeID_4 = 1,
                    VehicleTypeID_5 = 1,
                    CustomerOrderID = "UnitTest GetDeletedItems Quote.CustomerOrderID",
                    PurchaseOrder = "UnitTest GetDeletedItems Quote.PurchaseOrder",
                    BeginDate = DateTime.Now,
                    AllowBeforeStart = true,
                    AllowAfterEnd = true,
                    AllowExceedQty = true,
                    AllowExceedLoads = true,
                    AllowAfterComplete = true,
                    MsModificationDate = DateTime.Now,
                    SalespersonID = 1,
                    ApexNoteID = 1
                };
                retVal.Add(obj);
            } else {
                var obj = new Quote() {
                    QuoteID = 1,
                    ProjectBidderID = 1,
                    ContactID = 1,
                    TermsID = 1,
                    Attention = "UnitTest GetDeletedItems Quote.Attention",
                    Phone = "UnitTest GetDeletedItems Quote.Phone",
                    CellPhone = "UnitTest GetDeletedItems Quote.CellPhone",
                    Fax = "UnitTest GetDeletedItems Quote.Fax",
                    Email = "UnitTest GetDeletedItems Quote.Email",
                    QuoteDate = DateTime.Now,
                    FirmUntilDate = DateTime.Now,
                    QuoteSequenceNumber = 1,
                    QuoteTypeID = 1,
                    DateCreated = DateTime.Now,
                    DateLastModified = DateTime.Now,
                    CustomerQuoteID = "UnitTest GetDeletedItems Quote.CustomerQuoteID",
                    Exported = true,
                    EscalationDate = DateTime.Now,
                    QuoteNote = "UnitTest GetDeletedItems Quote.QuoteNote",
                    EscalationAmount = "UnitTest GetDeletedItems Quote.EscalationAmount",
                    QuoteStatusID = 1,
                    Notes = "UnitTest GetDeletedItems Quote.Notes",
                    CreatedByID = 1,
                    OrderDate = DateTime.Now,
                    StartOrderDate = DateTime.Now,
                    ExpireOrderDate = DateTime.Now,
                    VehicleTypeID_1 = 1,
                    VehicleTypeID_2 = 1,
                    VehicleTypeID_3 = 1,
                    VehicleTypeID_4 = 1,
                    VehicleTypeID_5 = 1,
                    CustomerOrderID = "UnitTest GetDeletedItems Quote.CustomerOrderID",
                    PurchaseOrder = "UnitTest GetDeletedItems Quote.PurchaseOrder",
                    BeginDate = DateTime.Now,
                    AllowBeforeStart = true,
                    AllowAfterEnd = true,
                    AllowExceedQty = true,
                    AllowExceedLoads = true,
                    AllowAfterComplete = true,
                    MsModificationDate = DateTime.Now,
                    SalespersonID = 1,
                    ApexNoteID = 1
                };
                retVal.Add(obj);
                obj = new Quote() {
                    QuoteID = 2,
                    ProjectBidderID = 1,
                    ContactID = 1,
                    TermsID = 1,
                    Attention = "UnitTest GetDeletedItems Quote.Attention",
                    Phone = "UnitTest GetDeletedItems Quote.Phone",
                    CellPhone = "UnitTest GetDeletedItems Quote.CellPhone",
                    Fax = "UnitTest GetDeletedItems Quote.Fax",
                    Email = "UnitTest GetDeletedItems Quote.Email",
                    QuoteDate = DateTime.Now,
                    FirmUntilDate = DateTime.Now,
                    QuoteSequenceNumber = 1,
                    QuoteTypeID = 1,
                    DateCreated = DateTime.Now,
                    DateLastModified = DateTime.Now,
                    CustomerQuoteID = "UnitTest GetDeletedItems Quote.CustomerQuoteID",
                    Exported = true,
                    EscalationDate = DateTime.Now,
                    QuoteNote = "UnitTest GetDeletedItems Quote.QuoteNote",
                    EscalationAmount = "UnitTest GetDeletedItems Quote.EscalationAmount",
                    QuoteStatusID = 1,
                    Notes = "UnitTest GetDeletedItems Quote.Notes",
                    CreatedByID = 1,
                    OrderDate = DateTime.Now,
                    StartOrderDate = DateTime.Now,
                    ExpireOrderDate = DateTime.Now,
                    VehicleTypeID_1 = 1,
                    VehicleTypeID_2 = 1,
                    VehicleTypeID_3 = 1,
                    VehicleTypeID_4 = 1,
                    VehicleTypeID_5 = 1,
                    CustomerOrderID = "UnitTest GetDeletedItems Quote.CustomerOrderID",
                    PurchaseOrder = "UnitTest GetDeletedItems Quote.PurchaseOrder",
                    BeginDate = DateTime.Now,
                    AllowBeforeStart = true,
                    AllowAfterEnd = true,
                    AllowExceedQty = true,
                    AllowExceedLoads = true,
                    AllowAfterComplete = true,
                    MsModificationDate = DateTime.Now,
                    SalespersonID = 1,
                    ApexNoteID = 1
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetQuoteSections(DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new QuoteSection() {
                    QuoteSectionID = 1,
                    QuoteTypeID = 1,
                    SectionContent = null,
                    PositionTop = 1,
                    PositionLeft = 1,
                    Height = 1,
                    Width = 1,
                    IsProducts = false,
                    IsSurcharges = false,
                    IsLogo = false,
                    IsCompanyInfo = false,
                    IsCustomerInfo = false,
                    IsSignature = false,
                    IsExpiration = false,
                    IsQuoteNumber = false,
                    ProductColumns = "UnitTest GetDeletedItems QuoteSection.ProductColumns",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new QuoteSection() {
                    QuoteSectionID = 1,
                    QuoteTypeID = 1,
                    SectionContent = null,
                    PositionTop = 1,
                    PositionLeft = 1,
                    Height = 1,
                    Width = 1,
                    IsProducts = false,
                    IsSurcharges = false,
                    IsLogo = false,
                    IsCompanyInfo = false,
                    IsCustomerInfo = false,
                    IsSignature = false,
                    IsExpiration = false,
                    IsQuoteNumber = false,
                    ProductColumns = "UnitTest GetDeletedItems QuoteSection.ProductColumns",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new QuoteSection() {
                    QuoteSectionID = 2,
                    QuoteTypeID = 1,
                    SectionContent = null,
                    PositionTop = 1,
                    PositionLeft = 1,
                    Height = 1,
                    Width = 1,
                    IsProducts = false,
                    IsSurcharges = false,
                    IsLogo = false,
                    IsCompanyInfo = false,
                    IsCustomerInfo = false,
                    IsSignature = false,
                    IsExpiration = false,
                    IsQuoteNumber = false,
                    ProductColumns = "UnitTest GetDeletedItems QuoteSection.ProductColumns",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetQuoteStandardClauses(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new QuoteStandardClaus() {
                    QuoteStandardClauseID = 1,
                    QuoteID = 1,
                    StandardClauseID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new QuoteStandardClaus() {
                    QuoteStandardClauseID = 1,
                    QuoteID = 1,
                    StandardClauseID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new QuoteStandardClaus() {
                    QuoteStandardClauseID = 2,
                    QuoteID = 1,
                    StandardClauseID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetQuoteStatuses(DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new QuoteStatus() {
                    QuoteStatusID = 1,
                    QuoteStatusName = "UnitTest GetDeletedItems QuoteStatus.QuoteStatusName",
                    SortOrder = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new QuoteStatus() {
                    QuoteStatusID = 1,
                    QuoteStatusName = "UnitTest GetDeletedItems QuoteStatus.QuoteStatusName",
                    SortOrder = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new QuoteStatus() {
                    QuoteStatusID = 2,
                    QuoteStatusName = "UnitTest GetDeletedItems QuoteStatus.QuoteStatusName",
                    SortOrder = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            
            return retVal.ToArray();
        }

        public object GetQuoteSurcharges(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new QuoteSurcharge() {
                    QuoteSurchargeID = 1,
                    QuoteID = 1,
                    SurchargeID = 1,
                    Rate = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new QuoteSurcharge() {
                    QuoteSurchargeID = 1,
                    QuoteID = 1,
                    SurchargeID = 1,
                    Rate = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new QuoteSurcharge() {
                    QuoteSurchargeID = 2,
                    QuoteID = 1,
                    SurchargeID = 1,
                    Rate = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetQuoteTypes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new QuoteType() {
                    QuoteTypeID = 1,
                    CompanyID = id,
                    QuoteTypeName = "UnitTest GetDeletedItems QuoteType.QuoteTypeName",
                    Section1 = "UnitTest GetDeletedItems QuoteType.Section1",
                    Section2 = "UnitTest GetDeletedItems QuoteType.Section2",
                    Section3 = "UnitTest GetDeletedItems QuoteType.Section3",
                    ImageLocation = "UnitTest GetDeletedItems QuoteType.ImageLocation",
                    Inactive = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new QuoteType() {
                    QuoteTypeID = 1,
                    CompanyID = id,
                    QuoteTypeName = "UnitTest GetDeletedItems QuoteType.QuoteTypeName",
                    Section1 = "UnitTest GetDeletedItems QuoteType.Section1",
                    Section2 = "UnitTest GetDeletedItems QuoteType.Section2",
                    Section3 = "UnitTest GetDeletedItems QuoteType.Section3",
                    ImageLocation = "UnitTest GetDeletedItems QuoteType.ImageLocation",
                    Inactive = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new QuoteType() {
                    QuoteTypeID = 2,
                    CompanyID = id,
                    QuoteTypeName = "UnitTest GetDeletedItems QuoteType.QuoteTypeName",
                    Section1 = "UnitTest GetDeletedItems QuoteType.Section1",
                    Section2 = "UnitTest GetDeletedItems QuoteType.Section2",
                    Section3 = "UnitTest GetDeletedItems QuoteType.Section3",
                    ImageLocation = "UnitTest GetDeletedItems QuoteType.ImageLocation",
                    Inactive = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetRoles(DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Role() {
                    RoleID = 1,
                    RoleDescription = "UnitTest GetDeletedItems Role.RoleDescription1",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                //  simulate getting all data
                var obj = new Role() {
                    RoleID = 1,
                    RoleDescription = "UnitTest GetDeletedItems Role.RoleDescription1",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Role() {
                    RoleID = 2,
                    RoleDescription = "UnitTest GetDeletedItems Role.RoleDescription2",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);                
            }
            return retVal.ToArray();
        }

        public object GetSalespersonContacts(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new SalespersonContact() {
                    SalesPersonContactID = 1,
                    SalesPersonID = 1,
                    ContactID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new SalespersonContact() {
                    SalesPersonContactID = 1,
                    SalesPersonID = 1,
                    ContactID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new SalespersonContact() {
                    SalesPersonContactID = 2,
                    SalesPersonID = 1,
                    ContactID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetSalesPersonRegions(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new SalesPersonRegion() {
                    SalesPersonRegionID = 1,
                    SalesPersonID = 1,
                    PlantID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new SalesPersonRegion() {
                    SalesPersonRegionID = 1,
                    SalesPersonID = 1,
                    PlantID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new SalesPersonRegion() {
                    SalesPersonRegionID = 2,
                    SalesPersonID = 1,
                    PlantID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetScheduleItems(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ScheduleItem() {
                    ScheduleItemID = 1,
                    ScheduleID = 1,
                    Quantity = 1,
                    Month = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ScheduleItem() {
                    ScheduleItemID = 1,
                    ScheduleID = 1,
                    Quantity = 1,
                    Month = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ScheduleItem() {
                    ScheduleItemID = 2,
                    ScheduleID = 1,
                    Quantity = 1,
                    Month = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetSchedules(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Schedule() {
                    ScheduleID = 1,
                    ProjectProductID = 1,
                    Active = true,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Schedule() {
                    ScheduleID = 1,
                    ProjectProductID = 1,
                    Active = true,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Schedule() {
                    ScheduleID = 2,
                    ProjectProductID = 1,
                    Active = true,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetSources(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Source() {
                    SourceID = 1,
                    CompanyID = id,
                    SourceName = "UnitTest GetDeletedItems Source.SourceName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Source() {
                    SourceID = 1,
                    CompanyID = id,
                    SourceName = "UnitTest GetDeletedItems Source.SourceName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Source() {
                    SourceID = 2,
                    CompanyID = id,
                    SourceName = "UnitTest GetDeletedItems Source.SourceName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    Inactive = false,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetSourceSystem(SourceSystem ss) {
            var retVal = new List<object>();
            var obj = new {
                ss.SourceSystemID,
                ss.SystemName,
                ss.MsModificationDate
            };
            retVal.Add(obj);
            return retVal.ToArray();
        }

        public object GetStandardClauses(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new StandardClaus() {
                    StandardClauseID = 1,
                    Name = "UnitTest GetDeletedItems StandardClaus.Name",
                    StandardClauseText = "UnitTest GetDeletedItems StandardClaus.StandardClauseText",
                    ProductLineID = 1,
                    PlantID = 1,
                    ProductID = 1,
                    Inactive = false,
                    CompanyID = id,
                    ProductUsageID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new StandardClaus() {
                    StandardClauseID = 1,
                    Name = "UnitTest GetDeletedItems StandardClaus.Name",
                    StandardClauseText = "UnitTest GetDeletedItems StandardClaus.StandardClauseText",
                    ProductLineID = 1,
                    PlantID = 1,
                    ProductID = 1,
                    Inactive = false,
                    CompanyID = id,
                    ProductUsageID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new StandardClaus() {
                    StandardClauseID = 2,
                    Name = "UnitTest GetDeletedItems StandardClaus.Name",
                    StandardClauseText = "UnitTest GetDeletedItems StandardClaus.StandardClauseText",
                    ProductLineID = 1,
                    PlantID = 1,
                    ProductID = 1,
                    Inactive = false,
                    CompanyID = id,
                    ProductUsageID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetStatuses(DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Status() {
                    StatusID = 1,
                    StatusName = "UnitTest GetDeletedItems Status.StatusName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Status() {
                    StatusID = 1,
                    StatusName = "UnitTest GetDeletedItems Status.StatusName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Status() {
                    StatusID = 2,
                    StatusName = "UnitTest GetDeletedItems Status.StatusName",
                    Inserted = DateTime.Now,
                    Modified = DateTime.Now,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetSurcharges(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Surcharge() {
                    SurchargeID = 1,
                    CompanyID = id,
                    SurchargeName = "UnitTest GetDeletedItems Surcharge.SurchargeName",
                    Rate = 1,
                    UOMID = 1,
                    Active = true,
                    QuoteDefault = true,
                    QuoteSelectable = true,
                    PlantID = 1,
                    LocalSurchargeID = "UnitTest GetDeletedItems Surcharge.LocalSurchargeID",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Surcharge() {
                    SurchargeID = 1,
                    CompanyID = id,
                    SurchargeName = "UnitTest GetDeletedItems Surcharge.SurchargeName",
                    Rate = 1,
                    UOMID = 1,
                    Active = true,
                    QuoteDefault = true,
                    QuoteSelectable = true,
                    PlantID = 1,
                    LocalSurchargeID = "UnitTest GetDeletedItems Surcharge.LocalSurchargeID",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Surcharge() {
                    SurchargeID = 2,
                    CompanyID = id,
                    SurchargeName = "UnitTest GetDeletedItems Surcharge.SurchargeName",
                    Rate = 1,
                    UOMID = 1,
                    Active = true,
                    QuoteDefault = true,
                    QuoteSelectable = true,
                    PlantID = 1,
                    LocalSurchargeID = "UnitTest GetDeletedItems Surcharge.LocalSurchargeID",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetTemplatedProducts(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new TemplatedProduct() {
                    TemplatedProductID = 1,
                    ProductTemplateID = 1,
                    ProductTypeID = 1,
                    ProductID = 1,
                    PlantID = 1,
                    ProductUsageID = 1,
                    LineOfBusinessID = 1,
                    ProductLineID = 1,
                    Qty = 1,
                    Price = 1,
                    Freight = 1,
                    FreightPay = 1,
                    Description = "UnitTest GetDeletedItems TemplatedProduct.Description",
                    IncludeInForecast = true,
                    Note = "UnitTest GetDeletedItems TemplatedProduct.Note",
                    Category = "UnitTest GetDeletedItems TemplatedProduct.Category",
                    MsModificationDate = DateTime.Now,
                    UOMID = 1,
                    PriceExtensionCode = "UnitTest GetDeletedItems TemplatedProduct.PriceExtensionCode",
                };
                retVal.Add(obj);
            } else {
                var obj = new TemplatedProduct() {
                    TemplatedProductID = 1,
                    ProductTemplateID = 1,
                    ProductTypeID = 1,
                    ProductID = 1,
                    PlantID = 1,
                    ProductUsageID = 1,
                    LineOfBusinessID = 1,
                    ProductLineID = 1,
                    Qty = 1,
                    Price = 1,
                    Freight = 1,
                    FreightPay = 1,
                    Description = "UnitTest GetDeletedItems TemplatedProduct.Description",
                    IncludeInForecast = true,
                    Note = "UnitTest GetDeletedItems TemplatedProduct.Note",
                    Category = "UnitTest GetDeletedItems TemplatedProduct.Category",
                    MsModificationDate = DateTime.Now,
                    UOMID = 1,
                    PriceExtensionCode = "UnitTest GetDeletedItems TemplatedProduct.PriceExtensionCode",
                };
                retVal.Add(obj);
                obj = new TemplatedProduct() {
                    TemplatedProductID = 2,
                    ProductTemplateID = 1,
                    ProductTypeID = 1,
                    ProductID = 1,
                    PlantID = 1,
                    ProductUsageID = 1,
                    LineOfBusinessID = 1,
                    ProductLineID = 1,
                    Qty = 1,
                    Price = 1,
                    Freight = 1,
                    FreightPay = 1,
                    Description = "UnitTest GetDeletedItems TemplatedProduct.Description",
                    IncludeInForecast = true,
                    Note = "UnitTest GetDeletedItems TemplatedProduct.Note",
                    Category = "UnitTest GetDeletedItems TemplatedProduct.Category",
                    MsModificationDate = DateTime.Now,
                    UOMID = 1,
                    PriceExtensionCode = "UnitTest GetDeletedItems TemplatedProduct.PriceExtensionCode",
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetTermsDiscount(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Terms_Discount() {
                    Terms_Discount_ID = 1,
                    CompanyID = id,
                    Discount_Days = 1,
                    Discount_Amount = 1,
                    Net_Days = 1,
                    Description = "UnitTest GetDeletedItems Terms_Discount.Description",
                    Discount_Taxes = true,
                    Percent_Flag = true,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Terms_Discount() {
                    Terms_Discount_ID = 1,
                    CompanyID = id,
                    Discount_Days = 1,
                    Discount_Amount = 1,
                    Net_Days = 1,
                    Description = "UnitTest GetDeletedItems Terms_Discount.Description",
                    Discount_Taxes = true,
                    Percent_Flag = true,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Terms_Discount() {
                    Terms_Discount_ID = 2,
                    CompanyID = id,
                    Discount_Days = 1,
                    Discount_Amount = 1,
                    Net_Days = 1,
                    Description = "UnitTest GetDeletedItems Terms_Discount.Description",
                    Discount_Taxes = true,
                    Percent_Flag = true,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetUnitsOfMeasure(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new Unit_Of_Measure() {
                    Unit_Of_Measure_ID = 1,
                    CompanyID = id,
                    Imperial_Description = "UnitTest GetDeletedItems Unit_Of_Measure.Imperial_Description",
                    Metric_Description = "UnitTest GetDeletedItems Unit_Of_Measure.Metric_Description",
                    Imperial_To_Metric_Conv_Factor = 1,
                    Conversion_Factor_Type_ID = 1,
                    Conversion_Factor_Value = 1,
                    ConnectionCode = "UnitTest GetDeletedItems Unit_Of_Measure.ConnectionCode",
                    UOM = "UnitTest GetDeletedItems Unit_Of_Measure.UOM",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new Unit_Of_Measure() {
                    Unit_Of_Measure_ID = 1,
                    CompanyID = id,
                    Imperial_Description = "UnitTest GetDeletedItems Unit_Of_Measure.Imperial_Description",
                    Metric_Description = "UnitTest GetDeletedItems Unit_Of_Measure.Metric_Description",
                    Imperial_To_Metric_Conv_Factor = 1,
                    Conversion_Factor_Type_ID = 1,
                    Conversion_Factor_Value = 1,
                    ConnectionCode = "UnitTest GetDeletedItems Unit_Of_Measure.ConnectionCode",
                    UOM = "UnitTest GetDeletedItems Unit_Of_Measure.UOM",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new Unit_Of_Measure() {
                    Unit_Of_Measure_ID = 2,
                    CompanyID = id,
                    Imperial_Description = "UnitTest GetDeletedItems Unit_Of_Measure.Imperial_Description",
                    Metric_Description = "UnitTest GetDeletedItems Unit_Of_Measure.Metric_Description",
                    Imperial_To_Metric_Conv_Factor = 1,
                    Conversion_Factor_Type_ID = 1,
                    Conversion_Factor_Value = 1,
                    ConnectionCode = "UnitTest GetDeletedItems Unit_Of_Measure.ConnectionCode",
                    UOM = "UnitTest GetDeletedItems Unit_Of_Measure.UOM",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetUserRoles(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new UserRole() {
                    UserRoleID = 1,
                    RoleID = 1,
                    UserID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new UserRole() {
                    UserRoleID = 1,
                    RoleID = 1,
                    UserID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new UserRole() {
                    UserRoleID = 2,
                    RoleID = 1,
                    UserID = 1,
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetUsers(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new User() {
                    UserID = 1,
                    CompanyID = id,
                    UserName = "UnitTest GetDeletedItems User.UserName",
                    FirstName = "UnitTest GetDeletedItems User.FirstName",
                    LastName = "UnitTest GetDeletedItems User.LastName",
                    Active = true,
                    InsertDate = DateTime.Now,
                    EmailAddress = "UnitTest GetDeletedItems User.EmailAddress",
                    Password = null,
                    CellPhoneNumber = "UnitTest GetDeletedItems User.CellPhoneNumber",
                    PhoneNumber = "UnitTest GetDeletedItems User.PhoneNumber",
                    FaxNumber = "UnitTest GetDeletedItems User.FaxNumber",
                    SalesmanCode = "UnitTest GetDeletedItems User.SalesmanCode",
                    ReportsToID = 1,
                    DeviationTypeID = 1,
                    DeviationAmount = 1,
                    Address1 = "UnitTest GetDeletedItems User.Address1",
                    Address2 = "UnitTest GetDeletedItems User.Address2",
                    City = "UnitTest GetDeletedItems User.City",
                    ST = "UnitTest GetDeletedItems User.ST",
                    Zip = "UnitTest GetDeletedItems User.Zip",
                    Latitude = 1,
                    Longitude = 1,
                    UsesSAML = false,
                    Country = "UnitTest GetDeletedItems User.Country",
                    DefaultMailMessage = "UnitTest GetDeletedItems User.DefaultMailMessage",
                    MsModificationDate = DateTime.Now,
                    AdministratorID = 1
                };
                retVal.Add(obj);
            } else {
                var obj = new User() {
                    UserID = 1,
                    CompanyID = id,
                    UserName = "UnitTest GetDeletedItems User.UserName",
                    FirstName = "UnitTest GetDeletedItems User.FirstName",
                    LastName = "UnitTest GetDeletedItems User.LastName",
                    Active = true,
                    InsertDate = DateTime.Now,
                    EmailAddress = "UnitTest GetDeletedItems User.EmailAddress",
                    Password = null,
                    CellPhoneNumber = "UnitTest GetDeletedItems User.CellPhoneNumber",
                    PhoneNumber = "UnitTest GetDeletedItems User.PhoneNumber",
                    FaxNumber = "UnitTest GetDeletedItems User.FaxNumber",
                    SalesmanCode = "UnitTest GetDeletedItems User.SalesmanCode",
                    ReportsToID = 1,
                    DeviationTypeID = 1,
                    DeviationAmount = 1,
                    Address1 = "UnitTest GetDeletedItems User.Address1",
                    Address2 = "UnitTest GetDeletedItems User.Address2",
                    City = "UnitTest GetDeletedItems User.City",
                    ST = "UnitTest GetDeletedItems User.ST",
                    Zip = "UnitTest GetDeletedItems User.Zip",
                    Latitude = 1,
                    Longitude = 1,
                    UsesSAML = false,
                    Country = "UnitTest GetDeletedItems User.Country",
                    DefaultMailMessage = "UnitTest GetDeletedItems User.DefaultMailMessage",
                    MsModificationDate = DateTime.Now,
                    AdministratorID = 1
                };
                retVal.Add(obj);
                obj = new User() {
                    UserID = 2,
                    CompanyID = id,
                    UserName = "UnitTest GetDeletedItems User.UserName",
                    FirstName = "UnitTest GetDeletedItems User.FirstName",
                    LastName = "UnitTest GetDeletedItems User.LastName",
                    Active = true,
                    InsertDate = DateTime.Now,
                    EmailAddress = "UnitTest GetDeletedItems User.EmailAddress",
                    Password = null,
                    CellPhoneNumber = "UnitTest GetDeletedItems User.CellPhoneNumber",
                    PhoneNumber = "UnitTest GetDeletedItems User.PhoneNumber",
                    FaxNumber = "UnitTest GetDeletedItems User.FaxNumber",
                    SalesmanCode = "UnitTest GetDeletedItems User.SalesmanCode",
                    ReportsToID = 1,
                    DeviationTypeID = 1,
                    DeviationAmount = 1,
                    Address1 = "UnitTest GetDeletedItems User.Address1",
                    Address2 = "UnitTest GetDeletedItems User.Address2",
                    City = "UnitTest GetDeletedItems User.City",
                    ST = "UnitTest GetDeletedItems User.ST",
                    Zip = "UnitTest GetDeletedItems User.Zip",
                    Latitude = 1,
                    Longitude = 1,
                    UsesSAML = false,
                    Country = "UnitTest GetDeletedItems User.Country",
                    DefaultMailMessage = "UnitTest GetDeletedItems User.DefaultMailMessage",
                    MsModificationDate = DateTime.Now,
                    AdministratorID = 1
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetVehicleTypes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new VehicleType() {
                    VehicleTypeID = 1,
                    CompanyID = id,
                    Description = "UnitTest GetDeletedItems VehicleType.Description",
                    Abbreviation = "UnitTest GetDeletedItems VehicleType.Abbreviation",
                    LocalVehicleTypeId = "UnitTest GetDeletedItems VehicleType.LocalVehicleTypeId",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new VehicleType() {
                    VehicleTypeID = 1,
                    CompanyID = id,
                    Description = "UnitTest GetDeletedItems VehicleType.Description",
                    Abbreviation = "UnitTest GetDeletedItems VehicleType.Abbreviation",
                    LocalVehicleTypeId = "UnitTest GetDeletedItems VehicleType.LocalVehicleTypeId",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new VehicleType() {
                    VehicleTypeID = 2,
                    CompanyID = id,
                    Description = "UnitTest GetDeletedItems VehicleType.Description",
                    Abbreviation = "UnitTest GetDeletedItems VehicleType.Abbreviation",
                    LocalVehicleTypeId = "UnitTest GetDeletedItems VehicleType.LocalVehicleTypeId",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetZoneCodes(int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var retVal = new List<object>();
            if (limitRecords) {
                var obj = new ZoneCode() {
                    ZoneCodeID = 1,
                    CompanyID = id,
                    ZoneCodeName = "UnitTest GetDeletedItems ZoneCode.ZoneCodeName",
                    SystemCode = "UnitTest GetDeletedItems ZoneCode.SystemCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            } else {
                var obj = new ZoneCode() {
                    ZoneCodeID = 1,
                    CompanyID = id,
                    ZoneCodeName = "UnitTest GetDeletedItems ZoneCode.ZoneCodeName",
                    SystemCode = "UnitTest GetDeletedItems ZoneCode.SystemCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
                obj = new ZoneCode() {
                    ZoneCodeID = 2,
                    CompanyID = id,
                    ZoneCodeName = "UnitTest GetDeletedItems ZoneCode.ZoneCodeName",
                    SystemCode = "UnitTest GetDeletedItems ZoneCode.SystemCode",
                    MsModificationDate = DateTime.Now
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public void WriteResults(ReturnDto obj, int runId) {
            //  nothing to unit test (actual method writes records to DB and returns void)
            return;
        }
    }
}
