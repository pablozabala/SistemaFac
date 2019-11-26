using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace SistemaFact.Clases
{
    public static class cFunciones
    {
        public static void LlenarCombo(ComboBox Combo, DataTable trdo, string Member, string Values)
        {
            Combo.DataSource = trdo;
            Combo.ValueMember = Values;
            Combo.DisplayMember = Member;
        }
    }
}
