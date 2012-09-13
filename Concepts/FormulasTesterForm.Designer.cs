namespace Concepts
{
    partial class FormulasTesterForm
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
            this.components = new System.ComponentModel.Container();
            this.zgcGraph = new ZedGraph.ZedGraphControl();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.nudMaxLevel = new System.Windows.Forms.NumericUpDown();
            this.lblMaxLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // zgcGraph
            // 
            this.zgcGraph.Location = new System.Drawing.Point(12, 12);
            this.zgcGraph.Name = "zgcGraph";
            this.zgcGraph.ScrollGrace = 0;
            this.zgcGraph.ScrollMaxX = 0;
            this.zgcGraph.ScrollMaxY = 0;
            this.zgcGraph.ScrollMaxY2 = 0;
            this.zgcGraph.ScrollMinX = 0;
            this.zgcGraph.ScrollMinY = 0;
            this.zgcGraph.ScrollMinY2 = 0;
            this.zgcGraph.Size = new System.Drawing.Size(742, 405);
            this.zgcGraph.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(570, 423);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(679, 423);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // nudMaxLevel
            // 
            this.nudMaxLevel.Location = new System.Drawing.Point(148, 426);
            this.nudMaxLevel.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMaxLevel.Name = "nudMaxLevel";
            this.nudMaxLevel.Size = new System.Drawing.Size(68, 20);
            this.nudMaxLevel.TabIndex = 3;
            this.nudMaxLevel.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblMaxLevel
            // 
            this.lblMaxLevel.AutoSize = true;
            this.lblMaxLevel.Location = new System.Drawing.Point(12, 428);
            this.lblMaxLevel.Name = "lblMaxLevel";
            this.lblMaxLevel.Size = new System.Drawing.Size(130, 13);
            this.lblMaxLevel.TabIndex = 4;
            this.lblMaxLevel.Text = "Максимальный уровень";
            // 
            // FormulasTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 458);
            this.Controls.Add(this.lblMaxLevel);
            this.Controls.Add(this.nudMaxLevel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.zgcGraph);
            this.Name = "FormulasTesterForm";
            this.Text = "FormulasTesterForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zgcGraph;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown nudMaxLevel;
        private System.Windows.Forms.Label lblMaxLevel;
    }
}