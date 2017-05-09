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
                    new TeamPerson("Raquelle Zuzarte", "Founder","Bio", "/Images/RZsq.png"),
                    new TeamPerson("Ashley Graham", "Sponsorships Lead","Bio", "/Images/AGsq.jpg"),
                    new TeamPerson("Elena DeLuccia", "Design & Talent Lead","Bio", "/Images/EDsq.png"),
                    new TeamPerson("Tesfa Alexander", "Marketing Lead","Bio", "/Images/TAsq.jpg"),
                    new TeamPerson("Darryl Challenger", "Project Manager","Bio", "/Images/DCsq.png"),
                    new TeamPerson("Rebecca Martos", "Creative Producer","Bio", "/Images/RMsq.jpg"),
                    new TeamPerson("Maxwell Tielman", "Social Media Lead","Bio", "/Images/MTsq.jpg"),
                    new TeamPerson("Emily Rasowsky", "Emily Rasowsky","Bio", "/Images/ERsq.png"),
                    new TeamPerson("Amelia Erikson", "Non Profit & NGO Liaison Lead","Bio", "/Images/AEsq.jpg"),
                    new TeamPerson("Mark Brennan", "Visual Art Exhibit Lead","Bio", "/Images/MBsq.jpg"),
                    new TeamPerson("Fr. Frank Sabatte", "Head Artist-in-Residence","Bio", "/Images/FSsq.jpg"),
                    new TeamPerson("Nadia Tayeh", "Artist-in-Residence", "Bio","/Images/NTsq.jpg")
//                    new TeamPerson("", "","Bio", ""),
            };
            return OC;
        }
        public TeamPerson[] GetAdvBrd()
        {
            var AB = new[]
            {
                    new TeamPerson("Simon Moss", "Co-Founder – Global Citizen", "Bio","/Images/SMsq.jpg"),
                    new TeamPerson("Per Pedersen", "Chairman – Global Creative Council, GREY", "Bio","/Images/PPsq.png"),
                    new TeamPerson("Jamira Burley", "Former Hillary For America Millennial Director", "Bio","/Images/JBsq.jpg"),
                    new TeamPerson("Jakob Trollback", "Founder & CCO - Trollbäck+Company", "Bio","/Images/JTsq.jpg"),
                    new TeamPerson("Shannon O'Shea", "Agenda 2030 Partnerships, UNICEF", "Bio","/Images/SOsq.jpg"),
                    new TeamPerson("Rachel West", "Global Head of Creative Relations, GREY", "Bio","/Images/RWsq.png"),
                    new TeamPerson("Tamara Park", "Founder, Chief Creative Officer Park Digital Ventures", "Bio","/Images/TPsq.jpg"),
                    new TeamPerson("Prof.Meena Alexandra", "Award-winning poet", "Bio","/Images/MAsq.jpg"),
                    new TeamPerson("Miriam Rotman, M.D.", "Women’s Health Advocate Bay Area Forward", "Bio","/Images/MRsq.jpg"),
                    new TeamPerson("Donetta Campbell","CEO – The Social Architects",  "Bio","/Images/DC2sq.jpg"),
                    new TeamPerson("Mark Danchak","Co-Founder - Carbon6 Ventures", "Bio", "/Images/MDsq.jpg"),
                    new TeamPerson("Katrina Del Punta, PhD", "Professor – Rockefeller University", "Bio","/Images/KPsq.jpg")
            };
            return AB;

        }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }
        public string image { get; set; }
    }
}