using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_gft_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public abstract class Forma
        {
            private double area;
           
            public double Area
            {
                get
                { return area; }
                set
                { area = value; }
            }
            public abstract void CalcularArea();
        }

        public class Quadrado : Forma
        {
            private double lado;
            public double Lado
            {
                get
                { return lado; }
                set
                { lado = value; }
            }
            public override void CalcularArea()
            {
                this.Area = lado * lado;
            }
        }
        public class Triangulo : Forma
        {
            private double baseTr;
            private double alturaTr;

            public double BaseTr
            {
                get
                { return baseTr; }
                set
                { baseTr = value; }
            }
            public double AlturaTr
            {
                get
                { return alturaTr; }
                set
                { alturaTr = value; }
            }

            public override void CalcularArea()
            {
                this.Area = (baseTr*alturaTr)/2;
            }
        }

        public class Retangulo : Forma
        {
            private double baseRet;
            private double alturaRet;

            public double BaseRet
            {
                get
                { return baseRet; }
                set
                { baseRet = value; }
            }
            public double AlturaRet
            {
                get
                { return alturaRet; }
                set
                { alturaRet = value; }
            }

            public override void CalcularArea()
            {
                this.Area = baseRet * alturaRet;
            }
        }

        public class Trapezio : Forma
        {
            private double baseMenoTra;
            private double baseMaioTra;
            private double alturaTra;

            public double BaseMenoTra
            {
                get
                { return baseMenoTra; }
                set
                { baseMenoTra = value; }
            }
            public double BaseMaioTra
            {
                get
                { return baseMaioTra; }
                set
                { baseMaioTra = value; }
            }
            public double AlturaTra
            {
                get
                { return alturaTra; }
                set
                { alturaTra = value; }
            }

            public override void CalcularArea()
            {
                this.Area = ((baseMenoTra + baseMaioTra)*alturaTra)/2;
            }
        }
        Quadrado q = new Quadrado();
        Retangulo r = new Retangulo();
        Triangulo tr = new Triangulo();
        Trapezio tra = new Trapezio();
        private void btn_Calculo_Click(object sender, EventArgs e)
        {
            q.Lado = Convert.ToDouble(txtLado.Text);

            r.BaseRet= Convert.ToDouble(txtBaseRet.Text);
            r.AlturaRet = Convert.ToDouble(txtAlturaRet.Text);

            tr.BaseTr = Convert.ToDouble(txtBaseTr.Text);
            tr.AlturaTr = Convert.ToDouble(txtAlturaTr.Text);

            tra.BaseMenoTra = Convert.ToDouble(txtBaseMenoTra.Text);
            tra.BaseMaioTra = Convert.ToDouble(txtBaseMaioTra.Text);
            tra.AlturaTra = Convert.ToDouble(txtAlturaTra.Text);

            q.CalcularArea();

            r.CalcularArea();

            tr.CalcularArea();

            tra.CalcularArea();

            lblResult.Text = "Quadrado: " + q.Area + "\nRetângulo: " + r.Area
            + "\nTriângulo: " + tr.Area + "\nTrapézio: " + tra.Area;
        }
    }
}
