using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaSamochodow
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }


        public ComboBoxItem(string text, int value)
        {
            this.Text = text;
            this.Value = value;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
