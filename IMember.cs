using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public interface IMember
    {
        public List<Member> showMaleList(List<Member> listMember);
        public Member showOldest(List<Member> listMember);
        public List<String> showFullName(List<Member> l);
        public List<Member>[] showAgeGroup(List<Member> l);
        public Member showFirstHanoi(List<Member> l);
    }
}