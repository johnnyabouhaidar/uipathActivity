using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;
using System.Windows.Forms;



namespace dtepkr
{
    public class Class1: CodeActivity
    {
        [Category("Output")]
        public OutArgument<String> Resultt { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            newClass.runForm();
            Resultt.Set(context, newClass.res);


        }
    }
}
