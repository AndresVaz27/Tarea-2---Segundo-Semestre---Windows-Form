﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_2___Segundo_Semestre
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

        private void lblImprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTelefono1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Contacto x;
           x= new Contacto();
            x.Nombre= txtNombre1.Text;
            x.Telefono= txtTelefono1.Text;
            x.FechaNacimiento = DateTime.Parse("2003/01/01");
            
            lblImprimir.Text = "Tu nombre es " + x.Nombre + ", tienes " + x.Edad + " años, y tu número de teléfono es " + x.Telefono + ".";
        
        }
    }
}