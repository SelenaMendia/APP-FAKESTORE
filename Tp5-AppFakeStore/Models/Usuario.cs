using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Devices.Sensors;

namespace Tp5_AppFakeStore.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public name name { get; set; }
        public address address { get; set; }
        public string Phone { get; set; }

    }

    public class name
    {
        public string firstname { get; set; }
        public string lastname { get; set; }

        

        public string FullName => $"{Capitalize(firstname)} {Capitalize(lastname)}"; //Capitalize convierte la primera letra de la cadena a mayúscula y el resto de la cadena a minúsculas 

        private string Capitalize(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            return char.ToUpper(value[0]) + value.Substring(1).ToLower();
        }
    }

    public class address
    {
        public string city { get; set; }
        public string street { get; set; }
        public int number { get; set; }
        public string zipcode { get; set; }
        public geolocation geolocation { get; set; }

        public string FullAddress
        {
            get
            {
                return $"{Capitalize(street)} {number}";
            }
        }

        private string Capitalize(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;

            return string.Join(" ", value.Split(' ')
                                         .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
        }
    }

    public class geolocation
    {
        public string lat { get; set; }
        public string @Long { get; set; }
    }
}
