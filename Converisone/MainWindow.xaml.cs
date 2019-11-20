using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Converisone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string n = txtValori.Text;
            if (cmbName.SelectedIndex == 0)
            {
                string valore = txtValori.Text;
                int ris = 0;
                int exp = 0;
                for(int i=valore.Length-1;i>=0;i--)
                {
                    if (valore[i] == '1')
                        ris += (int)Math.Pow(2, exp);
                }
                TxtConverti.Text = $"{ris}";
                //int ris = Convert.ToInt32(n, 2);
               // TxtConverti.Text= ris.ToString(); 
            }
            else if(cmbName.SelectedIndex==1)
            {
                int a = int.Parse(n);
                string ris = " ";
                int mezzo = a;
                do
                {
                    if (mezzo % 2 == 0)
                    {
                        mezzo = mezzo / 2;
                        ris = " " + "0" + ris;
                    }
                    else
                    {
                        mezzo = mezzo / 2;
                        ris = " " + "1" + ris;
                    }

                } while (mezzo != 0);
                //string ris = Convert.ToString(a,2);
                TxtConverti.Text = ris.ToString();
            }
       
        }
    }
}

        
