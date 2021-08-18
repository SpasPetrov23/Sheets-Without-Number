using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheetsWithoutNumber.Services.Character
{
    public interface ICharacterModel
    {
        public string Name { get; }

        public string Background { get;}

        public string Class { get;}
    }
}
