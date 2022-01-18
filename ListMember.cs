using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class ListMember : IMember
    {
        public List<Member> list = new List<Member>();

        public void add(Member member){
            this.list.Add(member);
        }

        public List<Member> showMaleList(List<Member> listMember){
            List<Member> male = (from member in listMember
                                    where member.Gender == 1
                                    select member).ToList();
            return male;
        }
        public Member showOldest(List<Member> listMember){
            var oldest = (from member in listMember
                    orderby member.Age descending
                    select member).ToList();
            return oldest.FirstOrDefault() == null ? new Member() : oldest.First();
        }
        public List<String> showFullName(List<Member> listMember){
            List<String> fullName = (from member in listMember
                                    select member.LastName + " " + member.FirstName).ToList();
            return fullName;
        }
        public List<Member>[] showAgeGroup(List<Member> listMember){
            List<Member> is2000 = (from member in listMember
                        where member.YearOfBirth == 2000
                        select member).ToList();
            List<Member> above2000 = (from member in listMember
                        where member.YearOfBirth > 2000
                        select member).ToList();
            List<Member> below2000 = (from member in listMember
                        where member.YearOfBirth < 2000
                        select member).ToList();
            return new List<Member>[]{
                is2000,
                above2000,
                below2000
            };
        }
        public Member showFirstHanoi(List<Member> listMember){
            var hanoier = (from member in listMember
                        where member.BirthPlace == "Ha noi"
                        select member).ToList();
            Member firstHanoier = hanoier.First();
            return firstHanoier == null ? new Member(){BirthPlace = ""} : firstHanoier;
        }
    }
}