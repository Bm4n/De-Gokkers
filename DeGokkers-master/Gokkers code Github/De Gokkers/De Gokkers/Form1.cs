using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_Gokkers
{

    public partial class Form1 : Form
    {

        Horse horse = new Horse();
        private int _x1;
        private int _y1;

        private int _x2;
        private int _y2;

        private int _x3;
        private int _y3;

        private int _x4;
        private int _y4;

        private int _x5;
        private int _y5;

        private int _x6;
        private int _y6;

        private bool counter1 = true;
        private bool counter2 = true;
        private bool counter3 = true;

        Bet myBet = new Bet();


        Guys Sietse = new Guys("Sietse", 100);
        Guys Lidy = new Guys("Lidy", 100);
        Guys Fer = new Guys("Fer", 100);


        public Form1()
        {
            InitializeComponent();
            int start = 2;
            Starter(start);
        }

        public void Starter(int start)
        {
            _x1 = start;
            _y1 = 4;

            _x2 = start;
            _y2 = 38;

            _x3 = start;
            _y3 = 72;

            _x4 = start;
            _y4 = 106;

            _x5 = start;
            _y5 = 140;

            _x6 = start;
            _y6 = 171;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioSietse_CheckedChanged(sender, e);
            radioLidy_CheckedChanged(sender, e);
            radioFer_CheckedChanged(sender, e);
            numericInzet_ValueChanged(sender, e);
            numericHorseSelect_ValueChanged(sender, e);
            buttonWedt_Click(sender,e);

            Sietse.Cash = 50;
            Lidy.Cash = 75;
            Fer.Cash = 45;

            radioSietse.Text = "Sietse   " + "€" + Sietse.GetGuyCash();
            radioLidy.Text = "Lidy   " + "€" + Lidy.GetGuyCash();
            radioFer.Text = "Fer   " + "€"+Fer.GetGuyCash();

            horse.MakeName1();
            textBox1.Text = horse.GetName1();
            horse.MakeName2();
            textBox2.Text = horse.GetName2();
            horse.MakeName3();
            textBox3.Text = horse.GetName3();
            horse.MakeName4();
            textBox4.Text = horse.GetName4();
            horse.MakeName5();
            textBox5.Text = horse.GetName5();
            horse.MakeName6();
            textBox6.Text = horse.GetName6();

            textBoxSietse.Text = "Sietse heeft niks ingezet.";
            textBoxLidy.Text = "Lidy heeft niks ingezet.";
            textBoxFer.Text = "Fer heeft niks ingezet.";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("friekandels.png"), _x1, _y1, 32, 32);
            e.Graphics.DrawImage(new Bitmap("friekandels.png"), _x2, _y2, 32, 32);
            e.Graphics.DrawImage(new Bitmap("friekandels.png"), _x3, _y3, 32, 32);
            e.Graphics.DrawImage(new Bitmap("friekandels.png"), _x4, _y4, 32, 32);
            e.Graphics.DrawImage(new Bitmap("friekandels.png"), _x5, _y5, 32, 32);
            e.Graphics.DrawImage(new Bitmap("friekandels.png"), _x6, _y6, 32, 32);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int start = 2;
            int end = 466;
            if (_x1 >= end)
            {
                timer1.Stop();
                MessageBox.Show("Horse nr.1 (" + horse.GetName1() + ") wins!");
                Starter(start);
                Invalidate();
                this.counter1 = true;
                this.counter2 = true;
                this.counter3 = true;
                AfterReset(1);
            }
            else if (_x2 >= end)
            {
                timer1.Stop();
                MessageBox.Show("Horse nr.2 (" + horse.GetName2() + ") wins!");
                Starter(start);
                Invalidate();
                this.counter1 = true;
                this.counter2 = true;
                this.counter3 = true;
                AfterReset(2);
            }
            else if (_x3 >= end)
            {
                timer1.Stop();
                MessageBox.Show("Horse nr.3 (" + horse.GetName3() + ") wins!");
                Starter(start);
                Invalidate();
                this.counter1 = true;
                this.counter2 = true;
                this.counter3 = true;
                AfterReset(3);
            }
            else if (_x4 >= end)
            {
                timer1.Stop();
                MessageBox.Show("Horse nr.4 (" + horse.GetName4() + ") wins!");
                Starter(start);
                Invalidate();
                this.counter1 = true;
                this.counter2 = true;
                this.counter3 = true;
                AfterReset(4);
            }
            else if (_x5 >= end)
            {
                timer1.Stop();
                MessageBox.Show("Horse nr.5 (" + horse.GetName5() + ") wins!");
                Starter(start);
                Invalidate();
                this.counter1 = true;
                this.counter2 = true;
                this.counter3 = true;
                AfterReset(5);
            }
            else if (_x6 >= end)
            {
                timer1.Stop();
                MessageBox.Show("Horse nr.6 (" + horse.GetName6() + ") wins!");
                Starter(start);
                Invalidate();
                this.counter1 = true;
                this.counter2 = true;
                this.counter3 = true;
                AfterReset(6);
            }
            else
            {
                Random rnd = new Random();
                int[] Pony = new int[] {
                _x1 += rnd.Next(1, 15),
                _x2 += rnd.Next(1, 15),
                _x3 += rnd.Next(1, 15),
                _x4 += rnd.Next(1, 15),
                _x5 += rnd.Next(1, 15),
                _x6 += rnd.Next(1, 15)
                };
                Invalidate();
            }

        }

        

        private void radioSietse_CheckedChanged(object sender, EventArgs e)
        {
            radioSietse.Text = "Sietse   " + "€" + Sietse.GetGuyCash();
        }

        private void radioLidy_CheckedChanged(object sender, EventArgs e)
        {
            radioLidy.Text = "Lidy   " + "€"+ Lidy.GetGuyCash();
        }

        private void radioFer_CheckedChanged(object sender, EventArgs e)
        {
            radioFer.Text = "Fer   " + "€"+Fer.GetGuyCash();
        }

        private void buttonWedt_Click(object sender, EventArgs e)
        {

            if (radioSietse.Checked && this.counter1 == true) 
            {
                if (Sietse.PlaceBet(Convert.ToInt32(numericInzet.Value), Convert.ToInt32(numericHorseSelect.Value)) == true)
                {
                    Sietse.UpdateLabels(Sietse.Name, Sietse.Cash);

                    textBoxSietse.Text = myBet.GetDescription(Sietse.Name, Convert.ToInt32(numericInzet.Value), Sietse.GetHorseName(Sietse, horse));
                    this.counter1 = false;
                }

                radioSietse.Text = "Sietse   " + "€" + Sietse.GetGuyCash();

            }

            if (radioLidy.Checked && this.counter2 == true)
            {
                if (Lidy.PlaceBet(Convert.ToInt32(numericInzet.Value), Convert.ToInt32(numericHorseSelect.Value)) == true)
                {
                    Lidy.UpdateLabels(Lidy.Name, Lidy.Cash);

                    textBoxLidy.Text = myBet.GetDescription(Lidy.Name, Convert.ToInt32(numericInzet.Value), Lidy.GetHorseName(Lidy, horse));
                    this.counter2 = false;
                }

                radioLidy.Text = "Lidy   " + "€" + Lidy.GetGuyCash();

            }

            if (radioFer.Checked && this.counter3 == true)
            {
                if (Fer.PlaceBet(Convert.ToInt32(numericInzet.Value), Convert.ToInt32(numericHorseSelect.Value)) == true)
                {
                    Fer.UpdateLabels(Fer.Name, Fer.Cash);

                    textBoxFer.Text = myBet.GetDescription(Fer.Name, Convert.ToInt32(numericInzet.Value), Fer.GetHorseName(Fer, horse));
                    this.counter3 = false;
                }

                radioFer.Text = "Fer   " + "€" + Fer.GetGuyCash();

            }
        }

        public void AfterReset(int winner)
        {
            horse.MakeName1();
            textBox1.Text = horse.GetName1();
            horse.MakeName2();
            textBox2.Text = horse.GetName2();
            horse.MakeName3();
            textBox3.Text = horse.GetName3();
            horse.MakeName4();
            textBox4.Text = horse.GetName4();
            horse.MakeName5();
            textBox5.Text = horse.GetName5();
            horse.MakeName6();
            textBox6.Text = horse.GetName6();

            myBet.PayOut(Sietse, winner);
            myBet.PayOut(Lidy, winner);
            myBet.PayOut(Fer, winner);

            radioSietse.Text = "Sietse   " + "€" + Sietse.GetGuyCash();
            radioLidy.Text = "Lidy   " + "€" + Lidy.GetGuyCash();
            radioFer.Text = "Fer   " + "€" + Fer.GetGuyCash();

            Sietse.horseNum = 0;
            Lidy.horseNum = 0;
            Fer.horseNum = 0;

            textBoxSietse.Text = "Sietse heeft niks ingezet.";
            textBoxLidy.Text = "Lidy heeft niks ingezet.";
            textBoxFer.Text = "Fer heeft niks ingezet.";
        }

        private void numericInzet_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void numericHorseSelect_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startRace_Click(object sender, EventArgs e)
        {
            horse.Run();
            timer1.Start();
            this.counter1 = false;
            this.counter2 = false;
            this.counter3 = false;
        }

        private void textBoxSietse_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxLidy_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxFer_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
