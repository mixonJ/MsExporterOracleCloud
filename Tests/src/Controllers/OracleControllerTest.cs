using NUnit.Framework;
using OracleCloud.Controllers;
using OracleCloud.DTOs;
using System;

namespace Tests {
    [TestFixture]
    public class OracleControllerTest {

        public OracleController SetupObject(){
            var oc = new OracleController();
            oc.Request = GlobalHelper.GetRequestObject(oc);
            var uri = new System.Uri("http://www.contoso.com/?l=true&c=12&d=x");
            oc.Request.RequestUri = uri;
            return oc;
        }
        
        [Test]
        public void InitiateCrhDailyProcessing_HappyPath(){
            var oc = SetupObject();
            var dto = new OracleCloudDto() {
                OracleRepository = new OracleRepositoryMock(),
                UnitTesting = true,
                CompanyId = 56,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                LimitRecords = true
            };

            var ret = oc.InitiateCrhDailyProcessing(dto);
            Assert.IsTrue(ret != null);
        }
    }
}
