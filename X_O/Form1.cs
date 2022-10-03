using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O
{
    public partial class Form1 : Form
    {
        string t = "";
        Random rnd = new Random();
        int[] array = new int[9];
        Button[] btn = new Button[9];
        int step;

        public Form1()
        {
            InitializeComponent();

            if(rnd.Next(1,10) <= 5)
            {
                t = "Крестики";
                label1.Text = "Ходят X";

            }

            else 
            {
                t = "Ходят 0";
                label1.Text = "Ходят 0";
            }

            step = 0;

            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            btn[4] = button5;
            btn[5] = button6;
            btn[6] = button7;
            btn[7] = button8;
            btn[8] = button9;
        }

        

        private void button_1click(object sender, EventArgs e)
        {            
         

            if (t == "Крестики") //Кретики
                        {
                            for(int i=0;i < btn.Length; i++)
                            {
                                if (sender == btn[i])
                                {
                                    step++; 
                                    btn[i].Image =Properties.Resources.x2;
                                    label1.Text = "Ходят 0";
                                    t = "1";
                                    btn[i].Enabled= false;
                                    array[i] = 1;
                                    break;
                                }
                            }
                        }

                            else //Нолики
                                {
                            for (int i = 0; i < btn.Length; i++)
                            {
                                if (sender == btn[i])
                                {
                                    step++;
                                    btn[i].Image = Properties.Resources._02;
                                    label1.Text = "Ходят X";
                                    t = "Крестики";
                                    btn[i].Enabled = false;
                                    array[i] = 2;
                                    break;
                                }
                            }
                        }
            
            

            //Выигрышные комбинации крестиков
            if (array[0]==1 && array[1] == 1 && array[2] == 1)
                  {
                      btn[0].BackColor = System.Drawing.Color.Red;
                      btn[1].BackColor = System.Drawing.Color.Red;
                      btn[2].BackColor = System.Drawing.Color.Red;
                         
                for(int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Крестики";
             }

            else if (array[3] == 1 && array[4] == 1 && array[5] == 1)
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Крестики";
            }

            else if (array[6] == 1 && array[7] == 1 && array[8] == 1)
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Крестики";
            }

            else if (array[0] == 1 && array[3] == 1 && array[6] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Крестики";
            }

            else if (array[1] == 1 && array[4] == 1 && array[7] == 1)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Крестики";
            }

            else if (array[2] == 1 && array[5] == 1 && array[8] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Крестики";
            }

            else if (array[0] == 1 && array[4] == 1 && array[8] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Крестики";
            }

            else if (array[2] == 1 && array[4] == 1 && array[6] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Крестики";
            }

            //Выиграшные комбинации ноликов
            else if (array[0] == 2 && array[1] == 2 && array[2] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[2].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Нолики";
            }

            else if (array[3] == 2 && array[4] == 2 && array[5] == 2)
            {
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Нолики";
            }

            else if (array[6] == 2 && array[7] == 2 && array[8] == 2)
            {
                btn[6].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Нолики";
            }

            else if (array[0] == 2 && array[3] == 2 && array[6] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[3].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Нолики";
            }

            else if (array[1] == 2 && array[4] == 2 && array[7] == 2)
            {
                btn[1].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[7].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Нолики";
            }

            else if (array[2] == 2 && array[5] == 2 && array[8] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[5].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Нолики";
            }

            else if (array[0] == 2 && array[4] == 2 && array[8] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[8].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Нолики";
            }

            else if (array[2] == 2 && array[4] == 2 && array[6] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Red;
                btn[4].BackColor = System.Drawing.Color.Red;
                btn[6].BackColor = System.Drawing.Color.Red;

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                button10.Enabled = true;
                label1.Text = "Выиграли Нолики";
            }

            else 
            {
                if (step == 9)
                {
                    button10.Enabled = true;
                    label1.Text = "Ничья!";
                }
                
            }
        }

        //Вывод текста
        private void label_1click(object sender, EventArgs e)
        {
            
        }

        //Перезапуск
        private void button_10click(object sender, EventArgs e)
        {
            for(int i = 0; i < btn.Length; i++)
            {
                array[i] = 0;
                btn[i].Text = "";

                if(rnd.Next(1,10) <= 5)
                {
                    t = "Крестики";
                    label1.Text = "Ходят X";
                }

                else
                {
                    t = "Ходят 0";
                    label1.Text = "Ходят 0";
                }

                btn[i].Enabled = true;
                btn[i].BackColor = System.Drawing.Color.White;
                btn[i].Image = default;
            }
        }

        private void label_2click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
