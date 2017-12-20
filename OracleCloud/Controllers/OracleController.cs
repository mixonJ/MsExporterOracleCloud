using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Net;
using OracleCloud.Code;
using OracleCloud.Repositories;
using OracleCloud.DTOs;
using OracleCloud.Interfaces;

namespace OracleCloud.Controllers {
    public class OracleController : ApiController {

        #region Private Methods

        private int GetYesterdayYear(int todayYear, int todayMonth, int todayDay) {
            var retVal = 0;
            switch (todayMonth) {
                case 1:
                    switch (todayDay) {
                        case 1:
                            retVal = todayYear - 1;
                            break;
                        default:
                            retVal = todayYear;
                            break;
                    }
                    break;
                default:
                    retVal = todayYear;
                    break;
            }
            return retVal;
        }

        private int GetYesterdayMonth(int todayYear, int todayMonth, int todayDay, int yesterdayYear, out int yesterdayDay) {
            if (todayYear - yesterdayYear == 1) {
                yesterdayDay = 31;
                return 12;
            }
            switch (todayDay) {
                case 1:
                    yesterdayDay = DateTime.DaysInMonth(todayYear, todayMonth - 1);
                    return todayMonth - 1;
                default:
                    yesterdayDay = todayDay - 1;
                    return todayMonth;
            }
        }

        private int GetTomorrowDay(int tomorrowYear, int tomorrowMonth, int todayDay) {
            var daysInMonth = DateTime.DaysInMonth(tomorrowYear, tomorrowMonth);
            if (todayDay == daysInMonth) {
                return 1;
            }
            return todayDay + 1;
        }

