using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroService.Models
{
    public class SuveyModel
    {

        // Properties
        public int ID { get; set; }
        private enum GeographicaLocation { DK, JP, US, DE };
        private enum Gender { Male, Female, other };
        private enum Age {Kids, Adult18, Adult26, Adult30, Adult40, Adult50, Old };
        private int NumberOFKids { get; set; }
        private int BookingEXperince { get; set; }
        private int SatisfactionWitHStaff { get; set; }
        private int SatisfactionWithFood { get; set; }
        private int SatisfactionWithCleaning { get; set; }
        private string OtherComments { get; set; }

    }
}
