using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Concepts
{
    public partial class ConceptsMainForm : Form
    {
        private Personage[] party1;
        private Personage[] party2;

        public ConceptsMainForm(){
            this.InitializeComponent();
            this.party1 = new Personage[0];
        }

        private void tsmiPersonagesAdd_Click(object sender, EventArgs e)
        {
            int sz = party1.Length;
            System.Array.Resize<Personage>( ref party1, party1.Length + 1);
            party1[sz] = new Personage(Class.Mage, 1);

            PersonagePanel panel = new PersonagePanel( ref party1[sz] );
            this.tlpCharacters.Controls.Add(panel, sz-1, 0);

        }

        private void btnLevelUp_Click(object sender, EventArgs e)
        {
            party1[0].LevelUp();
            PersonagePanel panel = (PersonagePanel)this.tlpCharacters.GetControlFromPosition(0, 0);
            this.tlpCharacters.Controls.Remove(panel);

            panel = new PersonagePanel(ref party1[0]);
            this.tlpCharacters.Controls.Add(panel, 0, 0);
        }

        private void tsmiFormulas_Click(object sender, EventArgs e)
        {
            FormulasTesterForm frm = new FormulasTesterForm();
            frm.ShowDialog();
        }
    }
}