using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Equity1.Models
{
    public class TeamPerson
    {
        public TeamPerson()
        {
            Name = "no name";
            Title = "no title";
            Bio = "no bio";
            image = "no image";
        }
        public TeamPerson(string n, string t, string b, string i)
        {
            Name = n;
            Title = t;
            Bio = b;
            image = i;
        }
 
        public TeamPerson[] GetOrgComm()
        {
            var OC = new[]
            {
                    new TeamPerson("Raquelle Zuzarte", "Founder","Bio", "/Images/RZ.png"),
                    new TeamPerson("Ashley Graham", "Sponsorships Lead","Bio", "/Images/AG.jpg"),
                    new TeamPerson("Elena DeLuccia", "Design & Talent Lead","Bio", "/Images/ED.png"),
                    new TeamPerson("Tesfa Alexander", "Marketing Lead","Bio", "/Images/TA.jpg"),
                    new TeamPerson("Darryl Challenger", "Project Manager","Bio", "/Images/DC.png"),
                    new TeamPerson("Rebecca Martos", "Creative Producer","Bio", "/Images/RM.jpg"),
                    new TeamPerson("Maxwell Tielman", "Social Media Lead","Bio", "/Images/MT.jpg"),
                    new TeamPerson("Emily Rasowsky", "Emily Rasowsky","Bio", "/Images/ER.png"),
                    new TeamPerson("Amelia Erikson", "Non Profit & NGO Liaison Lead","Bio", "/Images/AE.jpg"),
                    new TeamPerson("Mark Brennan", "Visual Art Exhibit Lead","Bio", "/Images/MB.jpg"),
                    new TeamPerson("Fr. Frank Sabatte", "Head Artist-in-Residence","Bio", "/Images/FS.jpg"),
                    new TeamPerson("Nadia Tayeh", "Artist-in-Residence", "Bio","/Images/NT.jpg")
//                    new TeamPerson("", "","Bio", ""),
            };
            return OC;
        }
        public TeamPerson[] GetAdvBrd()
        {
            var AB = new[]
            {
                    new TeamPerson("Simon Moss", "Co-Founder – Global Citizen", "Bio","/Images/SM.jpg"),
                    new TeamPerson("Per Pedersen", "Chairman – Global Creative Council, GREY", "Bio","/Images/PP.png"),
                    new TeamPerson("Jamira Burley", "Former Hillary For America Millennial Director", "Bio","/Images/JB.jpg"),
                    new TeamPerson("Jakob Trollback", "Founder & CCO - Trollbäck+Company", "Bio","/Images/JT.jpg"),
                    new TeamPerson("Shannon O'Shea", "Agenda 2030 Partnerships, UNICEF", "Bio","/Images/SO.jpg"),
                    new TeamPerson("Rachel West", "Global Head of Creative Relations, GREY", "Bio","/Images/RW.png"),
                    new TeamPerson("Tamara Park", "Founder, Chief Creative Officer Park Digital Ventures", "Bio","/Images/TP.jpg"),
                    new TeamPerson("Prof.Meena Alexandra", "Award-winning poet", "Bio","/Images/MA.jpg"),
                    new TeamPerson("Miriam Rotman, M.D.", "Women’s Health Advocate Bay Area Forward", "Bio","/Images/MR.jpg"),
                    new TeamPerson("Donetta Campbell","CEO – The Social Architects",  "Bio","/Images/DC2.jpg"),
                    new TeamPerson("Mark Danchak","Co-Founder - Carbon6 Ventures", "Bio", "/Images/MD.jpg"),
                    new TeamPerson("Katrina Del Punta, PhD", "Professor – Rockefeller University", "Bio","/Images/KP.jpg")
            };
            return AB;

        }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }
        public string image { get; set; }
    }
}