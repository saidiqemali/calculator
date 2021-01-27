using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculaor
{
    public partial class Form1 : Form
    {
        Double value = 0;                           // hier habe ich alle die variablen gemacht, ich habe die variablen einen name gegeben und ein wert gegeben, ich habe die variablen dann später genutzt
        String operation = "";
        bool operation_clicked = false;             // bool kann nur true oder false sein 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;                  
            textBox1.Text = textBox1.Text + b.Text;   //jede button der ich geklickt habe, sieht man in textBox1, weil sie alle den gleichen click haben, ich habe jede Zahl den gleichen click gegeben, also, mann kann auch sehen : button click.

        }

        private void Operation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            textBox1.Clear();
            operation_clicked = true;            // wenn ich ein operation clicke, ich will zum beispiel 5 mit 25 moltiplizieren, es sagt nicht 525 sondern, ( wegen: textBox1.Clear(); und operation_clicked = true) es sagt 5 *, 5 sieht mann nicht mehr nachdem du mal gedruckt hast dann 25.
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; //  das ist clear button : C , wenn ich zum beispiel 54 gedruckt habe, und es ist falsch, ich will es löschen, ich kann das mit : textBox1.Text = "0" machen, aber ich habe die Taschenrechner am ende des code programmiert; dass es KEIN 0 (null) gibt vor einen Zahl
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (operation)                     

            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();     // hier habe ich den button : equal/gleich programmiert dass er die operationen erledigt. Ich habe mit parse() gemacht sonst liest das programm es falsch oder versteht gar nicht
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();         // hier kann KEIN 0 (null) vor einen Zahl sein, sonst würde die operation keinn sinn machen. Beispiel:  0000233 - 11 = das geht nicht!
                    
            }
                
        }
    }
}