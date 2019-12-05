using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPointOfSalesSystem
{
    public class ClearControl
    {

        public static void Clear(System.Windows.Forms.TextBox[] control){

            foreach (System.Windows.Forms.TextBox control1 in control)
                control1.Clear();
        
        }
        public static void ResetValue(System.Windows.Forms.TextBox[] control) {

            for (int i = 0; i < control.Length; i++) {

                if (control[i].Tag.ToString() == "")
                    control[i].Text = "(EMPTY)";

                control[i].Text = control[i].Tag.ToString();
            
            }
                
        
        }
    }
}
