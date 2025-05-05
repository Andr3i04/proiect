namespace proiect
{
    partial class Game
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
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblDealerSum = new System.Windows.Forms.Label();
            this.lblPlayerSum = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.White;
            this.btnHit.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(387, 545);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(101, 37);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(533, 545);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(101, 37);
            this.btnStand.TabIndex = 1;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(12, 510);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(66, 23);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player";
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(12, 111);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(67, 23);
            this.lblDealer.TabIndex = 3;
            this.lblDealer.Text = "Dealer";
            // 
            // lblDealerSum
            // 
            this.lblDealerSum.AutoSize = true;
            this.lblDealerSum.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerSum.Location = new System.Drawing.Point(12, 166);
            this.lblDealerSum.Name = "lblDealerSum";
            this.lblDealerSum.Size = new System.Drawing.Size(122, 18);
            this.lblDealerSum.TabIndex = 4;
            this.lblDealerSum.Text = "Dealer\'s sum : 0";
            // 
            // lblPlayerSum
            // 
            this.lblPlayerSum.AutoSize = true;
            this.lblPlayerSum.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerSum.Location = new System.Drawing.Point(12, 461);
            this.lblPlayerSum.Name = "lblPlayerSum";
            this.lblPlayerSum.Size = new System.Drawing.Size(120, 18);
            this.lblPlayerSum.TabIndex = 5;
            this.lblPlayerSum.Text = "Player\'s sum : 0";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(921, 12);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(75, 23);
            this.btnPlayAgain.TabIndex = 6;
            this.btnPlayAgain.Text = "Play again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proiect.Properties.Resources.poza_masa;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblPlayerSum);
            this.Controls.Add(this.lblDealerSum);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblDealerSum;
        private System.Windows.Forms.Label lblPlayerSum;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}