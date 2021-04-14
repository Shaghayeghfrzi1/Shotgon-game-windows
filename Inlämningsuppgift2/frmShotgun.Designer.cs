namespace Inlämningsuppgift2
{
    partial class frmShotgun
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
            this.cmdLadda = new System.Windows.Forms.Button();
            this.cmdSkjuta = new System.Windows.Forms.Button();
            this.cmdBlocka = new System.Windows.Forms.Button();
            this.cmdShotgun = new System.Windows.Forms.Button();
            this.cmdSystem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYourShoots = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSystemsShoots = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmdPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdLadda
            // 
            this.cmdLadda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdLadda.Location = new System.Drawing.Point(53, 102);
            this.cmdLadda.Name = "cmdLadda";
            this.cmdLadda.Size = new System.Drawing.Size(98, 99);
            this.cmdLadda.TabIndex = 0;
            this.cmdLadda.Text = "Ladda";
            this.cmdLadda.UseVisualStyleBackColor = false;
            this.cmdLadda.Click += new System.EventHandler(this.cmdLadda_Click_1);
            // 
            // cmdSkjuta
            // 
            this.cmdSkjuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdSkjuta.Enabled = false;
            this.cmdSkjuta.Location = new System.Drawing.Point(285, 102);
            this.cmdSkjuta.Name = "cmdSkjuta";
            this.cmdSkjuta.Size = new System.Drawing.Size(98, 99);
            this.cmdSkjuta.TabIndex = 1;
            this.cmdSkjuta.Text = "Skjuta";
            this.cmdSkjuta.UseVisualStyleBackColor = false;
            this.cmdSkjuta.Click += new System.EventHandler(this.cmdSkjuta_Click);
            // 
            // cmdBlocka
            // 
            this.cmdBlocka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdBlocka.Location = new System.Drawing.Point(169, 102);
            this.cmdBlocka.Name = "cmdBlocka";
            this.cmdBlocka.Size = new System.Drawing.Size(98, 99);
            this.cmdBlocka.TabIndex = 2;
            this.cmdBlocka.Text = "Blocka";
            this.cmdBlocka.UseVisualStyleBackColor = false;
            this.cmdBlocka.Click += new System.EventHandler(this.cmdBlocka_Click_1);
            // 
            // cmdShotgun
            // 
            this.cmdShotgun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmdShotgun.Location = new System.Drawing.Point(401, 102);
            this.cmdShotgun.Name = "cmdShotgun";
            this.cmdShotgun.Size = new System.Drawing.Size(98, 99);
            this.cmdShotgun.TabIndex = 3;
            this.cmdShotgun.Text = "Shotgun";
            this.cmdShotgun.UseVisualStyleBackColor = false;
            this.cmdShotgun.Visible = false;
            this.cmdShotgun.Click += new System.EventHandler(this.cmdShotgun_Click_1);
            // 
            // cmdSystem
            // 
            this.cmdSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdSystem.Enabled = false;
            this.cmdSystem.Location = new System.Drawing.Point(747, 102);
            this.cmdSystem.Name = "cmdSystem";
            this.cmdSystem.Size = new System.Drawing.Size(98, 99);
            this.cmdSystem.TabIndex = 4;
            this.cmdSystem.Text = "Motståndare";
            this.cmdSystem.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dina skott: ";
            // 
            // lblYourShoots
            // 
            this.lblYourShoots.AutoSize = true;
            this.lblYourShoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourShoots.Location = new System.Drawing.Point(212, 294);
            this.lblYourShoots.Name = "lblYourShoots";
            this.lblYourShoots.Size = new System.Drawing.Size(26, 29);
            this.lblYourShoots.TabIndex = 6;
            this.lblYourShoots.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Motståndares skott:";
            // 
            // lblSystemsShoots
            // 
            this.lblSystemsShoots.AutoSize = true;
            this.lblSystemsShoots.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemsShoots.Location = new System.Drawing.Point(309, 354);
            this.lblSystemsShoots.Name = "lblSystemsShoots";
            this.lblSystemsShoots.Size = new System.Drawing.Size(26, 29);
            this.lblSystemsShoots.TabIndex = 8;
            this.lblSystemsShoots.Text = "0";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(380, 309);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(458, 45);
            this.txtResult.TabIndex = 9;
            this.txtResult.Visible = false;
            // 
            // cmdPlayAgain
            // 
            this.cmdPlayAgain.BackColor = System.Drawing.Color.Green;
            this.cmdPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPlayAgain.ForeColor = System.Drawing.Color.Red;
            this.cmdPlayAgain.Location = new System.Drawing.Point(489, 360);
            this.cmdPlayAgain.Name = "cmdPlayAgain";
            this.cmdPlayAgain.Size = new System.Drawing.Size(255, 44);
            this.cmdPlayAgain.TabIndex = 10;
            this.cmdPlayAgain.Text = "Spela igen";
            this.cmdPlayAgain.UseVisualStyleBackColor = false;
            this.cmdPlayAgain.Visible = false;
            this.cmdPlayAgain.Click += new System.EventHandler(this.cmdPlayAgain_Click);
            // 
            // frmShotgun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 479);
            this.Controls.Add(this.cmdPlayAgain);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblSystemsShoots);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblYourShoots);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSystem);
            this.Controls.Add(this.cmdShotgun);
            this.Controls.Add(this.cmdBlocka);
            this.Controls.Add(this.cmdSkjuta);
            this.Controls.Add(this.cmdLadda);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShotgun";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHOTGUN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLadda;
        private System.Windows.Forms.Button cmdSkjuta;
        private System.Windows.Forms.Button cmdBlocka;
        private System.Windows.Forms.Button cmdShotgun;
        private System.Windows.Forms.Button cmdSystem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYourShoots;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSystemsShoots;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button cmdPlayAgain;
    }
}

