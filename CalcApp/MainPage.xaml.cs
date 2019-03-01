using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcApp
{
    public partial class MainPage : ContentPage
    {
        void Somando(object sender, System.EventArgs e)
        {
            int n1 = 0, n2 = 0, n = 0;

            n1 = Convert.ToInt32(Num_01.Text);

            n2 = Convert.ToInt32(Num_02.Text);

            n = n1 + n2;

            label_1.Text = n.ToString();
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