        private OracleObject LoadOracleObject(bool limitResults, string key, int companyId, DateTime startDate, DateTime endDate, IOracleRepository oRep, int runId) {
            //var todayYear = DateTime.Today.Year;
            //var todayMonth = DateTime.Today.Month;
            //var todayDay = DateTime.Today.Day;
            //var yesterdayYear = GetYesterdayYear(todayYear, todayMonth, todayDay);
            //var yesterdayDay = 0;
            //var yesterdayMonth = GetYesterdayMonth(todayYear, todayMonth, todayDay, yesterdayYear, out yesterdayDay);
            //var tomorrowYear = DateTime.Today.AddDays(1).Year;
            //var tomorrowMonth = DateTime.Today.AddDays(1).Month;
            ////var tomorrowDay = GetTomorrowDay(tomorrowYear, tomorrowMonth, todayDay);
            //var tomorrowDay = GetTomorrowDay(todayYear, todayMonth, todayDay);
            //var yesterday = new DateTime(yesterdayYear, yesterdayMonth, yesterdayDay);
            //var tomorrow = new DateTime(tomorrowYear, tomorrowMonth, tomorrowDay);            
            //if (!string.IsNullOrEmpty(date) && date.Length == 10) {
            //    todayMonth = int.Parse(date.Substring(0, 2));
            //    todayDay = int.Parse(date.Substring(3, 2));
            //    todayYear = int.Parse(date.Substring(6));
            //    var today = new DateTime(todayYear, todayMonth, todayDay);
            //    yesterdayYear = GetYesterdayYear(todayYear, todayMonth, todayDay);
            //    yesterdayDay = 0;
            //    yesterdayMonth = GetYesterdayMonth(todayYear, todayMonth, todayDay, yesterdayYear, out yesterdayDay);
            //    tomorrowYear = today.AddDays(1).Year;
            //    tomorrowMonth = today.AddDays(1).Month;
            //    tomorrowDay = GetTomorrowDay(todayYear, todayMonth, todayDay);
            //    yesterday = new DateTime(yesterdayYear, yesterdayMonth, yesterdayDay);
            //    tomorrow = new DateTime(tomorrowYear, tomorrowMonth, tomorrowDay);
            //}
            var oraObj = new OracleObject();

            var dates = new List<object>();
            //var obj = new {
            //    Yesterday = yesterday,
            //    Tomorrow = tomorrow,
            //    Key = key
            //};
            var obj = new {
                StartDate = startDate,
                EndDate = endDate,
                Key = key
            };
            dates.Add(obj);  //1
            
            var company = oRep.GetCompanyInfo(companyId);
            var ss = oRep.GetSourceSystem(company.SourceSystem);
            var id = company.CompanyID;
            oRep.CompanyId = id;
            //0
            oraObj.Dates = dates.ToArray();
            //1
            oraObj.DeletedItems = oRep.GetDeletedItems(id, startDate, endDate, runId);
            //oraObj.DeletedItems = new object();
            //2
            oraObj.SourceSystem = ss;
            //oraObj.SourceSystem = new object();
            //3
            oraObj.Roles = oRep.GetRoles(startDate, endDate, limitResults, runId);
            //oraObj.Roles = new object();
            //4
            oraObj.Statuses = oRep.GetStatuses(startDate, endDate, limitResults, runId);
            //oraObj.Statuses = new object();
            //5
            oraObj.QuoteStatuses = oRep.GetQuoteStatuses(startDate, endDate, limitResults, runId);
            //oraObj.QuoteStatuses = new object();
            //6
            oraObj.QuoteSections = oRep.GetQuoteSections(startDate, endDate, limitResults, runId);
            //oraObj.QuoteSections = new object();
            //7
            oraObj.ProjectChargeTypes = oRep.GetProjectChargeTypes(startDate, endDate, limitResults, runId);
            //oraObj.ProjectChargeTypes = new object();
            //8
            oraObj.ProjectBidderStatuses = oRep.GetProjectBidderStatuses(startDate, endDate, limitResults, runId);
            //oraObj.ProjectBidderStatuses = new object();
            //9
            oraObj.EventStatus = oRep.GetEventStatuses(startDate, endDate, limitResults, runId);
            //oraObj.EventStatus = new object();
            //10
            oraObj.DeviationTypes = oRep.GetDeviationTypes(startDate, endDate, limitResults, runId);
            //oraObj.DeviationTypes = new object();
            //11
            oraObj.Companies = oRep.GetCompanies(company, runId);
            //oraObj.Companies = new object();
            //12
            oraObj.Unit_Of_Measure = oRep.GetUnitsOfMeasure(id, startDate, endDate, limitResults, runId);
            //oraObj.Unit_Of_Measure = new object();
            //13
            oraObj.QuoteTypes = oRep.GetQuoteTypes(id, startDate, endDate, limitResults, runId);
            //oraObj.QuoteTypes = new object();
            //14
            oraObj.CompanyOrderStatuses = oRep.GetCompanyOrderStatuses(id, startDate, endDate, limitResults, runId);
            //oraObj.CompanyOrderStatuses = new object();
            //15
            oraObj.CompanyProjectProductStatuses = oRep.GetCompanyProjectProductStatuses(id, startDate, endDate, limitResults, runId);
            //oraObj.CompanyProjectProductStatuses = new object();
            //16
            oraObj.CompanyProjectStatuses = oRep.GetCompanyProjectStatuses(id, startDate, endDate, limitResults, runId);
            //oraObj.CompanyProjectStatuses = new object();
            //17
            oraObj.CompanyQuoteStatuses = oRep.GetCompanyQuoteStatuses(id, startDate, endDate, limitResults, runId);
            //oraObj.CompanyQuoteStatuses = new object();
            //18
            oraObj.CreditStatuses = oRep.GetCreditStatuses(id, startDate, endDate, limitResults, runId);
            //oraObj.CreditStatuses = new object();
            //19
            oraObj.CustomerEventTypes = oRep.GetCustomerEventTypes(id, startDate, endDate, limitResults, runId);
            //oraObj.CustomerEventTypes = new object();
            //20
            oraObj.CustomerTypes = oRep.GetCustomerTypes(id, startDate, endDate, limitResults, runId);
            //oraObj.CustomerTypes = new object();
            //21
            oraObj.Divisions = oRep.GetDivisions(id, startDate, endDate, limitResults, runId);
            //oraObj.Divisions = new object();
            //22
            oraObj.EventFrequency = oRep.GetEventFrequency(id, startDate, endDate, limitResults, runId);
            //oraObj.EventFrequency = new object();
            //23
            oraObj.LinesOfBusiness = oRep.GetLinesOfBusiness(id, startDate, endDate, limitResults, runId);
            //oraObj.LinesOfBusiness = new object();
            //24
            oraObj.LostReasons = oRep.GetLostReasons(id, startDate, endDate, limitResults, runId);
            //oraObj.LostReasons = new object();
            //25
            oraObj.PaymentTerms = oRep.GetPaymentTerms(id, startDate, endDate, limitResults, runId);
            //oraObj.PaymentTerms = new object();
            //26
            oraObj.ProjectMapQtyRanges = oRep.GetProjectMapQtyRanges(id, startDate, endDate, limitResults, runId);
            //oraObj.ProjectMapQtyRanges = new object();
            //27
            oraObj.ProjectTypes = oRep.GetProjectTypes(id, startDate, endDate, limitResults, runId);
            //oraObj.ProjectTypes = new object();
            //28
            oraObj.Sources = oRep.GetSources(id, startDate, endDate, limitResults, runId);
            //oraObj.Sources = new object();
            //29
            oraObj.Terms_Discount = oRep.GetTermsDiscount(id, startDate, endDate, limitResults, runId);
            //oraObj.Terms_Discount = new object();
            //30
            oraObj.VehicleTypes = oRep.GetVehicleTypes(id, startDate, endDate, limitResults, runId);
            //oraObj.VehicleTypes = new object();
            //31
            oraObj.ZoneCodes = oRep.GetZoneCodes(id, startDate, endDate, limitResults, runId);
            //oraObj.ZoneCodes = new object();
            //32
            oraObj.CompanyBidStatuses = oRep.GetCompanyBidStatuses(id, startDate, endDate, limitResults, runId);
            //oraObj.CompanyBidStatuses = new object();
            //33
            oraObj.Plant = oRep.GetPlants(id, startDate, endDate, limitResults, runId);
            //oraObj.Plant = new object();
            //34
            oraObj.PlantLinesOfBusiness = oRep.GetPlantLinesOfBusiness(id, startDate, endDate, limitResults, runId);
            //oraObj.PlantLinesOfBusiness = new object();
            //35
            oraObj.ProductLines = oRep.GetProductLines(id, startDate, endDate, limitResults, runId);
            //oraObj.ProductLines = new object();
            //36
            oraObj.ProductTypes = oRep.GetProductTypes(id, startDate, endDate, limitResults, runId);
            //oraObj.ProductTypes = new object();
            //37
            oraObj.ProductUsage = oRep.GetProductUsage(id, startDate, endDate, limitResults, runId);
            //oraObj.ProductUsage = new object();
            //38
            oraObj.Surcharges = oRep.GetSurcharges(id, startDate, endDate, limitResults, runId);
            //oraObj.Surcharges = new object();
            //39
            oraObj.Product = oRep.GetProducts(id, startDate, endDate, limitResults, runId);
            //oraObj.Product = new object();
            //40
            oraObj.PlantProductPrices = oRep.GetPlantProductPrices(id, startDate, endDate, limitResults, runId);
            //oraObj.PlantProductPrices = new object();
            //41
            oraObj.ProjectCharges = oRep.GetProjectCharges(id, startDate, endDate, limitResults, runId);
            //oraObj.ProjectCharges = new object();
            //42
            oraObj.StandardClauses = oRep.GetStandardClauses(id, startDate, endDate, limitResults, runId);
            //oraObj.StandardClauses = new object();
            //43
            oraObj.Users = oRep.GetUsers(id, startDate, endDate, limitResults, runId);
            //oraObj.Users = new object();
            //44
            oraObj.UserRoles = oRep.GetUserRoles(id, startDate, endDate, limitResults, runId);
            //oraObj.UserRoles = new object();
            //45
            oraObj.CompanyUsers = oRep.GetCompanyUsers(id, startDate, endDate, limitResults, runId);
            //oraObj.CompanyUsers = new object();
            //46
            oraObj.Competitors = oRep.GetCompetitors(id, startDate, endDate, limitResults, runId);
            //oraObj.Competitors = new object();
            //47
            oraObj.CompetitorPlants = oRep.GetCompetitorPlants(id, startDate, endDate, limitResults, runId);
            //oraObj.CompetitorPlants = new object();
            //48
            oraObj.Logins = oRep.GetLogins(id, startDate, endDate, limitResults, runId);
            //oraObj.Logins = new object();
            //49
            oraObj.ManagersSalesmen = oRep.GetManagersSalesmen(id, startDate, endDate, limitResults, runId);
            //oraObj.ManagersSalesmen = new object();
            //50
            oraObj.ProductTemplates = oRep.GetProductTemplates(id, startDate, endDate, limitResults, runId);
            //oraObj.ProductTemplates = new object();
            //51
            oraObj.TemplatedProducts = oRep.GetTemplatedProducts(id, startDate, endDate, limitResults, runId);
            //oraObj.TemplatedProducts = new object();
            //52
            oraObj.Prospects = oRep.GetProspects(id, startDate, endDate, limitResults, runId);
            //oraObj.Prospects = new object();
            //53
            oraObj.ProspectNotes = oRep.GetProspectNotes(id, startDate, endDate, limitResults, runId);
            //oraObj.ProspectNotes = new object();
            //54
            oraObj.SalesPersonRegions = oRep.GetSalesPersonRegions(id, startDate, endDate, limitResults, runId);
            //oraObj.SalesPersonRegions = new object();
            //55
            oraObj.Contact = oRep.GetContacts(id, startDate, endDate, limitResults, runId);
            //oraObj.Contact = new object();
            //56
            oraObj.ContactNotes = oRep.GetContactNotes(id, startDate, endDate, limitResults, runId);
            //oraObj.ContactNotes = new object();
            //57
            oraObj.Projects = oRep.GetProjects(id, startDate, endDate, limitResults, runId);
            //oraObj.Projects = new object();
            //58
            oraObj.CustomerEvents = oRep.GetCustomerEvents(id, startDate, endDate, limitResults, runId);
            //oraObj.CustomerEvents = new object();
            //59
            oraObj.ProjectProducts = oRep.GetProjectProducts(id, startDate, endDate, limitResults, runId);
            //oraObj.ProjectProducts = new object();
            //60
            oraObj.Schedules = oRep.GetSchedules(id, startDate, endDate, limitResults, runId);
            //oraObj.Schedules = new object();
            //61
            oraObj.ScheduleItems = oRep.GetScheduleItems(id, startDate, endDate, limitResults, runId);
            //oraObj.ScheduleItems = new object();
            //62
            oraObj.SalespersonContacts = oRep.GetSalespersonContacts(id, startDate, endDate, limitResults, runId);
            //oraObj.SalespersonContacts = new object();
            //63
            oraObj.ProjectNotes = oRep.GetProjectNotes(id, startDate, endDate, limitResults, runId);
            //oraObj.ProjectNotes = new object();
            //64
            oraObj.ProjectBidders = oRep.GetProjectBidders(id, startDate, endDate, limitResults, runId);
            //oraObj.ProjectBidders = new object();
            //65
            oraObj.ProjectBidderProducts = oRep.GetProjectBidderProducts(id, startDate, endDate, limitResults, runId);
            //oraObj.ProjectBidderProducts = new object();
            //66
            oraObj.ProjectBidderNotes = oRep.GetProjectBidderNotes(id, startDate, endDate, limitResults, runId);
            //oraObj.ProjectBidderNotes = new object();
            //67
            oraObj.ProjectBidderCharges = oRep.GetProjectBidderCharges(id, startDate, endDate, limitResults, runId);
            //oraObj.ProjectBidderCharges = new object();
            //68
            //oraObj.Orders = oRep.GetOrders(id, startDate, endDate, limitResults);
            oraObj.Orders = new object();
            //69
            //oraObj.OrderDetails = oRep.GetOrderDetails(id, startDate, endDate, limitResults);
            oraObj.OrderDetails = new object();
            //70
            oraObj.Quotes = oRep.GetQuotes(id, startDate, endDate, limitResults, runId);
            //oraObj.Quotes = new object();
            //71
            oraObj.QuoteDetails = oRep.GetQuoteDetails(id, startDate, endDate, limitResults, runId);
            //oraObj.QuoteDetails = new object();
            //72
            oraObj.QuoteStandardClauses = oRep.GetQuoteStandardClauses(id, startDate, endDate, limitResults, runId);
            //oraObj.QuoteStandardClauses = new object();
            //73
            oraObj.QuoteSurcharges = oRep.GetQuoteSurcharges(id, startDate, endDate, limitResults, runId);
            //oraObj.QuoteSurcharges = new object();
            //74
            oraObj.ProjectDistances = oRep.GetProjectDistances(id, startDate, endDate, limitResults, runId);
            //oraObj.ProjectDistances = new object();
            return oraObj;
        }

