using System.Collections.Generic;
using System.Linq;
namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Generate dữ liệu lại cho phong phú
            Member m1 = new Member();
            Member m2 = new Member();
            Member m3 = new Member();
            Member m4 = new Member();
            Member m5 = new Member();
            Member m6 = new Member();
            
            ListMember team = new ListMember();
            team.add(m1);
            team.add(m2);
            team.add(m3);
            team.add(m4);
            team.add(m5);
            team.add(m6);


            Console.WriteLine("Member co tuoi cao nhat la : ");
            Member oldestMember = team.showOldest(team.list);
            oldestMember.showInfo();

            Console.WriteLine("Member co gender la male : ");
            foreach(Member m in team.showMaleList(team.list)){
                m.showInfo();
            }

            Console.WriteLine("List of full name : ");
            foreach(String name in team.showFullName(team.list)){
                Console.Write(name + " --- ");
            }

            Console.WriteLine("\nFirst born in Hanoi : ");
            team.showFirstHanoi(team.list).showInfo();

            List<Member>[] arrAge = team.showAgeGroup(team.list);
            Console.WriteLine("Born in 2000 : ");
            foreach(Member m in arrAge[0]){
                m.showInfo();
            }
            Console.WriteLine("Born after 2000 : ");
            foreach(Member m in arrAge[2]){
                m.showInfo();
            }
            Console.WriteLine("Born before 2000 : ");
            foreach(Member m in arrAge[1]){
                m.showInfo();
            }
        }

        
    }
}