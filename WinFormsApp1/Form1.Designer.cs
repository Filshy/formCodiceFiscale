namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblOutput = new Label();
            txtCognome = new TextBox();
            txtNome = new TextBox();
            txtData = new TextBox();
            txtComune = new TextBox();
            txtSesso = new TextBox();
            btnCalcolo = new Button();
            label3 = new Label();
            comboBoxSesso = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            lblDev = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.Anchor = AnchorStyles.None;
            lblOutput.BackColor = Color.Transparent;
            lblOutput.Font = new Font("Arial", 25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblOutput.ForeColor = Color.White;
            lblOutput.Location = new Point(648, 115);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(471, 83);
            lblOutput.TabIndex = 0;
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCognome
            // 
            txtCognome.AcceptsReturn = true;
            txtCognome.Anchor = AnchorStyles.None;
            txtCognome.BackColor = Color.White;
            txtCognome.BorderStyle = BorderStyle.None;
            txtCognome.CausesValidation = false;
            txtCognome.CharacterCasing = CharacterCasing.Upper;
            txtCognome.Font = new Font("Arial", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCognome.ForeColor = Color.Black;
            txtCognome.Location = new Point(313, 241);
            txtCognome.Name = "txtCognome";
            txtCognome.PlaceholderText = "ROSSI";
            txtCognome.Size = new Size(810, 38);
            txtCognome.TabIndex = 1;
            txtCognome.TextAlign = HorizontalAlignment.Center;
            txtCognome.TextChanged += txtCognome_TextChanged;
            // 
            // txtNome
            // 
            txtNome.AcceptsReturn = true;
            txtNome.Anchor = AnchorStyles.None;
            txtNome.BackColor = Color.White;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Font = new Font("Arial", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(313, 325);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "MARIO";
            txtNome.Size = new Size(810, 39);
            txtNome.TabIndex = 2;
            txtNome.TextAlign = HorizontalAlignment.Center;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtData
            // 
            txtData.Anchor = AnchorStyles.None;
            txtData.BackColor = Color.Brown;
            txtData.BorderStyle = BorderStyle.None;
            txtData.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            txtData.Location = new Point(324, 12);
            txtData.Name = "txtData";
            txtData.Size = new Size(810, 36);
            txtData.TabIndex = 3;
            txtData.Text = "GG/MM/AAAA";
            txtData.TextAlign = HorizontalAlignment.Center;
            txtData.Visible = false;
            txtData.TextChanged += txtData_TextChanged;
            // 
            // txtComune
            // 
            txtComune.Anchor = AnchorStyles.None;
            txtComune.BackColor = Color.White;
            txtComune.BorderStyle = BorderStyle.None;
            txtComune.CharacterCasing = CharacterCasing.Upper;
            txtComune.Font = new Font("Arial", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtComune.Location = new Point(313, 571);
            txtComune.Name = "txtComune";
            txtComune.PlaceholderText = "TORINO";
            txtComune.Size = new Size(560, 39);
            txtComune.TabIndex = 4;
            txtComune.TextAlign = HorizontalAlignment.Center;
            txtComune.TextChanged += txtComune_TextChanged;
            // 
            // txtSesso
            // 
            txtSesso.Anchor = AnchorStyles.None;
            txtSesso.BackColor = SystemColors.ActiveCaption;
            txtSesso.BorderStyle = BorderStyle.None;
            txtSesso.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            txtSesso.Location = new Point(39, 634);
            txtSesso.Name = "txtSesso";
            txtSesso.Size = new Size(76, 36);
            txtSesso.TabIndex = 5;
            txtSesso.Text = "M/F";
            txtSesso.TextAlign = HorizontalAlignment.Center;
            txtSesso.Visible = false;
            txtSesso.TextChanged += txtBox_TextChanged;
            // 
            // btnCalcolo
            // 
            btnCalcolo.Anchor = AnchorStyles.None;
            btnCalcolo.BackColor = Color.DarkSeaGreen;
            btnCalcolo.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnCalcolo.FlatAppearance.BorderSize = 5;
            btnCalcolo.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            btnCalcolo.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnCalcolo.Font = new Font("Arial", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcolo.Location = new Point(928, 558);
            btnCalcolo.Name = "btnCalcolo";
            btnCalcolo.Size = new Size(206, 72);
            btnCalcolo.TabIndex = 6;
            btnCalcolo.Text = "AVVIA CALCOLO";
            btnCalcolo.UseVisualStyleBackColor = false;
            btnCalcolo.Click += btnCalcolo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.Red;
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(648, 64);
            label3.Name = "label3";
            label3.Size = new Size(0, 37);
            label3.TabIndex = 9;
            // 
            // comboBoxSesso
            // 
            comboBoxSesso.Anchor = AnchorStyles.None;
            comboBoxSesso.Font = new Font("Arial", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSesso.FormattingEnabled = true;
            comboBoxSesso.Items.AddRange(new object[] { "M", "F" });
            comboBoxSesso.Location = new Point(304, 488);
            comboBoxSesso.Name = "comboBoxSesso";
            comboBoxSesso.Size = new Size(830, 46);
            comboBoxSesso.TabIndex = 12;
            comboBoxSesso.SelectedIndexChanged += comboBoxSesso_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 10F);
            dateTimePicker1.CustomFormat = "dd MM yyyy";
            dateTimePicker1.Font = new Font("Arial", 29F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(304, 402);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(830, 52);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(2);
            pictureBox1.Size = new Size(182, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblDev
            // 
            lblDev.BackColor = Color.Transparent;
            lblDev.Font = new Font("Segoe UI", 20F);
            lblDev.Location = new Point(334, 131);
            lblDev.Name = "lblDev";
            lblDev.Size = new Size(284, 67);
            lblDev.TabIndex = 15;
            lblDev.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(953, 641);
            label1.Name = "label1";
            label1.Size = new Size(199, 39);
            label1.TabIndex = 16;
            label1.Text = "sviluppato da Cristian Framorando";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1164, 682);
            Controls.Add(label1);
            Controls.Add(lblDev);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxSesso);
            Controls.Add(label3);
            Controls.Add(btnCalcolo);
            Controls.Add(txtSesso);
            Controls.Add(txtComune);
            Controls.Add(txtData);
            Controls.Add(txtNome);
            Controls.Add(txtCognome);
            Controls.Add(lblOutput);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            ShowIcon = false;
            Text = "Codice Fiscale";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private TextBox txtCognome;
        private TextBox txtNome;
        private TextBox txtData;
        private TextBox txtComune;
        private TextBox txtSesso;
        private Button btnCalcolo;
        private Label label3;
        private ComboBox comboBoxSesso;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Label lblDev;
        private Label label1;
    }
}
