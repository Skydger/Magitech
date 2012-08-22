namespace Concepts
{
    partial class ConceptsMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpCharacters = new System.Windows.Forms.TableLayoutPanel();
            this.msConceptMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiPersonages = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonagesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActions = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLevelUp = new System.Windows.Forms.Button();
            this.msConceptMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCharacters
            // 
            this.tlpCharacters.ColumnCount = 2;
            this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharacters.Location = new System.Drawing.Point(0, 27);
            this.tlpCharacters.Name = "tlpCharacters";
            this.tlpCharacters.RowCount = 2;
            this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharacters.Size = new System.Drawing.Size(608, 248);
            this.tlpCharacters.TabIndex = 0;
            // 
            // msConceptMainMenu
            // 
            this.msConceptMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPersonages,
            this.tsmiActions});
            this.msConceptMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msConceptMainMenu.Name = "msConceptMainMenu";
            this.msConceptMainMenu.Size = new System.Drawing.Size(632, 24);
            this.msConceptMainMenu.TabIndex = 1;
            this.msConceptMainMenu.Text = "menuStrip1";
            // 
            // tsmiPersonages
            // 
            this.tsmiPersonages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPersonagesAdd});
            this.tsmiPersonages.Name = "tsmiPersonages";
            this.tsmiPersonages.Size = new System.Drawing.Size(83, 20);
            this.tsmiPersonages.Text = "Персонажи";
            // 
            // tsmiPersonagesAdd
            // 
            this.tsmiPersonagesAdd.Name = "tsmiPersonagesAdd";
            this.tsmiPersonagesAdd.Size = new System.Drawing.Size(152, 22);
            this.tsmiPersonagesAdd.Text = "Добавить";
            this.tsmiPersonagesAdd.Click += new System.EventHandler(this.tsmiPersonagesAdd_Click);
            // 
            // tsmiActions
            // 
            this.tsmiActions.Name = "tsmiActions";
            this.tsmiActions.Size = new System.Drawing.Size(70, 20);
            this.tsmiActions.Text = "Действия";
            // 
            // btnLevelUp
            // 
            this.btnLevelUp.Location = new System.Drawing.Point(12, 284);
            this.btnLevelUp.Name = "btnLevelUp";
            this.btnLevelUp.Size = new System.Drawing.Size(75, 23);
            this.btnLevelUp.TabIndex = 2;
            this.btnLevelUp.Text = "Уровень";
            this.btnLevelUp.UseVisualStyleBackColor = true;
            this.btnLevelUp.Click += new System.EventHandler(this.btnLevelUp_Click);
            // 
            // ConceptsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 319);
            this.Controls.Add(this.btnLevelUp);
            this.Controls.Add(this.tlpCharacters);
            this.Controls.Add(this.msConceptMainMenu);
            this.MainMenuStrip = this.msConceptMainMenu;
            this.Name = "ConceptsMainForm";
            this.Text = "Тестирование основных концептов";
            this.msConceptMainMenu.ResumeLayout(false);
            this.msConceptMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCharacters;
        private System.Windows.Forms.MenuStrip msConceptMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonages;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonagesAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiActions;
        private System.Windows.Forms.Button btnLevelUp;
    }
}

