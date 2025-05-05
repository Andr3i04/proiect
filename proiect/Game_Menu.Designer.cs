namespace proiect
{
    partial class Game_Menu
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHop = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.Color.Gold;
            this.btnStart.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(404, 296);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 50);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Game";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHop
            // 
            this.btnHop.BackColor = System.Drawing.Color.Gold;
            this.btnHop.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHop.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHop.ForeColor = System.Drawing.Color.Red;
            this.btnHop.Location = new System.Drawing.Point(422, 352);
            this.btnHop.Name = "btnHop";
            this.btnHop.Size = new System.Drawing.Size(165, 35);
            this.btnHop.TabIndex = 1;
            this.btnHop.Text = "How to play";
            this.btnHop.UseVisualStyleBackColor = false;
            this.btnHop.Click += new System.EventHandler(this.btnHop_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Gold;
            this.btnRules.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.ForeColor = System.Drawing.Color.Red;
            this.btnRules.Location = new System.Drawing.Point(422, 393);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(165, 35);
            this.btnRules.TabIndex = 2;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // Game_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::proiect.Properties.Resources.poza_masa;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnHop);
            this.Controls.Add(this.btnStart);
            this.Name = "Game_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHop;
        private System.Windows.Forms.Button btnRules;
    }
}

