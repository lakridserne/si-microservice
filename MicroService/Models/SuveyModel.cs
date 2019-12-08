using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroService.Models
{
    public class SuveyModel
    {

        // Properties
        private enum GeographicaLocation { DK, JP, US, DE };
        private enum Gender { Male, Female, other };
        private enum Age { Kids, Teens, Adult, Old };
        private int NumberOFKids { get; set; }
        private int BookingEXperince { get; set; }
        private int SatisfactionWitHStaff { get; set; }
        private int SatisfactionWithFood { get; set; }
        private int SatisfactionWithCleaning { get; set; }
        private string OtherComments { get; set; }

    }
}
