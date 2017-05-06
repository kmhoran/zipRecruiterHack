using JobBoard.Models.Domain;
using JobBoard.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobBoard.Services
{
    public class ProfileService
    {
        public static PublicProfileVM GetProfileVM(int userId)
        {
            PublicProfileVM result = new PublicProfileVM();

            switch (userId)
            {
                case 1:
                    result.User = UserService.GetUser1();
                    result.Profile = GetProfile1();
                    break;
            }

            return result;
        }


        // /////////////////////////////////////////////////////////////////////////////////////////

        public static ProfileDomain GetProfile1()
        {
            ProfileDomain profile = new ProfileDomain
            {
                UserId = 1,
                Location = "Los Angeles",
                Biogrphy = "I am a back-end dev with a degree in Computer Science.",
                Experience = "",
                Education = "Bachelors",
                Username = "angrySox99",
                MemberSince = "January 2016",
                PageUrl = "https://angrysox99.com",
                CodeSamples = new List<string>()
            };

            profile.CodeSamples.Add("http://fabacademy.org/archives/2012/students/chibire.terence/images/samplecode_1.PNG");
            profile.CodeSamples.Add("http://www.tapkaa.com/wp-content/uploads/2013/02/Sample-Pre-Paid-SIM-Card-Class-to-teach-C++-Inheritance.png");
            profile.CodeSamples.Add("https://www.phpclasses.org/browse/view/image/format/screenshot/file/36680/name/paypal-php-class-library-get-balance-code-sample.jpg");

            return profile;
        }


    }
}