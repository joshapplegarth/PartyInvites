using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {   //  FIELDS & PROPERTIES
        private static List<GuestResponse> responses = new List<GuestResponse>();

        //  CONSTRUCTORS

        //  METHODS
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
        public static List<GuestResponse> Getresponses()
        {
            return responses;
        }
        

    }
}
