using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
pace Jocs
{
    public partial class FrmPedra : Form
    {
        public EventHandler esticTancant;
        public Int16 resultatJugador = 0;
        public Int16 resultatMaquina = 0;

        public FrmPedra()
        {
            InitializeComponent();
        }

        private void FrmPedra_FormClosed(object sender, FormClosedEventArgs e)
        {
            esticTancant(this, EventArgs.Empty);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(calcular_resultat())
            {
                case 0:
                    label2.Text = "Ha guanyat el jugador";
                    break;
                case 1:
                    label2.Text = "Ha guanyat la CPU";
                    break;
                case 2:
                    label2.Text = "Empatat!";
                    break;
            }
        }

        //retornara 0: ha guanyat el jugador
        //retornara 1: ha guanyat la CPU
        //retornara 2: en cas de empat
        private Int16 calcular_resultat()
        {
            Int16 guanyador = 1;
            Int16 seleccio_maquina = 0;
            Random R = new Random();
            Int16 CPU = (Int16)R.Next(1, 4);

            switch (CPU)
            {
                case 1:
                    seleccio_maquina = 1;
                    break;
                case 2:
                    seleccio_maquina = 2;
                    break;
                case 3:
                    seleccio_maquina = 3;
                    break;
            }

            if (rbPedra.Checked == true && seleccio_maquina == 1)
            {
                radioButton4.Checked = true;
                guanyador = 2;  //empat pedra & pedra
            }

            if (rbPedra.Checked == true && seleccio_maquina == 2)
            {
                radioButton5.Checked = true;
                resultatMaquina++;
                label4.Text = String.Format("CPU: {0}", resultatMaquina);
                guanyador = 1;  //has perdut jugador guanya la maquina
            }

            if (rbPedra.Checked == true && seleccio_maquina == 3)
            {
                radioButton6.Checked = true;
                resultatJugador++;
                label3.Text = String.Format("Jugador: {0}", resultatJugador);
                guanyador = 0;  //guanya el jugador a les tisores!
            }

            //condicions de paper
            if (rbPaper.Checked == true && seleccio_maquina == 1)
            {
                radioButton4.Checked = true;
                resultatJugador++;
                label3.Text = String.Format("Jugador: {0}", resultatJugador);
                guanyador = 0;  //empat pedra & pedra
            }

            if (rbPaper.Checked == true && seleccio_maquina == 2)
            {
                radioButton5.Checked = true;
                guanyador = 2;  //has perdut jugador guanya la maquina
            }

            if (rbPaper.Checked == true && seleccio_maquina == 3)
            {
                radioButton6.Checked = true;
                resultatMaquina++;
                label4.Text = String.Format("CPU: {0}", resultatMaquina);
                guanyador = 1;  //guanya el jugador a les tisores!
            }

            //condicions de tisores
            if (rbTisora.Checked == true && seleccio_maquina == 1)
            {
                radioButton4.Checked = true;
                resultatJugador++;
                label4.Text = String.Format("CPU: {0}", resultatMaquina);
                guanyador = 1;  //empat pedra & pedra
            }

            if (rbTisora.Checked == true && seleccio_maquina == 2)
            {
                radioButton5.Checked = true;
                resultatJugador++;
                label3.Text = String.Format("Jugador: {0}", resultatJugador);
                guanyador = 0;  //has perdut jugador guanya la maquina
            }

            if (rbTisora.Checked == true && seleccio_maquina == 3)
            {
                radioButton6.Checked = true;
                guanyador = 2;  //guanya el jugador a les tisores!
            }

            return guanyador;
        }
    }
}