        private object ReturnPackage(OracleObject oraObj) {
            var settings = new JsonSerializerSettings {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            return JsonConvert.SerializeObject(oraObj, Formatting.None, settings);
        }

        private void TransmitData(OracleObject oraObj, OracleCloudDto dto, int runId) {
            if (dto.UnitTesting == false) {
                var data = ReturnPackage(oraObj);
                var client = new HttpClient {
                    //BaseAddress = new Uri("http://323-booth-svr2:3030/")
                    ////////////////BaseAddress = new Uri("http://62.60.119.147:2631/")
                    BaseAddress = new Uri("http://localhost:65198/")
                    //BaseAddress = new Uri(company.ServiceUrl)
                };
                try {
                    var response = client.PostAsJsonAsync("api/Remote/ProcessCvhFile", data).Result;
                    response.EnsureSuccessStatusCode();
                    var result = response.Content.ReadAsStringAsync().Result;
                    var obj = JsonConvert.DeserializeObject<ReturnDto>(result);
                    var rep = dto.OracleRepository != null ? dto.OracleRepository : new OracleRepository();
                    rep.WriteResults(obj, runId);
                }
                catch (Exception ex) {
                    throw ex;
                }
            } else {
                return; // nothing to unit test
            }
        }

        #endregion

        

        #region Public Methods

