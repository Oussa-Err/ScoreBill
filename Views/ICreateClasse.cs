using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scoreBill.Views
{
    internal interface ICreateClasse
    {
        string NomClasse { get; set; }
        string NomMatieres { get; set; }
        string NbrMatiere { get; set; }
        string NbrMois { get; set; }
        string FraisInitial { get; set; }
        string FraisMensuel { get; set; }
        
    }
}
