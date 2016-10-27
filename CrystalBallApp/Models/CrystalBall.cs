using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBallApp.Models
{
    public class CrystalBall
    {
        //create an array of strings for responses
        //get random number

        public string getResponse()
        {
            string[] responses = { "You are loved", "It's best to serve soup warm", "I like ponies" };
            //get random controller object
            Random randomNum = new Random();
            int num = randomNum.Next(0,responses.Length); //may be int or var
            return responses[num];

        }
    }
}