using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightConversion
{
    public partial class Form1 : Form
    {
        private double kg = 1;
        private double lb = 2.2;
         
        public Form1()
        {
            InitializeComponent();
        }



        private void ConversionButtonClicked(object sender, EventArgs e)
        {
            double inputKg;
            bool correctValue = Double.TryParse(this.kgTextBox.Text, out inputKg);

            if (correctValue)
            {
                this.lbTextBox.Text = ConversionKgTolb(inputKg).ToString();
            }


            //double outPutLp = (correctValue) ? inputKg : "正しい値を入力してください"; 

        }

        /**
         *  Kg → Lb 
         */
        public double ConversionKgTolb(double inputKg)
        {
            double conversionedValue = inputKg * this.lb;
            return conversionedValue;
        }

        /**
         *  Lb → Kg
         */
        public double ConversionLbToKg(double inputLb)
        {
            double conversionedValue =inputLb * this.kg / this.lb;
            return conversionedValue;
        }

        private void ResetButtonClicked(object sender, EventArgs e)
        {
            kgTextBox.Text = null;
            lbTextBox.Text = null;
        }
    }
}
