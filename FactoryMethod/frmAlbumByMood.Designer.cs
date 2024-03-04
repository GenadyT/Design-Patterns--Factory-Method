namespace FactoryMethod
{
    partial class frmAlbumByMood
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
            btnGetAlbumByTheMood = new Button();
            tblAlbumTracks = new TextBox();
            label1 = new Label();
            pnlAlbumData = new Panel();
            tbxBandName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbxAlbumName = new TextBox();
            cmbMoods = new ComboBox();
            pnlAlbumData.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetAlbumByTheMood
            // 
            btnGetAlbumByTheMood.AutoSize = true;
            btnGetAlbumByTheMood.BackColor = Color.FromArgb(139, 193, 217);
            btnGetAlbumByTheMood.FlatAppearance.BorderColor = Color.Red;
            btnGetAlbumByTheMood.FlatStyle = FlatStyle.Flat;
            btnGetAlbumByTheMood.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetAlbumByTheMood.Location = new Point(259, 36);
            btnGetAlbumByTheMood.Name = "btnGetAlbumByTheMood";
            btnGetAlbumByTheMood.Size = new Size(148, 31);
            btnGetAlbumByTheMood.TabIndex = 1;
            btnGetAlbumByTheMood.Text = "get album by the mood";
            btnGetAlbumByTheMood.UseVisualStyleBackColor = false;
            btnGetAlbumByTheMood.Click += btnGetAlbumData_Click;
            // 
            // tblAlbumTracks
            // 
            tblAlbumTracks.Enabled = false;
            tblAlbumTracks.Location = new Point(22, 152);
            tblAlbumTracks.Margin = new Padding(10);
            tblAlbumTracks.Multiline = true;
            tblAlbumTracks.Name = "tblAlbumTracks";
            tblAlbumTracks.Size = new Size(340, 158);
            tblAlbumTracks.TabIndex = 2;
            tblAlbumTracks.TextChanged += tblAlbumTracks_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 41);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 3;
            label1.Text = "Your mood:";
            // 
            // pnlAlbumData
            // 
            pnlAlbumData.BorderStyle = BorderStyle.FixedSingle;
            pnlAlbumData.Controls.Add(tbxBandName);
            pnlAlbumData.Controls.Add(label4);
            pnlAlbumData.Controls.Add(label3);
            pnlAlbumData.Controls.Add(label2);
            pnlAlbumData.Controls.Add(tbxAlbumName);
            pnlAlbumData.Controls.Add(tblAlbumTracks);
            pnlAlbumData.Location = new Point(22, 86);
            pnlAlbumData.Name = "pnlAlbumData";
            pnlAlbumData.Size = new Size(385, 336);
            pnlAlbumData.TabIndex = 4;
            pnlAlbumData.Tag = "aaaa";
            // 
            // tbxBandName
            // 
            tbxBandName.Enabled = false;
            tbxBandName.Location = new Point(115, 21);
            tbxBandName.Name = "tbxBandName";
            tbxBandName.Size = new Size(248, 25);
            tbxBandName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 24);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 5;
            label4.Text = "Band";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 121);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 4;
            label3.Text = "Album Tracks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 3;
            label2.Text = "Album Name";
            // 
            // tbxAlbumName
            // 
            tbxAlbumName.Enabled = false;
            tbxAlbumName.Location = new Point(115, 66);
            tbxAlbumName.Name = "tbxAlbumName";
            tbxAlbumName.Size = new Size(247, 25);
            tbxAlbumName.TabIndex = 0;
            // 
            // cmbMoods
            // 
            cmbMoods.FormattingEnabled = true;
            cmbMoods.Location = new Point(106, 39);
            cmbMoods.Name = "cmbMoods";
            cmbMoods.Size = new Size(137, 25);
            cmbMoods.TabIndex = 5;
            // 
            // frmAlbumByMood
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 446);
            Controls.Add(cmbMoods);
            Controls.Add(pnlAlbumData);
            Controls.Add(label1);
            Controls.Add(btnGetAlbumByTheMood);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmAlbumByMood";
            Padding = new Padding(3);
            Text = "Select music album according to your mood";
            pnlAlbumData.ResumeLayout(false);
            pnlAlbumData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGetAlbumByTheMood;
        private TextBox tblAlbumTracks;
        private Label label1;
        private Panel pnlAlbumData;
        private TextBox tbxAlbumName;
        private ComboBox cmbMoods;
        private Label label3;
        private Label label2;
        private TextBox tbxBandName;
        private Label label4;
    }
}