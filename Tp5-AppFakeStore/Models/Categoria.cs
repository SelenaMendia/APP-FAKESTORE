using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp5_AppFakeStore.Models
{
    public class Categoria
    {
        public string Name { get; set; }

        public string Categorias
        {
            get
            {
                return Capitalize(Name);
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

    
}
