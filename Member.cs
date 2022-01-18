using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2
{
    public class Member
    {
        String firstName;
        String lastName;
        int gender;
        String dateOfBirth;
        String phoneNumber;
        String birthPlace;
        int age;
        int isGraduated;
        private static int year = 1999;
        private static int gen = 0;
        private String[] city = new String[]{"Ha noi", "Hai Duong", "Nam Dinh", "Hai Phong", "Hue"};
        private static int cityIndex = 0;

        public Member(){
            firstName = "A";
            lastName = "B";
            gender = (gen + 1) % 2;
            dateOfBirth = year + "/12/24";
            phoneNumber = "0946301025";
            birthPlace = this.city[cityIndex];
            age = ageCal(dateOfBirth);
            isGraduated = 0;

            year++;
            gen = gender;
            cityIndex = (cityIndex + 1) % city.Length;
        }
        public Member(int age){
            this.age = age;
        }
        private int ageCal(String dateOfBirht) {
            DateTime date = Convert.ToDateTime(dateOfBirht);
            DateTime now = DateTime.Now;
            int age = now.Year - date.Year;
            return age;
        }

        public void showInfo() {
            Console.WriteLine("Full-Name: {0} {1} Age: {2} Gender: {3} City: {4}", firstName, lastName, age, (gender==0 ? "Female" : "Male"), birthPlace);
        }

        public int Age {
            get{
                return age;
            }
            set {
                age = value;
            }
        }
        public int Gender {
            get{
                return gender;
            }
            set {
                gender = value;
            }
        }
        public String LastName {
            get{
                return lastName;
            }
            set {
                lastName = value;
            }
        }
        public String FirstName {
            get{
                return firstName;
            }
            set {
                firstName = value;
            }
        }
        public String BirthPlace {
            get{
                return birthPlace;
            }
            set {
                birthPlace = value;
            }
        }
        public String DateOfBirth {
            get{
                return dateOfBirth;
            }
            set {
                dateOfBirth = value;
            }
        }
        public int YearOfBirth {
            get{
                DateTime date = Convert.ToDateTime(dateOfBirth);
                return date.Year;
            }
        }
    }
}