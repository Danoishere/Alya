using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alya.Template.Web
{
    public class StaticDataConfig
    {
        public static void InitializeStaticData()
        {
            ApplicationData.Instance.Skills.Add(
                new Skill(
                    ".NET Framework", 
                    "Development of various business applications with .NET Framework 3.5 to 4.6, .NET Core and MONO",
                    5));
            ApplicationData.Instance.Skills.Add(
                new Skill(
                    "Entity Framework",
                    "Usage of the Entity Framework in many different projects and combinations (desktop applications, web applications, APIs, etc.)",
                    5));
            ApplicationData.Instance.Skills.Add(
                new Skill(
                    "Requirement analysis",
                    "Analysis of the required features, infrastructure and support strategy of multiple projects.",
                    4));
            ApplicationData.Instance.Skills.Add(
                new Skill(
                    "Java Spring",
                    "Development of Java Server Pages applications with the Spring Framework",
                    4));
        }
    }
}