        [HttpPost]
        public HttpResponseMessage InitiateCrhDailyProcessing(OracleCloudDto dto) {
            var limitRecords = dto.LimitRecords;
            var companyId = dto.CompanyId;
            var startDate = dto.StartDate.AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59).AddMilliseconds(999);
            var endDate = dto.EndDate.AddDays(1);
            var key = SecurityUtils.CreateUserSecurityKey(" ", " ", companyId);
            var oRep = dto.OracleRepository != null ? dto.OracleRepository : new OracleRepository();
            var runId = oRep.GetNextRunId();
            var oraObj = LoadOracleObject(limitRecords, key, companyId, startDate, endDate, oRep, runId);
            try {
                TransmitData(oraObj, dto, runId);
            }
            catch (Exception ex) {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, "Got Here");
        }











        #endregion
    }

    struct OracleObject {
        public object Dates { get; set; }
        public object DeletedItems { get; set; }
        public object SourceSystem { get; set; }
        public object Roles { get; set; }
        public object Statuses { get; set; }
        public object QuoteStatuses { get; set; }
        public object QuoteSections { get; set; }
        public object ProjectChargeTypes { get; set; }
        public object ProjectBidderStatuses { get; set; }
        public object EventStatus { get; set; }
        public object DeviationTypes { get; set; }
        public object Companies { get; set; }
        public object Unit_Of_Measure { get; set; }
        public object QuoteTypes { get; set; }
        public object CompanyOrderStatuses { get; set; }
        public object CompanyProjectProductStatuses { get; set; }
        public object CompanyProjectStatuses { get; set; }
        public object CompanyQuoteStatuses { get; set; }
        public object CreditStatuses { get; set; }
        public object CustomerEventTypes { get; set; }
        public object CustomerTypes { get; set; }
        public object Divisions { get; set; }
        public object EventFrequency { get; set; }
        public object LinesOfBusiness { get; set; }
        public object LostReasons { get; set; }
        public object PaymentTerms { get; set; }
        public object ProjectMapQtyRanges { get; set; }
        public object ProjectTypes { get; set; }
        public object Sources { get; set; }
        public object Terms_Discount { get; set; }
        public object VehicleTypes { get; set; }
        public object ZoneCodes { get; set; }
        public object CompanyBidStatuses { get; set; }
        public object Plant { get; set; }
        public object PlantLinesOfBusiness { get; set; }
        public object ProductLines { get; set; }
        public object ProductTypes { get; set; }
        public object ProductUsage { get; set; }
        public object Surcharges { get; set; }
        public object Product { get; set; }
        public object PlantProductPrices { get; set; }
        public object ProjectCharges { get; set; }
        public object StandardClauses { get; set; }
        public object Users { get; set; }
        public object UserRoles { get; set; }
        public object CompanyUsers { get; set; }
        public object Competitors { get; set; }
        public object CompetitorPlants { get; set; }
        public object Logins { get; set; }
        public object ManagersSalesmen { get; set; }
        public object ProductTemplates { get; set; }
        public object TemplatedProducts { get; set; }
        public object Prospects { get; set; }
        public object ProspectNotes { get; set; }
        public object SalesPersonRegions { get; set; }
        public object Contact { get; set; }
        public object ContactNotes { get; set; }
        public object Projects { get; set; }
        public object CustomerEvents { get; set; }
        public object ProjectProducts { get; set; }
        public object Schedules { get; set; }
        public object ScheduleItems { get; set; }
        public object SalespersonContacts { get; set; }
        public object ProjectNotes { get; set; }
        public object ProjectBidders { get; set; }
        public object ProjectBidderProducts { get; set; }
        public object ProjectBidderNotes { get; set; }
        public object ProjectBidderCharges { get; set; }
        public object Orders { get; set; }
        public object OrderDetails { get; set; }
        public object Quotes { get; set; }
        public object QuoteDetails { get; set; }
        public object QuoteStandardClauses { get; set; }
        public object QuoteSurcharges { get; set; }
        public object ProjectDistances { get; set; }

    }
}
