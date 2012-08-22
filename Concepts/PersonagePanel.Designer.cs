namespace Concepts
{
    partial class PersonagePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Personage personage;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblName = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblExpirience = new System.Windows.Forms.Label();
            this.pbExpirience = new System.Windows.Forms.ProgressBar();
            this.pbHitPoints = new System.Windows.Forms.ProgressBar();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.pbEnergy = new System.Windows.Forms.ProgressBar();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblExpirienceState = new System.Windows.Forms.Label();
            this.lblHitPointsState = new System.Windows.Forms.Label();
            this.lblEnergyState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.Location = new System.Drawing.Point(13, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(47, 23);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Имя:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(14, 48);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(54, 13);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "Уровень:";
            // 
            // lblExpirience
            // 
            this.lblExpirience.AutoSize = true;
            this.lblExpirience.Location = new System.Drawing.Point(103, 48);
            this.lblExpirience.Name = "lblExpirience";
            this.lblExpirience.Size = new System.Drawing.Size(37, 13);
            this.lblExpirience.TabIndex = 2;
            this.lblExpirience.Text = "Опыт:";
            // 
            // pbExpirience
            // 
            this.pbExpirience.Location = new System.Drawing.Point(146, 44);
            this.pbExpirience.Name = "pbExpirience";
            this.pbExpirience.Size = new System.Drawing.Size(141, 17);
            this.pbExpirience.TabIndex = 3;
            // 
            // pbHitPoints
            // 
            this.pbHitPoints.Location = new System.Drawing.Point(99, 69);
            this.pbHitPoints.Name = "pbHitPoints";
            this.pbHitPoints.Size = new System.Drawing.Size(188, 17);
            this.pbHitPoints.TabIndex = 5;
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(16, 71);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(77, 13);
            this.lblHitPoints.TabIndex = 4;
            this.lblHitPoints.Text = "Повреждения";
            // 
            // pbEnergy
            // 
            this.pbEnergy.Location = new System.Drawing.Point(99, 92);
            this.pbEnergy.Name = "pbEnergy";
            this.pbEnergy.Size = new System.Drawing.Size(188, 17);
            this.pbEnergy.TabIndex = 7;
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(16, 94);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(49, 13);
            this.lblEnergy.TabIndex = 6;
            this.lblEnergy.Text = "Энергия";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(16, 34);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(41, 13);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "Класс:";
            // 
            // lblExpirienceState
            // 
            this.lblExpirienceState.AutoSize = true;
            this.lblExpirienceState.BackColor = System.Drawing.SystemColors.Control;
            this.lblExpirienceState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExpirienceState.Location = new System.Drawing.Point(196, 46);
            this.lblExpirienceState.Name = "lblExpirienceState";
            this.lblExpirienceState.Size = new System.Drawing.Size(24, 13);
            this.lblExpirienceState.TabIndex = 9;
            this.lblExpirienceState.Text = "0/0";
            this.lblExpirienceState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHitPointsState
            // 
            this.lblHitPointsState.AutoSize = true;
            this.lblHitPointsState.BackColor = System.Drawing.SystemColors.Control;
            this.lblHitPointsState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHitPointsState.Location = new System.Drawing.Point(182, 71);
            this.lblHitPointsState.Name = "lblHitPointsState";
            this.lblHitPointsState.Size = new System.Drawing.Size(24, 13);
            this.lblHitPointsState.TabIndex = 10;
            this.lblHitPointsState.Text = "0/0";
            this.lblHitPointsState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnergyState
            // 
            this.lblEnergyState.AutoSize = true;
            this.lblEnergyState.BackColor = System.Drawing.SystemColors.Control;
            this.lblEnergyState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnergyState.Location = new System.Drawing.Point(182, 94);
            this.lblEnergyState.Name = "lblEnergyState";
            this.lblEnergyState.Size = new System.Drawing.Size(24, 13);
            this.lblEnergyState.TabIndex = 11;
            this.lblEnergyState.Text = "0/0";
            this.lblEnergyState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblEnergyState);
            this.Controls.Add(this.lblHitPointsState);
            this.Controls.Add(this.lblExpirienceState);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.pbEnergy);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.pbHitPoints);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.pbExpirience);
            this.Controls.Add(this.lblExpirience);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.LblName);
            this.Name = "PersonagePanel";
            this.Size = new System.Drawing.Size(340, 124);
            this.Load += new System.EventHandler(this.PersonagePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblExpirience;
        private System.Windows.Forms.ProgressBar pbExpirience;
        private System.Windows.Forms.ProgressBar pbHitPoints;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.ProgressBar pbEnergy;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblExpirienceState;
        private System.Windows.Forms.Label lblHitPointsState;
        private System.Windows.Forms.Label lblEnergyState;
    }
}
