using System;
using System.Collections.Generic;
using System.Linq;
using OracleCloud.DTOs;
using OracleCloud.Interfaces;
namespace OracleCloud.Repositories {
    public class OracleRepository : IOracleRepository {
        private int companyId;


        public int CompanyId {
            get { return companyId; }
            set { companyId = value; }
        }

        protected Entities DbContext {
            get;
            private set;
        }

        public OracleRepository() {
            DbContext = new Entities();
        }

        public Company GetCompanyInfo (int companyId) {
            return DbContext.Companies.Include("SourceSystem").Single(x => x.CompanyID == companyId);
        }

        public void Dispose() {
            DbContext.Dispose();
        }

        public object GetSourceSystem (SourceSystem ss) {
            var retVal = new List<object>();
            var obj = new {
                ss.SourceSystemID, ss.SystemName, ss.MsModificationDate
            };
            retVal.Add(obj);
            return retVal.ToArray();
        }

        public object GetRoles (DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Role> roles;
            if (limitRecords) {
                roles = DbContext.Roles
                    .Where(x => x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                roles = DbContext.Roles;
            }
            foreach (var item in roles) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Roles";
                rec.CompanyID = companyId;
                rec.KeyID = item.RoleID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (roles.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(roles.Select(role => new {
                role.RoleID, role.RoleDescription, role.MsModificationDate
            })).ToArray();
        }

        public object GetStatuses (DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Status> statuses;
            if (limitRecords) {
                statuses = DbContext.Statuses
                    .Where(x => x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                statuses = DbContext.Statuses;
            }
            foreach (var item in statuses) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Statuses";
                rec.CompanyID = companyId;
                rec.KeyID = item.StatusID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (statuses.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(statuses.Select(status => new {
                status.StatusID, status.StatusName, status.Inserted, status.Modified,
                status.MsModificationDate
            })).ToArray();
        }

        public object GetQuoteTypes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<QuoteType> quoteTypes;
            if (limitRecords) {
                quoteTypes = DbContext.QuoteTypes
                                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                quoteTypes = DbContext.QuoteTypes.Where(x => x.CompanyID == id);
            }
            foreach (var item in quoteTypes) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "QuoteTypes";
                rec.KeyID = item.QuoteTypeID;
                rec.CompanyID = id;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (quoteTypes.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(quoteTypes.Select(qt => new {
                qt.QuoteTypeID, qt.CompanyID, qt.QuoteTypeName, qt.Section1, qt.Section2, qt.Section3,
                qt.ImageLocation, qt.Inactive, qt.MsModificationDate
            })).ToArray();
        }

        public object GetQuoteStatuses (DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<QuoteStatus> quoteStatuses;
            if (limitRecords) {
                quoteStatuses = DbContext.QuoteStatuses
                        .Where(x => x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                quoteStatuses = DbContext.QuoteStatuses;
            }
            foreach (var item in quoteStatuses) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "QuoteStatuses";
                rec.CompanyID = companyId;
                rec.KeyID = item.QuoteStatusID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (quoteStatuses.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(quoteStatuses.Select(qs => new {
                qs.QuoteStatusID, qs.QuoteStatusName, qs.SortOrder,
                qs.MsModificationDate
            })).ToArray();
        }

        public object GetQuoteSections (DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<QuoteSection> quoteSecs;
            var retVal = new List<object>();
            if (limitRecords) {
                quoteSecs = DbContext.QuoteSections
                    .Where(x => x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                quoteSecs = DbContext.QuoteSections;
            }
            foreach (var item in quoteSecs) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "QuoteSections";
                rec.CompanyID = companyId;
                rec.KeyID = item.QuoteSectionID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (quoteSecs.Any()) {
                DbContext.SaveChanges();
            }
            foreach (var qs in quoteSecs) {
                var bytes = new byte[qs.SectionContent.Length*sizeof (char)];
                Buffer.BlockCopy(qs.SectionContent.ToCharArray(), 0, bytes, 0, bytes.Length);
                var obj = new {
                    qs.QuoteSectionID,
                    qs.QuoteTypeID,
                    SectionContent = bytes,
                    qs.PositionTop,
                    qs.PositionLeft,
                    qs.Height,
                    qs.Width,
                    qs.IsProducts,
                    qs.IsSurcharges,
                    qs.IsLogo,
                    qs.IsCompanyInfo,
                    qs.IsCustomerInfo,
                    qs.IsSignature,
                    qs.IsExpiration,
                    qs.IsQuoteNumber,
                    qs.ProductColumns,
                    qs.MsModificationDate
                };
                retVal.Add(obj);
            }
            return retVal.ToArray();
        }

        public object GetProjectChargeTypes (DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProjectChargeType> PCT;
            if (limitRecords) {
                PCT = DbContext.ProjectChargeTypes
                    .Where(x => x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                PCT = DbContext.ProjectChargeTypes;
            }
            foreach (var item in PCT) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectChargeTypes";
                rec.CompanyID = companyId;
                rec.KeyID = item.ChargeTypeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (PCT.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(PCT.Select(pct => new {
                pct.ChargeTypeID, pct.ChargeTypeName, pct.MsModificationDate
            })).ToArray();
        }

        public object GetProjectBidderStatuses (DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProjectBidderStatus> obj;
            if (limitRecords) {
                obj = DbContext.ProjectBidderStatuses
                    .Where(x => x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProjectBidderStatuses;    
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectBidderStatuses";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProjectBidderStatusID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProjectBidderStatusID,
                x.StatusName,
                x.MsModificationDate
            })).ToArray();
        }

        public object GetEventStatuses (DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<EventStatu> obj;
            if (limitRecords) {
                obj = DbContext.EventStatus
                    .Where(x => x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.EventStatus;    
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "EventStatus";
                rec.CompanyID = companyId;
                rec.KeyID = item.EventStatusID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.EventStatusID, x.EventStatus, x.MsModificationDate
            })).ToArray();
        }

        public object GetDeviationTypes (DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<DeviationType> obj;
            if (limitRecords) {
                obj = DbContext.DeviationTypes
                    .Where(x => x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.DeviationTypes;
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "DeviationTypes";
                rec.CompanyID = companyId;
                rec.KeyID = item.DeviationTypeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.DeviationTypeID, x.DeviationTypeName, x.MsModificationDate
            })).ToArray();
        }

        public object GetUnitsOfMeasure (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Unit_Of_Measure> obj;
            if (limitRecords) {
                obj = DbContext.Unit_Of_Measure
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Unit_Of_Measure.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Unit_Of_Measure";
                rec.CompanyID = id;
                rec.KeyID = item.Unit_Of_Measure_ID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.Unit_Of_Measure_ID, x.CompanyID, x.Imperial_Description,
                x.Metric_Description, x.Imperial_To_Metric_Conv_Factor,
                x.Conversion_Factor_Type_ID, x.Conversion_Factor_Value,
                x.ConnectionCode, x.UOM, x.MsModificationDate
            })).ToArray();
        }

        public object GetCompanies (Company c, int runId) {
            var obj = new List<object>();
            var o = new {
                c.CompanyID, c.CompanyName, c.Address1, c.Address2, c.City,
                c.ST, c.Zip, c.Phone1, c.Phone2, c.Fax, c.ServiceUrl, c.QuoteImage,
                c.SourceSystemID, c.ChannelID, c.InstanceID, c.CompanyCode,
                c.UsesCategories, c.MaxQuantity,// c.DefaultUomID.Value,
                c.Cert509, c.UsesSAML, c.TimeoutRedirect, c.ChangeProjectCode,
                c.UsesPriceIntegration, c.UsesSalesOrders, c.Country,
                c.MsModificationDate
            };
            obj.Add(o);
            var rec = DbContext.BI_Exports.Create();
            rec.RunID = runId;
            rec.TableName = "Companies";
            rec.KeyID = c.CompanyID;
            rec.CompanyID = companyId;
            rec.DateProcessed = DateTime.Today;
            rec.StartDate = DateTime.Today;
            rec.EndDate = DateTime.Today;
            rec.MsModificationDate = c.MsModificationDate;
            DbContext.BI_Exports.Add(rec);
            DbContext.SaveChanges();
            return obj.ToArray();
        }

        public object GetCompanyOrderStatuses (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<CompanyOrderStatus> obj;
            if (limitRecords) {
                obj = DbContext.CompanyOrderStatuses
                        .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.CompanyOrderStatuses.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "CompanyOrderStatuses";
                rec.CompanyID = companyId;
                rec.KeyID = item.CompanyOrderStatusID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.CompanyOrderStatusID, x.CompanyOrderStatusName,
                x.CompanyID, x.MsModificationDate
            })).ToArray();
        }

        public object GetCompanyProjectProductStatuses (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<CompanyProjectProductStatus> obj;
            if (limitRecords) {
                obj = DbContext.CompanyProjectProductStatuses
                        .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.CompanyProjectProductStatuses.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "CompanyProjectProductStatuses";
                rec.CompanyID = companyId;
                rec.KeyID = item.CompanyProjectProductStatusID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.CompanyProjectProductStatusID, x.CompanyProjectProductStatusName,
                x.CompanyID, x.MsModificationDate
            })).ToArray();
        }

