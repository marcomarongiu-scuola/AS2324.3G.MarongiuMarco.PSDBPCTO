namespace AS2324._3G.MarongiuMarco.PSDBPCTO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDB = new DataGridView();
            btnPiloti = new Button();
            btnGare = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDB).BeginInit();
            SuspendLayout();
            // 
            // dgvDB
            // 
            dgvDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDB.Location = new Point(-1, 251);
            dgvDB.Name = "dgvDB";
            dgvDB.RowHeadersWidth = 45;
            dgvDB.RowTemplate.Height = 27;
            dgvDB.Size = new Size(807, 208);
            dgvDB.TabIndex = 0;
            // 
            // btnPiloti
            // 
            btnPiloti.Location = new Point(12, 12);
            btnPiloti.Name = "btnPiloti";
            btnPiloti.Size = new Size(119, 25);
            btnPiloti.TabIndex = 1;
            btnPiloti.Text = "Elenco Piloti";
            btnPiloti.UseVisualStyleBackColor = true;
            btnPiloti.Click += btnPiloti_Click;
            // 
            // btnGare
            // 
            btnGare.Location = new Point(182, 14);
            btnGare.Name = "btnGare";
            btnGare.Size = new Size(102, 25);
            btnGare.TabIndex = 2;
            btnGare.Text = "Elenco Gare";
            btnGare.UseVisualStyleBackColor = true;
            btnGare.Click += btnGare_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGare);
            Controls.Add(btnPiloti);
            Controls.Add(dgvDB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDB;
        private Button btnPiloti;
        private Button btnGare;
    }
}