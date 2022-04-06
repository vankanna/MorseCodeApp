using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private string chunk = "";
        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            Button button = sender as Button;

            char response;

            if (button1 == button)
            {
                chunk += ".";
                dotdash.Text += ".";
            } 
            else if (button2 == button)
            {
                chunk += "-";
                dotdash.Text += "-";
            }
            else
            {
                if (chunk == "")
                {
                    dotdash.Text += " ";
                }
                response = Morse.MorseCoder(chunk);
                userinput.Text += Char.ToString(response);
                chunk = "";
            }


        }


    }

    

}
