using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Concepts
{
    public partial class PersonagePanel : UserControl
    {
        public PersonagePanel( ref Personage person )
        {
            this.InitializeComponent();
            this.personage = person;
        }

        private void PersonagePanel_Load(object sender, EventArgs e)
        {
            this.lblLevel.Text = "Уровень: " + this.personage.Level.ToString();
            this.pbExpirience.Maximum = 100;
            if ( this.personage.MaxExpirience > 0 )
                this.pbExpirience.Value = (int)this.personage.Expirience * 100/this.personage.MaxExpirience;
            this.lblExpirienceState.Text = this.personage.Expirience.ToString() + "/" + this.personage.MaxExpirience.ToString();

            this.pbHitPoints.Maximum = 100;
            if ( this.personage.MaxHealth > 0 )
                this.pbHitPoints.Value = (int)this.personage.Health * 100 / this.personage.MaxHealth;
            this.lblHitPointsState.Text = this.personage.Health.ToString() + "/" + this.personage.MaxHealth.ToString();

            this.pbEnergy.Maximum = 100;
            if ( this.personage.MaxEnergy > 0 )
                this.pbEnergy.Value = (int)this.personage.Energy * 100 / this.personage.MaxEnergy;
            this.lblEnergyState.Text = this.personage.Energy.ToString() + "/" + this.personage.MaxEnergy.ToString();
        }
    }
}
