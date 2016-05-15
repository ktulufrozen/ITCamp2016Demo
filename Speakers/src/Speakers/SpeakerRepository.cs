using System.Collections.Generic;

namespace Speakers
{
    public class SpeakerRepository
    {
        public IEnumerable<Speaker> GetAllSpeakers()
        {
            return new[]
            {
                new Speaker
                {
                    Name = "ADAM GRANICZ",
                    Position = "F# MVP",
                    Company = "INTELLIFACTORY",
                    Bio = @"Adam Granicz is a 6x F# MVP and the author of five F# books, key F# community member and evangelist, and a regular speaker at developer conferences and workshops. Next to heading IntelliFactory, the F# company specializing in functional web and cloud applications and developer tools, he promotes the use of functional programming in industry at various events and venues. You can follow him on Twitter @granicz, or find him on FPish, the largest online functional programming community."
                }, 

                new Speaker
                {
                    Name = "CIPRIAN JICHICI",
                    Position = "Azure MVP, Microsoft RD",
                    Company = "GENISOFT",
                    Bio = "Ciprian is participating in the Microsoft Regional Directors Program as a Regional Director for Romania and has been involved for the past 17 years in many enterprise-scale technology-related projects, workshops and presentations. Ciprian is also a Microsoft Azure MVP focusing especially on architectural issues related to cloud solutions and the Microsoft technology stack. He splits his time between consultancy, delivering workshops and presentations on technologies and platforms that are part of the Microsoft technology stack, and doing academic research in the field of data mining. In the past 7 years he accumulated a significant amount of knowledge in the field of cloud computing, becoming a recognized specialist on the Microsoft Azure platform. Ciprian is the General Manager of Genisoft, a consultancy, training, and services company based in Timisoara, Romania."
                },

                new Speaker
                {
                    Name = "ALEX MOLDOVAN",
                    Position = "Full Stack Developer",
                    Company = "FORTECH",
                    Bio = "I consider myself a techie, sometimes with some accents of nerd. I’m a huge militant for clean code and teaching people core programming skills and paradigms. I started my career with Microsoft technologies, working with .NET for more than 3 years, then I switched to RubyOnRails and the JavaScript ecosystem and I never looked back. Currently I’m involved a lot in the JavaScript community in Cluj, co-organizing the JavaScript meetup and speaking at various events on both tech and product development topics. In my free time I enjoy writing blog posts, trying out all sorts of new technologies and running."
                }
            };
        }
    }
}
