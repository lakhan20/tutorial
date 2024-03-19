using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace tutorial.Models
{
    public class myClass
    {
        public string encryptstring(string val)
        {

            byte[] b= System.Text.ASCIIEncoding.ASCII.GetBytes(val);
            string enval=Convert.ToBase64String(b);
            return enval;


        }
    }
}