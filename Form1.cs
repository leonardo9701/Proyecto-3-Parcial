namespace Proyecto_3_Parcial
{
    public partial class Form1 : Form
    {
        public int actual = 0;
        public string nombre = "";
        public string gracioso = "";
        public string interesante = "";
        public string narrativa = "";
        public string descripcion = "";
        public string argumentos = "";
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L1;
            actual++;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            textBox1.Visible = false;
            circularButtom2.Visible = false;
            circularButtom1.Visible = false;
        }

        private void Form1_keyCode(object sender, KeyPressEventArgs e)
        {
            if (actual == 1)
            {
                pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L2;
                actual++;
                button1.Visible = true;
                button1.FlatAppearance.BorderSize = 0;
                button1.FlatStyle = FlatStyle.Flat;
            }
        }

        private void Form1_button(object sender, EventArgs e)
        {
            button1.Visible = false;
            pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L3;
            button2.Visible = true;
            button3.Visible = false;
            textBox1.Visible = true;
            actual++;
        }

        private void Form1_button2(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            if (nombre.Length > 0)
            {
                button2.Visible = false;
                textBox1.Visible = false;
                pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L4;
                circularButtom2.Visible = true;
                circularButtom1.Visible = true;
                actual++;
            }
            else
            {
                button2.Visible = false;
                textBox1.Visible = false;
                pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L12;
                button3.Visible = true;
            }
        }

        private void Form1_button_si(object sender, EventArgs e)
        {
            if (actual == 4)
            {
                gracioso = "y";
                actual++;
                pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L5;
            } else if (actual == 5)
            {
                interesante = "y";
                actual++;
                pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L6;
            } else if (actual == 6)
            {
                narrativa = "y";
                actual++;
                pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L7;
            } else if (actual == 7)
            {
                descripcion = "y";
                actual++;
                pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L8;
            } else if (actual == 8)
            {
                argumentos = "y";
                if (gracioso == "y")
                {
                    if (interesante == "y")
                    {
                        circularButtom2.Visible = false;
                        circularButtom1.Visible = false;
                        pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L9;
                        button4.Visible = true;
                    }
                    else
                    {
                        if (narrativa == "y")
                        {
                            if (descripcion == "y")
                            {
                                if (argumentos == "y")
                                {
                                    circularButtom2.Visible = false;
                                    circularButtom1.Visible = false;
                                    pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L10;
                                    button4.Visible = true;
                                }
                            }
                        }
                        else
                        {
                            circularButtom2.Visible = false;
                            circularButtom1.Visible = false;
                            pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L11;
                            button4.Visible = true;
                        }
                    }
                }
                else
                {
                    if (interesante == "y")
                    {
                        if (narrativa == "y")
                        {
                            if (descripcion == "y")
                            {
                                if (argumentos == "y")
                                {
                                    circularButtom2.Visible = false;
                                    circularButtom1.Visible = false;
                                    pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L10;
                                    button4.Visible = true;
                                }
                            }
                        }
                    }
                }
            }

        }

        private void Form1_button_No(object sender, EventArgs e)
        {
            if (actual == 4)
            {
                actual++;
                pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L5;
            } else if (actual == 5)
            {
                actual++;
                pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L6;
            } else if (actual == 6)
            {
                actual++;
                pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L7;
            } else if (actual == 7)
            {
                actual++;
                pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L8;
            } else if (actual == 8)
            {
                if (gracioso == "y")
                {
                    if (interesante == "y")
                    {
                        circularButtom2.Visible = false;
                        circularButtom1.Visible = false;
                        pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L9;
                        button4.Visible = true;
                    }
                    else
                    {
                        if (narrativa == "y")
                        {
                            if (descripcion == "y")
                            {
                                if (argumentos == "y")
                                {
                                    circularButtom2.Visible = false;
                                    circularButtom1.Visible = false;
                                    pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L10;
                                    button4.Visible = true;
                                }
                            }
                        }
                        else
                        {
                            circularButtom2.Visible = false;
                            circularButtom1.Visible = false;
                            pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L11;
                            button4.Visible = true;
                        }
                    }
                }
                else
                {
                    if (interesante == "y")
                    {
                        if (narrativa == "y")
                        {
                            if (descripcion == "y")
                            {
                                if (argumentos == "y")
                                {
                                    circularButtom2.Visible = false;
                                    circularButtom1.Visible = false;
                                    pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L10;
                                    button4.Visible = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Form1_button3(object sender, EventArgs e)
        {
            button4.Visible = false;
            pictureBox1.Image = Proyecto_3_Parcial.Properties.Resources.L2;
            button1.Visible = true;
        }
    }
}