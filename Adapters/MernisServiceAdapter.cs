using System;
using System.Collections.Generic;
using System.Text;
using GameSalesDemo.Abstract;
using GameSalesDemo.Entities;
using MernisServiceReference;

namespace GameSalesDemo.Adapters
{
    class MernisServiceAdapter:IMemberCheckService
    {
        public bool CheckIfRealMember(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(
                    Convert.ToInt64(member.NationaalityId),
                    member.FirstName.ToUpper(),
                    member.LastName.ToUpper(),
                    member.DateOfBirth.Year
                ))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