        public object GetCompanyProjectStatuses (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<CompanyProjectStatus> obj;
            if (limitRecords) {
                obj = DbContext.CompanyProjectStatuses
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.CompanyProjectStatuses.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "CompanyProjectStatuses";
                rec.CompanyID = companyId;
                rec.KeyID = item.CompanyProjectStatusID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.CompanyProjectStatusID, x.CompanyProjectStatusName,
                x.CompanyID, x.MsModificationDate
            })).ToArray();
        }

        public object GetCompanyQuoteStatuses (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<CompanyQuoteStatus> obj;
            if (limitRecords) {
                obj = DbContext.CompanyQuoteStatuses
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.CompanyQuoteStatuses.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "CompanyQuoteStatuses";
                rec.CompanyID = companyId;
                rec.KeyID = item.CompanyQuoteStatusID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.CompanyQuoteStatusID, x.CompanyQuoteStatusName,
                x.CompanyID, x.MsModificationDate
            })).ToArray();
        }

        public object GetCreditStatuses (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<CreditStatus> obj;
            if (limitRecords) {
                obj = DbContext.CreditStatuses
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.CreditStatuses.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "CreditStatuses";
                rec.CompanyID = companyId;
                rec.KeyID = item.CreditStatusID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.CreditStatusID, x.CompanyID, x.Code, x.Description,
                x.ColorCode, x.MsModificationDate
            })).ToArray();
        }

        public object GetCustomerEventTypes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<CustomerEventType> obj;
            if (limitRecords) {
                obj = DbContext.CustomerEventTypes
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.CustomerEventTypes.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "CustomerEventTypes";
                rec.CompanyID = companyId;
                rec.KeyID = item.EventTypeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.EventTypeID, x.CompanyID, x.EventType, x.MsModificationDate
            })).ToArray();
        }

        public object GetCustomerTypes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<CustomerType> obj;
            if (limitRecords) {
                obj = DbContext.CustomerTypes
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.CustomerTypes.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "CustomerTypes";
                rec.CompanyID = companyId;
                rec.KeyID = item.CustomerTypeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.CustomerTypeID, x.CompanyID, x.CustomerTypeName, x.MsModificationDate
            })).ToArray();
        }

        public object GetDivisions (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Division> obj;
            if (limitRecords) {
                obj = DbContext.Divisions
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Divisions.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Divisions";
                rec.CompanyID = companyId;
                rec.KeyID = item.DivisionID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.DivisionID, x.DivisionName, x.CompanyID,
                x.Address1, x.Address2, x.City, x.ST, x.Zip, x.Country,
                x.MsModificationDate
            })).ToArray();
        }

        public object GetEventFrequency (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<EventFrequency> obj;
            if (limitRecords) {
                obj = DbContext.EventFrequencies
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.EventFrequencies.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "EventFrequency";
                rec.CompanyID = companyId;
                rec.KeyID = item.EventFrequencyID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.EventFrequencyID, x.CompanyID, x.EventFrequency1,
                x.MsModificationDate
            })).ToArray();
        }

        public object GetLinesOfBusiness (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<LinesOfBusiness> obj;
            if (limitRecords) {
                obj = DbContext.LinesOfBusiness
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.LinesOfBusiness.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "LinesOfBusiness";
                rec.CompanyID = companyId;
                rec.KeyID = item.LineOfBusinessID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.LineOfBusinessID, x.Name, x.CompanyID,
                x.LineOfBusinessCode, x.MsModificationDate
            })).ToArray();
        }

        public object GetLostReasons (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<LostReason> obj;
            if (limitRecords) {
                obj = DbContext.LostReasons
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.LostReasons.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "LostReasons";
                rec.CompanyID = companyId;
                rec.KeyID = item.LostReasonID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.LostReasonID, x.CompanyID, x.LostReason1,
                x.Inserted, x.Modified, x.MsModificationDate
            })).ToArray();
        }

        public object GetPaymentTerms (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<PaymentTerm> obj;
            if (limitRecords) {
                obj = DbContext.PaymentTerms
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.PaymentTerms.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "PaymentTerms";
                rec.CompanyID = companyId;
                rec.KeyID = item.Terms_Discount_ID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.Terms_Discount_ID, x.CompanyID, x.Description,
                x.MsModificationDate
            })).ToArray();
        }

        public object GetProjectMapQtyRanges (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProjectMapQtyRange> obj;
            if (limitRecords) {
                obj = DbContext.ProjectMapQtyRanges
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProjectMapQtyRanges.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectMapQtyRanges";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProjectMapQtyRangeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProjectMapQtyRangeID, x.CompanyID, x.Min, x.Max,
                x.DisplayText, x.MsModificationDate
            })).ToArray();
        }

        public object GetProjectTypes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProjectType> obj;
            if (limitRecords) {
                obj = DbContext.ProjectTypes
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProjectTypes.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectTypes";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProjectTypeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProjectTypeID, x.CompanyID, x.ConnectionCode,
                x.SANL_Code, x.ProjectTypeName, x.ShortName,
                x.Inserted, x.Modified, x.MsModificationDate
            })).ToArray();
        }

        public object GetSources (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Source> obj;
            if (limitRecords) {
                obj = DbContext.Sources
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Sources.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Sources";
                rec.CompanyID = companyId;
                rec.KeyID = item.SourceID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.SourceID, x.CompanyID, x.SourceName, x.Inserted, x.Modified,
                x.Inactive, x.MsModificationDate
            })).ToArray();
        }

        public object GetTermsDiscount (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Terms_Discount> obj;
            if (limitRecords) {
                obj = DbContext.Terms_Discount
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Terms_Discount.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Terms_Discount";
                rec.CompanyID = companyId;
                rec.KeyID = item.Terms_Discount_ID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.Terms_Discount_ID, x.CompanyID, x.Discount_Days,
                x.Discount_Amount, x.Net_Days, x.Description,
                x.Discount_Taxes, x.Percent_Flag, x.MsModificationDate
            })).ToArray();
        }

        public object GetVehicleTypes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<VehicleType> obj;
            if (limitRecords) {
                obj = DbContext.VehicleTypes
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.VehicleTypes.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "VehicleTypes";
                rec.CompanyID = companyId;
                rec.KeyID = item.VehicleTypeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.VehicleTypeID, x.CompanyID, x.Description, x.Abbreviation,
                x.LocalVehicleTypeId, x.MsModificationDate
            })).ToArray();
        }

        public object GetZoneCodes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ZoneCode> obj;
            if (limitRecords) {
                obj = DbContext.ZoneCodes
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ZoneCodes.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ZoneCodes";
                rec.CompanyID = companyId;
                rec.KeyID = item.ZoneCodeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ZoneCodeID, x.CompanyID, x.ZoneCodeName, x.SystemCode, x.MsModificationDate
            })).ToArray();
        }

        public object GetCompanyBidStatuses (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<CompanyBidStatus> obj;
            if (limitRecords) {
                obj = DbContext.CompanyBidStatuses
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.CompanyBidStatuses.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "CompanyBidStatuses";
                rec.CompanyID = companyId;
                rec.KeyID = item.CompanyBidStatusID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.CompanyBidStatusID, x.CompanyBidStatusName, x.CompanyID,
                x.SystemCode, x.MSStatusID, x.MsModificationDate
            })).ToArray();
        }

        public object GetPlants (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Plant> obj;
            if (limitRecords) {
                obj = DbContext.Plants
                    .Where(x => x.Division.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Plants.Where(x => x.Division.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Plants";
                rec.CompanyID = companyId;
                rec.KeyID = item.PlantID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.PlantID, x.Description, x.SystechCompNbr,
                x.CSPlantCode, x.CSShortName, x.CSPlantName, x.Inserted, x.Modified, 
                x.Inactive_Flag, x.DivisionID, x.LineOfBusinessID, x.PlantCost,
                x.DeliveryCost, x.MaterialCost, x.SGACost,
                x.Address1, x.Address2, x.City, x.State, x.Zip, x.Longitude,
                x.Latitude, x.Country, x.MsModificationDate
            })).ToArray();
        }

        public object GetPlantLinesOfBusiness (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<PlantLinesOfBusiness> obj;
            if (limitRecords) {
                obj = DbContext.PlantLinesOfBusiness
                                .Where(x => x.Plant.Division.CompanyID == id
                                        && x.LinesOfBusiness.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.PlantLinesOfBusiness
                                .Where(x => x.Plant.Division.CompanyID == id
                                        && x.LinesOfBusiness.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "PlantLinesOfBusiness";
                rec.CompanyID = companyId;
                rec.KeyID = item.PlantLineOfBusinessID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.PlantLineOfBusinessID,
                x.LineOfBusinessID,
                x.PlantID,
                x.MsModificationDate
            })).ToArray();
        }

        public object GetProductLines (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProductLine> obj;
            if (limitRecords) {
                obj = DbContext.ProductLines
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProductLines.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProductLines";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProductLineID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProductLineID, x.CompanyID, x.ProductLineCode, x.ProductLineName,
                x.Active, x.extProductLineCode, x.LineOfBusinessID, x.MsModificationDate
            })).ToArray();
        }

        public object GetProductTypes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProductType> obj;
            if (limitRecords) {
                obj = DbContext.ProductTypes
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProductTypes.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProductTypes";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProductTypeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProductTypeID, x.CompanyID, x.ProductTypeName,
                x.ProductTypeCode, x.ProductLineID, x.ListPrice, x.UOMID,
                x.Inactive, x.MsModificationDate
            })).ToArray();
        }

        public object GetProductUsage (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProductUsage> obj;
            if (limitRecords) {
                obj = DbContext.ProductUsages
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProductUsages.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProductUsages";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProductUsageID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProductUsageID, x.CompanyID, x.ProductUsageName,  x.ProductLineID, x.MsModificationDate
            })).ToArray();
        }

        public object GetSurcharges (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Surcharge> obj;
            if (limitRecords) {
                obj = DbContext.Surcharges
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Surcharges.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Surcharges";
                rec.CompanyID = companyId;
                rec.KeyID = item.SurchargeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.SurchargeID, x.CompanyID, x.SurchargeName, x.Rate, x.UOMID,
                x.Active, x.QuoteDefault, x.QuoteSelectable, x.PlantID,
                x.LocalSurchargeID, x.MsModificationDate
            })).ToArray();
        }

        public object GetProducts (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Product> obj;
            //List<Product> o = new List<Product>();
            if (limitRecords) {
                obj = DbContext.Products
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Products.Where(x => x.CompanyID == id).OrderBy(x => x.ProductID).Skip(0).Take(5000);
                //for (int i = 0; i < 5000; i++) {
                //    var item = (Product)obj.Skip(i).Take(1);
                //    o.Add(item);
                //}
            }
            //var y = new Exception("o.Count() = " + o.Count().ToString());
            //throw y;
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Products";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProductID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProductID, x.CompanyID, x.ProductName, x.Active, x.AU_ID, x.UnitOfMeasureID,
                x.ProductTypeID, x.ConnectionCode, x.ITEM_CAT, x.Product_Code, x.Inserted,
                x.Modified, x.extProduct_Code, x.IsSellable, x.MsModificationDate, x.ProductShortName
            })).ToArray();
        }

        public object GetPlantProductPrices (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<PlantProductPrice> obj;
            if (limitRecords) {
                obj = DbContext.PlantProductPrices
                                .Where(x => x.Plant.Division.CompanyID == id
                                        && x.Product.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.PlantProductPrices
                                .Where(x => x.Plant.Division.CompanyID == id
                                        && x.Product.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "PlantProductPrices";
                rec.CompanyID = companyId;
                rec.KeyID = item.PlantProductPriceID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.PlantProductPriceID, x.PlantID, x.ProductID, x.ListPrice, x.Description,
                x.PriceListID, x.MsModificationDate, x.PriceExtensionCode
            })).ToArray();
        }

        public object GetProjectCharges (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProjectCharge> obj;
            if (limitRecords) {
                obj = DbContext.ProjectCharges
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProjectCharges.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectCharges";
                rec.CompanyID = companyId;
                rec.KeyID = item.ChargeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ChargeID, x.ChargeName, x.ChargeType, x.ChargeCode, x.CompanyID, x.MsModificationDate
            })).ToArray();
        }

        public object GetStandardClauses (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<StandardClaus> obj;
            if (limitRecords) {
                obj = DbContext.StandardClauses
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.StandardClauses.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "StandardClauses";
                rec.CompanyID = companyId;
                rec.KeyID = item.StandardClauseID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.StandardClauseID, x.Name, x.StandardClauseText, x.ProductLineID, x.PlantID,
                x.ProductID, x.Inactive, x.CompanyID, x.ProductUsageID, x.MsModificationDate
            })).ToArray();
        }

        public object GetUsers (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<User> obj;
            if (limitRecords) {
                obj = DbContext.Users
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Users.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Users";
                rec.CompanyID = companyId;
                rec.KeyID = item.UserID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.UserID, x.CompanyID, x.UserName, x.FirstName, x.LastName, x.Active,
                x.InsertDate, x.EmailAddress, x.Password, x.CellPhoneNumber, x.PhoneNumber,
                x.FaxNumber, x.SalesmanCode, x.ReportsToID, x.DeviationTypeID, x.DeviationAmount,
                x.Address1, x.Address2, x.City, x.ST, x.Zip, x.Latitude, x.Longitude, x.UsesSAML,
                x.Country, x.DefaultMailMessage, x.MsModificationDate, x.AdministratorID
            })).ToArray();
        }

        public object GetUserRoles (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<UserRole> obj;
            if (limitRecords) {
                obj = DbContext.UserRoles
                    .Where(x => x.User.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.UserRoles.Where(x => x.User.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "UserRoles";
                rec.CompanyID = companyId;
                rec.KeyID = item.UserRoleID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.UserRoleID, x.RoleID, x.UserID, x.MsModificationDate
            })).ToArray();
        }

        public object GetCompanyUsers (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<CompanyUser> obj;
            if (limitRecords) {
                obj = DbContext.CompanyUsers
                                    .Where(x => x.CompanyID == id
                                            && x.User.CompanyID == id
                                            && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.CompanyUsers
                                    .Where(x => x.CompanyID == id
                                            && x.User.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "CompanyUsers";
                rec.CompanyID = companyId;
                rec.KeyID = item.CompanyUserID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.CompanyUserID, x.CompanyID, x.UserID, x.SalesmanCode, x.MsModificationDate
            })).ToArray();
        }

        public object GetCompetitors (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Competitor> obj;
            if (limitRecords) {
                obj = DbContext.Competitors
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Competitors.Where(x => x.User.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Competitors";
                rec.CompanyID = companyId;
                rec.KeyID = item.CompetitorID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.CompetitorID, x.CompanyID, x.CompetitorName, x.Inserted, x.Modified, x.Inactive,
                x.UserID, x.Address1, x.Address2, x.City, x.State, x.Zip, x.Longitude, x.Latitude,
                x.Country, x.MsModificationDate
            })).ToArray();
        }

        public object GetCompetitorPlants (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<CompetitorPlant> obj;
            if (limitRecords) {
                obj = DbContext.CompetitorPlants
                                .Where(x => x.Competitor.CompanyID == id
                                        && x.LinesOfBusiness.CompanyID == id
                                        && x.Division.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);

            } else {
                obj = DbContext.CompetitorPlants
                                .Where(x => x.Competitor.CompanyID == id
                                        && x.LinesOfBusiness.CompanyID == id
                                        && x.Division.CompanyID == id);

            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "CompetitorPlants";
                rec.CompanyID = companyId;
                rec.KeyID = item.CompetitorPlantID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.CompetitorPlantID, x.CompetitorID, x.PlantName, x.Inserted, x.Modified,
                x.Inactive_Flag, x.PlantCost, x.DeliveryCost, x.MaterialCost, x.SGACost,
                x.Address1, x.Address2, x.City, x.State, x.Zip, x.Longitude, x.Latitude,
                x.LineOfBusinessID, x.DivisionID, x.Country, x.MsModificationDate
            })).ToArray();
        }

        public object GetLogins (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Login> obj;
            if (limitRecords) {
                obj = DbContext.Logins
                    .Where(x => x.User.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Logins.Where(x => x.User.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Logins";
                rec.CompanyID = companyId;
                rec.KeyID = item.LoginID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.LoginID, x.UserID, x.LoginDate, x.MsModificationDate
            })).ToArray();
        }

        public object GetManagersSalesmen (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ManagersSalesman> obj;
            if (limitRecords) {
                obj = DbContext.ManagersSalesmen
                        .Where(x => x.User.CompanyID == id
                                    && x.User1.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ManagersSalesmen.Where(x => x.User.CompanyID == id
                                                        && x.User1.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ManagersSalesmen";
                rec.CompanyID = companyId;
                rec.KeyID = item.ManagerUserID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ManagerUserID, x.ManagerID, x.SalesmanID, x.MsModificationDate
            })).ToArray();
        }

        public object GetProductTemplates (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProductTemplate> obj;
            if (limitRecords) {
                obj = DbContext.ProductTemplates
                    .Where(x => x.CompanyUser.User.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProductTemplates.Where(x => x.CompanyUser.User.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProductTemplates";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProductTemplateID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProductTemplateID, x.TemplateName, x.CompanyUserID, x.Inactive, x.MsModificationDate, x.Shared
            })).ToArray();
        }

        public object GetTemplatedProducts (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<TemplatedProduct> obj;
            if (limitRecords) {
                obj = DbContext.TemplatedProducts
                                .Where(x => x.ProductTemplate.CompanyUser.User.CompanyID == id
                                            && x.MsModificationDate > startDate && x.MsModificationDate < endDate); 
            } else {
                obj = DbContext.TemplatedProducts
                                .Where(x => x.ProductTemplate.CompanyUser.User.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "TemplatedProducts";
                rec.CompanyID = companyId;
                rec.KeyID = item.TemplatedProductID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.TemplatedProductID, x.ProductTemplateID, x.ProductTypeID, x.ProductID, x.PlantID,
                x.ProductUsageID, x.LineOfBusinessID, x.ProductLineID, x.Qty, x.Price, x.Freight,
                x.FreightPay, x.Description, x.IncludeInForecast, x.Note, x.Category, x.MsModificationDate,
                x.UOMID, x.PriceExtensionCode
            })).ToArray();
        }

        public object GetProspects (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Prospect> obj;
            if (limitRecords) {
                obj = DbContext.Prospects
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Prospects.Where(x => x.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Prospects";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProspectID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProspectID, x.Private, x.OwnerID, x.CompanyID, x.ProspectName, x.Inserted, x.Modified,
                x.ProspectCode, x.ConnectionCode, x.LocalCustNumber, x.LocalCustName, x.IsCustomer,
                x.Credit_Status_ID, x.CustomerStatus, x.Sales, x.Margin, x.MaterialMargin, x.JobCount,
                x.Address1, x.Address2, x.City, x.State, x.Zip, x.Phone, x.HighestBalance, x.AvgInvoiceAmt,
                x.AvgDaysToPay, x.AvgDaysPastDue, x.TotalDue, x.ZeroTo30Days, x.ThirtyOneTo60Days,
                x.SixtyOneTo90Days, x.NinetyOneTo120Days, x.Over120Days, x.CustomerTypeID, 
                x.StatementFrequency, x.FinanceRate, x.PaymentTermsID, x.SalesmanCode, x.Fax,
                x.WebSite, x.AvgRevenue, x.NumberofEmployees, x.CompanyOriginDate, x.BusinessTypeID,
                x.Notes, x.Country, x.PORequired, x.MsModificationDate
            })).ToArray();
        }

        public object GetProspectNotes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProspectNote> obj;
            if (limitRecords) {
                obj = DbContext.ProspectNotes
                    .Where(x => x.Prospect.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProspectNotes.Where(x => x.Prospect.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProspectNotes";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProspectNoteID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProspectNoteID, x.ProspectID, x.Note, x.Inserted, x.CreatedBy, x.Subject,
                x.Source, x.MsModificationDate
            })).ToArray();
        }

        public object GetSalesPersonRegions (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<SalesPersonRegion> obj;
            if (limitRecords) {
                obj = DbContext.SalesPersonRegions
                                    .Where(x => x.User.CompanyID == id
                                            && x.Plant.Division.CompanyID == id
                                            && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.SalesPersonRegions
                                    .Where(x => x.User.CompanyID == id
                                            && x.Plant.Division.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "SalesPersonRegions";
                rec.CompanyID = companyId;
                rec.KeyID = item.SalesPersonRegionID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.SalesPersonRegionID, x.SalesPersonID, x.PlantID, x.MsModificationDate
            })).ToArray();
        }

        public object GetContacts (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Contact> obj;
            if (limitRecords) {
                obj = DbContext.Contacts
                    .Where(x => x.Prospect.CompanyID == id
                            && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Contacts.Where(x => x.Prospect.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Contacts";
                rec.CompanyID = companyId;
                rec.KeyID = item.ContactID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ContactID, x.Private, x.OwnerID, x.FirstName, x.LastName, x.Name, x.ProspectID,
                x.Email, x.MobilePhone, x.Phone, x.Fax, x.Address, x.FullName, x.Title,
                x.StartingYearatCompany, x.Department, x.Address2, x.City, x.State, x.Zip,
                x.Salutation, x.Notes, x.Inserted, x.Modified, x.Country,
                x.MsModificationDate
            })).ToArray();
        }

        public object GetContactNotes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ContactNote> obj;
            if (limitRecords) {
                obj = DbContext.ContactNotes
                    .Where(x => x.Contact.Prospect.CompanyID == id
                            && x.MsModificationDate > startDate && x.MsModificationDate < endDate);    
            } else {
                obj = DbContext.ContactNotes.Where(x => x.Contact.Prospect.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ContactNotes";
                rec.CompanyID = companyId;
                rec.KeyID = item.ContactNoteID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ContactNoteID, x.ContactID, x.Note, x.Inserted, x.CreatedBy, x.Subject,
                x.Source, x.MsModificationDate
            })).ToArray();
        }

        public object GetProjects (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Project> obj;
            if (limitRecords) {
                obj = DbContext.Projects
                                .Where(x => x.CompanyID == id
                                        && x.ProjectType.CompanyID == id
                                        && x.Source.CompanyID == id
                                        && x.User.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Projects
                                .Where(x => x.CompanyID == id
                                        && x.ProjectType.CompanyID == id
                                        && x.Source.CompanyID == id
                                        && x.User.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Projects";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProjectID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProjectID, x.Private, x.OwnerID, x.CompanyID, x.ProjectName, x.ProjectTypeID,
                x.StatusID, x.StatusChangeDate, x.SourceID, x.Active, x.Address1, x.Address2,
                x.City, x.County, x.State, x.ZipCode, x.PlantID, x.SalespersonID, x.BidDate,
                x.LostReasonID, x.LostToID, x.LostNote, x.Inserted, x.Modified, x.PrevStatus,
                x.Exported, x.WinningProjectBidderID, x.StartDate, x.EndDate, x.TotalYards,
                x.ConnectionCode, x.CustCode, x.ProjectCode, x.Longitude, x.Latitude, x.GeofenceID,
                x.Country, x.ProjectDescription, x.ZoneCodeID, x.MsModificationDate
            })).ToArray();
        }

        public object GetCustomerEvents (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<CustomerEvent> obj;
            if (limitRecords) {
                obj = DbContext.CustomerEvents
                                .Where(x => x.CustomerEventType.CompanyID == id
                                        && x.User.CompanyID == id
                                        //&& x.EventFrequency.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.CustomerEvents
                                .Where(x => x.CustomerEventType.CompanyID == id
                                        && x.User.CompanyID == id);
                                        //&& x.EventFrequency.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "CustomerEvents";
                rec.CompanyID = companyId;
                rec.KeyID = item.CustomerEventID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.CustomerEventID, x.Private, x.OwnerID, x.EventTypeID, x.EventStartDate,
                x.EventEndDate, x.CompletedDate, x.Description, x.ContactID, x.UserID,
                x.EventFrequencyID, x.ProjectID, x.MasterEventID, x.EventStatusID,
                x.Subject, x.ProspectID, x.RecurrenceEndDate, x.MsModificationDate
            })).ToArray();
        }

        public object GetProjectProducts (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProjectProduct> obj;
            if (limitRecords) {
                obj = DbContext.ProjectProducts
                    .Where(x => x.Project.CompanyID == id
                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProjectProducts.Where(x => x.Project.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectProducts";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProjectProductID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProjectProductID, x.ProjectID, x.Qty, x.UOMID, x.Inserted, x.Modified, x.Price,
                x.ProductLineID, x.ProductTypeID, x.ProductID, x.PsiID, x.ProductUsageID,
                x.Note, x.Forecasted, x.PlantID, x.Freight, x.FreightPay, x.CompetitorPrice,
                x.Category, x.Description, x.LineOfBusinessID, x.StatusID, x.MsModificationDate,
                x.PriceExtensionCode, x.LostReasonID, x.LostToID, x.LostNote
            })).ToArray();
        }

        public object GetSchedules (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Schedule> obj;
            if (limitRecords) {
                obj = DbContext.Schedules
                    .Where(x => x.ProjectProduct.Project.CompanyID == id
                            && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Schedules.Where(x => x.ProjectProduct.Project.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Schedules";
                rec.CompanyID = companyId;
                rec.KeyID = item.ScheduleID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ScheduleID, x.ProjectProductID, x.Active, x.MsModificationDate
            })).ToArray();
        }

        public object GetScheduleItems (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ScheduleItem> obj;
            if (limitRecords) {
                obj = DbContext.ScheduleItems
                                    .Where(x => x.Schedule.ProjectProduct.Project.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ScheduleItems
                                    .Where(x => x.Schedule.ProjectProduct.Project.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ScheduleItems";
                rec.CompanyID = companyId;
                rec.KeyID = item.ScheduleItemID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ScheduleItemID, x.ScheduleID, x.Quantity, x.Month, x.MsModificationDate
            })).ToArray();
        }

        public object GetSalespersonContacts (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<SalespersonContact> obj;
            if (limitRecords) {
                obj = DbContext.SalespersonContacts
                                    .Where(x => x.User.CompanyID == id
                                            && x.Contact.Prospect.CompanyID == id
                                            && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.SalespersonContacts
                                    .Where(x => x.User.CompanyID == id
                                            && x.Contact.Prospect.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "SalespersonContacts";
                rec.CompanyID = companyId;
                rec.KeyID = item.SalesPersonContactID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.SalesPersonContactID, x.SalesPersonID, x.ContactID, x.MsModificationDate
            })).ToArray();
        }

        public object GetProjectNotes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProjectNote> obj;
            if (limitRecords) {
                obj = DbContext.ProjectNotes
                    .Where(x => x.Project.CompanyID == id
                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProjectNotes.Where(x => x.Project.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectNotes";
                rec.CompanyID = companyId;
                rec.KeyID = item.NoteID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.NoteID, x.ProjectID, x.Note, x.Inserted, x.CreatedBy, x.MsModificationDate
            })).ToArray();
        }

        public object GetProjectBidders (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProjectBidder> obj;
            if (limitRecords) {
                obj = DbContext.ProjectBidders
                                .Where(x => x.Project.CompanyID == id
                                        && x.Prospect.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProjectBidders
                                .Where(x => x.Project.CompanyID == id
                                        && x.Prospect.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectBidders";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProjectBidderID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProjectBidderID, x.ProjectID, x.ProspectID, x.Quoted, x.StatusSub,
                x.QuoteDate, x.NotLIkeLIst, x.StatusID, x.PlantID, x.ProjectCode, x.StartDate,
                x.EndDate, x.PONumber, x.MinLoadCharge, x.SundryCharge, x.SeasonalCharge,
                x.UnloadCharge, x.CustJobNbr, x.MsModificationDate, x.EffectiveDate
            })).ToArray();
        }

        public object GetProjectBidderProducts (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProjectBidderProduct> obj;
            if (limitRecords) {
                obj = DbContext.ProjectBidderProducts
                                .Where(x => x.ProjectBidder.Project.CompanyID == id
                                        && x.ProjectProduct.Project.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProjectBidderProducts
                                .Where(x => x.ProjectBidder.Project.CompanyID == id
                                        && x.ProjectProduct.Project.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectBidderProducts";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProjectBidderProductID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProjectBidderProductID, x.ProjectBidderID, x.ProjectProductID, x.Price,
                x.Inserted, x.Modified, x.SameAsList, x.Forecasted, x.Freight, x.FreightPay,
                x.ListPrice, x.CustomerPrice, x.Exported, x.Quantity, x.StatusID, x.LineNbr,
                x.MsModificationDate, x.PreviousPrice, x.PreviousDeliveredPrice
            })).ToArray();
        }

        public object GetProjectBidderNotes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProjectBidderNote> obj;
            if (limitRecords) {
                obj = DbContext.ProjectBidderNotes
                                .Where(x => x.ProjectBidder.Project.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProjectBidderNotes
                                .Where(x => x.ProjectBidder.Project.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectBidderNotes";
                rec.CompanyID = companyId;
                rec.KeyID = item.NoteID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.NoteID, x.ProjectBidderID, x.Note, x.Inserted, x.CreatedBy, x.MsModificationDate
            })).ToArray();
        }

        public object GetProjectBidderCharges (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<ProjectBidderCharge> obj;
            if (limitRecords) {
                obj = DbContext.ProjectBidderCharges
                                .Where(x => x.ProjectBidder.Project.CompanyID == id
                                        && x.ProjectCharge.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.ProjectBidderCharges
                                .Where(x => x.ProjectBidder.Project.CompanyID == id
                                        && x.ProjectCharge.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectBidderCharges";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProjectBidderChargeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProjectBidderChargeID, x.ProjectBidderID,
                x.ProductLineID, x.ProjectChargeID, x.MsModificationDate
            })).ToArray();
        }

        public object GetOrders (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Order> obj;
            if (limitRecords) {
                obj = DbContext.Orders
                    .Where(x => x.CompanyID == id
                                    && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Orders.Where(x => x.CompanyID == id);
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.OrderID, x.CompanyID, x.ProjectID, x.year, x.month, x.YardsActual, x.MaterialCost,
                x.DollarsActual, x.OrderDate, x.ShipDate, x.YardsTicketed, x.OnJobTime, x.LocationID,
                x.ProspectID, x.DispatchOrderID, x.DispatchOrderNumber, x.SalesmanCode, x.Inserted,
                x.Modified, x.MsModificationDate
            })).ToArray();
        }

        public object GetOrderDetails (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<OrderDetail> obj;
            if (limitRecords) {
                obj = DbContext.OrderDetails
                                .Where(x => x.Order.CompanyID == id
                                        && x.Product.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.OrderDetails
                                .Where(x => x.Order.CompanyID == id
                                        && x.Product.CompanyID == id);
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.OrderDetailID, x.OrderID, x.ProductID, x.Quantity, x.UnitPrice, x.Mix, x.MsModificationDate
            })).ToArray();
        }

        public object GetQuotes (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<Quote> obj;
            if (limitRecords) {
                obj = DbContext.Quotes
                                .Where(x => x.ProjectBidder.Project.CompanyID == id
                                        && x.QuoteType.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.Quotes
                                .Where(x => x.ProjectBidder.Project.CompanyID == id
                                        && x.QuoteType.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "Quotes";
                rec.CompanyID = companyId;
                rec.KeyID = item.QuoteID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.QuoteID, x.ProjectBidderID, x.ContactID, x.TermsID, x.Attention, x.Phone, x.CellPhone,
                x.Fax, x.Email, x.QuoteDate, x.FirmUntilDate, x.QuoteSequenceNumber, x.QuoteTypeID,
                x.DateCreated, x.DateLastModified, x.CustomerQuoteID, x.Exported, x.EscalationDate,
                x.QuoteNote, x.EscalationAmount, x.QuoteStatusID, x.Notes, x.CreatedByID, x.OrderDate,
                x.StartOrderDate, x.ExpireOrderDate, x.VehicleTypeID_1, x.VehicleTypeID_2,
                x.VehicleTypeID_3, x.VehicleTypeID_4, x.VehicleTypeID_5, x.CustomerOrderID,
                x.PurchaseOrder, x.BeginDate, x.AllowBeforeStart, x.AllowAfterEnd, x.AllowExceedQty,
                x.AllowExceedLoads, x.AllowAfterComplete, x.MsModificationDate, x.SalespersonID, x.ApexNoteID
            })).ToArray();
        }

        public object GetQuoteDetails (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<QuoteDetail> obj;
            if (limitRecords) {
                obj = DbContext.QuoteDetails
                                .Where(x => x.Quote.ProjectBidder.Project.CompanyID == id
                                        && x.Quote.QuoteType.CompanyID == id
                                        && x.ProjectProduct.Project.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.QuoteDetails
                                .Where(x => x.Quote.ProjectBidder.Project.CompanyID == id
                                        && x.Quote.QuoteType.CompanyID == id
                                        && x.ProjectProduct.Project.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "QuoteDetails";
                rec.CompanyID = companyId;
                rec.KeyID = item.QuoteDetailID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.QuoteDetailID, x.QuoteID, x.ProjectProductID, x.Price, x.Qty, x.Freight, x.FreightPay,
                x.ListPrice, x.CustomerPrice, x.MsModificationDate
            })).ToArray();
        }

        public object GetQuoteStandardClauses (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<QuoteStandardClaus> obj;
            if (limitRecords) {
                obj = DbContext.QuoteStandardClauses
                                .Where(x => x.Quote.ProjectBidder.Project.CompanyID == id
                                        && x.StandardClaus.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.QuoteStandardClauses
                                .Where(x => x.Quote.ProjectBidder.Project.CompanyID == id
                                        && x.StandardClaus.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "QuoteStandardClauses";
                rec.CompanyID = companyId;
                rec.KeyID = item.QuoteStandardClauseID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.QuoteStandardClauseID, x.QuoteID, x.StandardClauseID, x.MsModificationDate
            })).ToArray();
        }

        public object GetQuoteSurcharges (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            IQueryable<QuoteSurcharge> obj;
            if (limitRecords) {
                obj = DbContext.QuoteSurcharges
                                .Where(x => x.Quote.ProjectBidder.Project.CompanyID == id
                                        && x.Surcharge.CompanyID == id
                                        && x.MsModificationDate > startDate && x.MsModificationDate < endDate);
            } else {
                obj = DbContext.QuoteSurcharges
                                .Where(x => x.Quote.ProjectBidder.Project.CompanyID == id
                                        && x.Surcharge.CompanyID == id);
            }
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "QuoteSurcharges";
                rec.CompanyID = companyId;
                rec.KeyID = item.QuoteSurchargeID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.QuoteSurchargeID, x.QuoteID, x.SurchargeID, x.Rate, x.MsModificationDate
            })).ToArray();
        }



        public object GetDeletedItems (int id, DateTime startDate, DateTime endDate, int runId) {
            var obj = DbContext.DeletedItems
                                .Where(x => x.CompanyID == id
                                        && x.DateDeleted > startDate
                                        && x.DateDeleted < endDate);
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "DeletedItems/" + item.TableName;
                rec.CompanyID = id;
                rec.KeyID = item.KeyID;
                rec.DateProcessed = DateTime.Today;
                rec.StartDate = startDate;
                rec.EndDate = endDate;
                rec.MsModificationDate = item.DateDeleted;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.KeyID,
                x.TableName
            })).ToArray();
        }

        public object GetProjectDistances (int id, DateTime startDate, DateTime endDate, bool limitRecords, int runId) {
            var obj = DbContext.ProjectDistances
                                .Where(x => x.Project.CompanyID == id
                                        && x.MsModificationDate > startDate
                                        && x.MsModificationDate < endDate);
            foreach (var item in obj) {
                var rec = DbContext.BI_Exports.Create();
                rec.RunID = runId;
                rec.TableName = "ProjectDistances";
                rec.CompanyID = companyId;
                rec.KeyID = item.ProjectDistanceID;
                rec.DateProcessed = DateTime.Today;
                if (limitRecords) {
                    rec.StartDate = startDate;
                    rec.EndDate = endDate;
                } else {
                    rec.StartDate = new DateTime(1900, 1, 1);
                    rec.EndDate = new DateTime(2100, 1, 1);
                }
                rec.MsModificationDate = item.MsModificationDate;
                DbContext.BI_Exports.Add(rec);
            }
            if (obj.Any()) {
                DbContext.SaveChanges();
            }
            return Enumerable.Cast<object>(obj.Select(x => new {
                x.ProjectDistanceID, x.ProjectID, x.PlantID, x.Miles, x.Kilometers, x.MsModificationDate
            })).ToArray();
        }

        public int GetNextRunId() {
            if (DbContext.BI_Exports.Count() > 0) {
                return DbContext.BI_Exports.Max(x => x.RunID) + 1;
            }
            return 1;
        }

        public void WriteResults(ReturnDto obj, int runId) {
            if (obj.ResultDto.Records.Any()) {
                foreach (var item in obj.ResultDto.Records) {
                    var rec = DbContext.BI_Results.Create();
                    rec.RunID = runId;
                    rec.TableName = item.TableName;
                    rec.RecordsCount = item.RecordCount;
                    rec.RecordsProcessed = item.RecordsProcessed;
                    rec.Message = item.Message;
                    rec.DateProcessed = DateTime.Now;
                    DbContext.BI_Results.Add(rec);
                }
                DbContext.SaveChanges();
            }
        }
    }
}
