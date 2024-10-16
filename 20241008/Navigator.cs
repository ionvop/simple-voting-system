using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241008
{
    public static class Navigator
    {
        public static void Navigate(Form from, Form to)
        {
            to.FormClosed += (s, e) =>
            {
                if (Application.OpenForms.Count <= 1)
                {
                    Application.Exit();
                }
            };

            to.StartPosition = FormStartPosition.Manual;
            to.Location = from.Location;
            to.Show();
            from.Close();
        }
    }
}
