using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using GameSalesDemo.Abstract;
using GameSalesDemo.Entities;

namespace GameSalesDemo.Concrete
{
    class MemberManager:IMemberService
    {
        private IMemberCheckService _memberCheckService;

        public MemberManager(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }

        public void Add(Member member)
        {
            if (_memberCheckService.CheckIfRealMember(member))
            {
                Console.WriteLine("Sisteme kaydınız başarılı şekilde yapılmıştır: " + member.FirstName);
            }

            else
            {
                throw new Exception("Not a valid member");
            }
            
        }

        public void Update(Member member)
        {
            Console.WriteLine("Bilgileriniz başarılı bir şekilde güncellenmiştir: " + member.FirstName);
        }

        public void Delete(Member member)
        {
            Console.WriteLine("Kaydınız başarılı bir şekilde silinmiştir: " + member.FirstName);
        }
    }
}
