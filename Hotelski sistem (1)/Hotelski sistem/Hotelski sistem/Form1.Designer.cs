namespace Hotelski_sistem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtIme = new TextBox();
            txtPriimek = new TextBox();
            numStarost = new NumericUpDown();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rbSoba = new RadioButton();
            rbLuksuz = new RadioButton();
            chkBazen = new CheckBox();
            rbHiska = new RadioButton();
            rbSotor = new RadioButton();
            chkElektrika = new CheckBox();
            btnRezerviraj = new Button();
            listBox1 = new ListBox();
            groupBox3 = new GroupBox();
            chkPokrito = new CheckBox();
            groupBox2 = new GroupBox();
            chkParkirisce = new CheckBox();
            label4 = new Label();
            numDni = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numStarost).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDni).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 30);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 65);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Priimek:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(70, 27);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(120, 27);
            txtIme.TabIndex = 2;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // txtPriimek
            // 
            txtPriimek.Location = new Point(70, 62);
            txtPriimek.Name = "txtPriimek";
            txtPriimek.Size = new Size(120, 27);
            txtPriimek.TabIndex = 3;
            // 
            // numStarost
            // 
            numStarost.Location = new Point(264, 62);
            numStarost.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numStarost.Name = "numStarost";
            numStarost.Size = new Size(34, 27);
            numStarost.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 65);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Starost:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSoba);
            groupBox1.Controls.Add(rbLuksuz);
            groupBox1.Controls.Add(chkBazen);
            groupBox1.Controls.Add(rbHiska);
            groupBox1.Controls.Add(rbSotor);
            groupBox1.Controls.Add(chkElektrika);
            groupBox1.Location = new Point(12, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 130);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tip nastanitve";
            // 
            // rbSoba
            // 
            rbSoba.Checked = true;
            rbSoba.Location = new Point(10, 20);
            rbSoba.Name = "rbSoba";
            rbSoba.Size = new Size(104, 24);
            rbSoba.TabIndex = 0;
            rbSoba.TabStop = true;
            rbSoba.Text = "Navadna soba";
            // 
            // rbLuksuz
            // 
            rbLuksuz.Location = new Point(10, 45);
            rbLuksuz.Name = "rbLuksuz";
            rbLuksuz.Size = new Size(104, 24);
            rbLuksuz.TabIndex = 1;
            rbLuksuz.Text = "Luksuzna soba";
            // 
            // chkBazen
            // 
            chkBazen.Location = new Point(120, 45);
            chkBazen.Name = "chkBazen";
            chkBazen.Size = new Size(104, 24);
            chkBazen.TabIndex = 2;
            chkBazen.Text = "Bazen";
            // 
            // rbHiska
            // 
            rbHiska.Location = new Point(10, 70);
            rbHiska.Name = "rbHiska";
            rbHiska.Size = new Size(104, 24);
            rbHiska.TabIndex = 3;
            rbHiska.Text = "Hiška";
            // 
            // rbSotor
            // 
            rbSotor.Location = new Point(10, 95);
            rbSotor.Name = "rbSotor";
            rbSotor.Size = new Size(104, 24);
            rbSotor.TabIndex = 4;
            rbSotor.Text = "Šotor";
            // 
            // chkElektrika
            // 
            chkElektrika.Location = new Point(120, 95);
            chkElektrika.Name = "chkElektrika";
            chkElektrika.Size = new Size(104, 24);
            chkElektrika.TabIndex = 5;
            chkElektrika.Text = "Elektrika";
            // 
            // btnRezerviraj
            // 
            btnRezerviraj.Location = new Point(102, 322);
            btnRezerviraj.Name = "btnRezerviraj";
            btnRezerviraj.Size = new Size(100, 25);
            btnRezerviraj.TabIndex = 5;
            btnRezerviraj.Text = "Rezerviraj";
            // 
            // listBox1
            // 
            listBox1.Location = new Point(12, 360);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(473, 104);
            listBox1.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtIme);
            groupBox3.Controls.Add(txtPriimek);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(numStarost);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(350, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Podatki o gostu";
            // 
            // chkPokrito
            // 
            chkPokrito.Location = new Point(120, 20);
            chkPokrito.Name = "chkPokrito";
            chkPokrito.Size = new Size(104, 24);
            chkPokrito.TabIndex = 1;
            chkPokrito.Text = "Pokrito parkirišče";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkParkirisce);
            groupBox2.Controls.Add(chkPokrito);
            groupBox2.Location = new Point(12, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 50);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Parkirišče";
            // 
            // chkParkirisce
            // 
            chkParkirisce.Location = new Point(10, 20);
            chkParkirisce.Name = "chkParkirisce";
            chkParkirisce.Size = new Size(104, 24);
            chkParkirisce.TabIndex = 0;
            chkParkirisce.Text = "Parkirišče";
            // 
            // label4
            // 
            label4.Location = new Point(12, 322);
            label4.Name = "label4";
            label4.Size = new Size(34, 23);
            label4.TabIndex = 3;
            label4.Text = "Dni:";
            // 
            // numDni
            // 
            numDni.Location = new Point(45, 320);
            numDni.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            numDni.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDni.Name = "numDni";
            numDni.Size = new Size(38, 27);
            numDni.TabIndex = 4;
            numDni.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            ClientSize = new Size(497, 500);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(numDni);
            Controls.Add(btnRezerviraj);
            Controls.Add(listBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotelski sistem";
            ((System.ComponentModel.ISupportInitialize)numStarost).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numDni).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIme;
        private TextBox txtPriimek;
        private NumericUpDown numStarost;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbHiska;
        private RadioButton rbLuksuz;
        private RadioButton rbSoba;
        private RadioButton rbSotor;
        private CheckBox chkBazen;
        private CheckBox chkElektrika;
        private ListBox listBox1;
        private Button btnRezerviraj;
        private GroupBox groupBox3;
        private CheckBox chkPokrito;
        private GroupBox groupBox2;
        private CheckBox chkParkirisce;
        private Label label4;
        private NumericUpDown numDni;
    }
}