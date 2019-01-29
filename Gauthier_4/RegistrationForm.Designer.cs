namespace Gauthier_4
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.registrationDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registrantInfromationGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.registrantStatusComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfBirthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registrationInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.registrationFeeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pricePerClassLabel = new System.Windows.Forms.Label();
            this.classesSelectedLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.classTypeListBox = new System.Windows.Forms.ListBox();
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.liveActionRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.checkRadioButton = new System.Windows.Forms.RadioButton();
            this.receiptRequestCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registrantInfromationGroupBox.SuspendLayout();
            this.registrationInformationGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hopkins Film School";
            // 
            // registrationDateMaskedTextBox
            // 
            this.registrationDateMaskedTextBox.Location = new System.Drawing.Point(259, 337);
            this.registrationDateMaskedTextBox.Mask = "00/00/0000";
            this.registrationDateMaskedTextBox.Name = "registrationDateMaskedTextBox";
            this.registrationDateMaskedTextBox.Size = new System.Drawing.Size(93, 26);
            this.registrationDateMaskedTextBox.TabIndex = 1;
            this.registrationDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.registrationDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registration Date:";
            // 
            // registrantInfromationGroupBox
            // 
            this.registrantInfromationGroupBox.Controls.Add(this.label7);
            this.registrantInfromationGroupBox.Controls.Add(this.registrantStatusComboBox);
            this.registrantInfromationGroupBox.Controls.Add(this.dateOfBirthMaskedTextBox);
            this.registrantInfromationGroupBox.Controls.Add(this.emailMaskedTextBox);
            this.registrantInfromationGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrantInfromationGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrantInfromationGroupBox.Controls.Add(this.label6);
            this.registrantInfromationGroupBox.Controls.Add(this.label5);
            this.registrantInfromationGroupBox.Controls.Add(this.label4);
            this.registrantInfromationGroupBox.Controls.Add(this.label3);
            this.registrantInfromationGroupBox.Location = new System.Drawing.Point(26, 367);
            this.registrantInfromationGroupBox.Name = "registrantInfromationGroupBox";
            this.registrantInfromationGroupBox.Size = new System.Drawing.Size(483, 242);
            this.registrantInfromationGroupBox.TabIndex = 2;
            this.registrantInfromationGroupBox.TabStop = false;
            this.registrantInfromationGroupBox.Text = "Registrant Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Registrant Status:";
            // 
            // registrantStatusComboBox
            // 
            this.registrantStatusComboBox.FormattingEnabled = true;
            this.registrantStatusComboBox.Location = new System.Drawing.Point(150, 167);
            this.registrantStatusComboBox.Name = "registrantStatusComboBox";
            this.registrantStatusComboBox.Size = new System.Drawing.Size(285, 28);
            this.registrantStatusComboBox.TabIndex = 4;
            // 
            // dateOfBirthMaskedTextBox
            // 
            this.dateOfBirthMaskedTextBox.Location = new System.Drawing.Point(116, 130);
            this.dateOfBirthMaskedTextBox.Mask = "00/00/0000";
            this.dateOfBirthMaskedTextBox.Name = "dateOfBirthMaskedTextBox";
            this.dateOfBirthMaskedTextBox.Size = new System.Drawing.Size(101, 26);
            this.dateOfBirthMaskedTextBox.TabIndex = 3;
            this.dateOfBirthMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dateOfBirthMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // emailMaskedTextBox
            // 
            this.emailMaskedTextBox.Location = new System.Drawing.Point(131, 87);
            this.emailMaskedTextBox.Name = "emailMaskedTextBox";
            this.emailMaskedTextBox.Size = new System.Drawing.Size(303, 26);
            this.emailMaskedTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(322, 43);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(112, 26);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(105, 43);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(112, 26);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Date Of Birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name:";
            // 
            // registrationInformationGroupBox
            // 
            this.registrationInformationGroupBox.Controls.Add(this.label12);
            this.registrationInformationGroupBox.Controls.Add(this.registrationFeeLabel);
            this.registrationInformationGroupBox.Controls.Add(this.label11);
            this.registrationInformationGroupBox.Controls.Add(this.pricePerClassLabel);
            this.registrationInformationGroupBox.Controls.Add(this.classesSelectedLabel);
            this.registrationInformationGroupBox.Controls.Add(this.label10);
            this.registrationInformationGroupBox.Controls.Add(this.label9);
            this.registrationInformationGroupBox.Controls.Add(this.classTypeListBox);
            this.registrationInformationGroupBox.Controls.Add(this.animationRadioButton);
            this.registrationInformationGroupBox.Controls.Add(this.liveActionRadioButton);
            this.registrationInformationGroupBox.Controls.Add(this.label8);
            this.registrationInformationGroupBox.Location = new System.Drawing.Point(26, 617);
            this.registrationInformationGroupBox.Name = "registrationInformationGroupBox";
            this.registrationInformationGroupBox.Size = new System.Drawing.Size(495, 320);
            this.registrationInformationGroupBox.TabIndex = 3;
            this.registrationInformationGroupBox.TabStop = false;
            this.registrationInformationGroupBox.Text = "Registration Information";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Total Price:";
            // 
            // registrationFeeLabel
            // 
            this.registrationFeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationFeeLabel.Location = new System.Drawing.Point(153, 282);
            this.registrationFeeLabel.Name = "registrationFeeLabel";
            this.registrationFeeLabel.Size = new System.Drawing.Size(89, 22);
            this.registrationFeeLabel.TabIndex = 9;
            this.registrationFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Price Per Class:";
            // 
            // pricePerClassLabel
            // 
            this.pricePerClassLabel.Location = new System.Drawing.Point(379, 70);
            this.pricePerClassLabel.Name = "pricePerClassLabel";
            this.pricePerClassLabel.Size = new System.Drawing.Size(107, 31);
            this.pricePerClassLabel.TabIndex = 7;
            this.pricePerClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // classesSelectedLabel
            // 
            this.classesSelectedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classesSelectedLabel.Location = new System.Drawing.Point(153, 251);
            this.classesSelectedLabel.Name = "classesSelectedLabel";
            this.classesSelectedLabel.Size = new System.Drawing.Size(33, 27);
            this.classesSelectedLabel.TabIndex = 6;
            this.classesSelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Classes Selected:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(13, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Please Select No More Than 4 Classes";
            // 
            // classTypeListBox
            // 
            this.classTypeListBox.FormattingEnabled = true;
            this.classTypeListBox.ItemHeight = 20;
            this.classTypeListBox.Location = new System.Drawing.Point(13, 49);
            this.classTypeListBox.Name = "classTypeListBox";
            this.classTypeListBox.Size = new System.Drawing.Size(352, 144);
            this.classTypeListBox.TabIndex = 2;
            this.classTypeListBox.SelectedIndexChanged += new System.EventHandler(this.classTypeListBox_SelectedIndexChanged);
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Location = new System.Drawing.Point(270, 22);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(105, 24);
            this.animationRadioButton.TabIndex = 1;
            this.animationRadioButton.Text = "Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            this.animationRadioButton.CheckedChanged += new System.EventHandler(this.animationRadioButton_CheckedChanged);
            // 
            // liveActionRadioButton
            // 
            this.liveActionRadioButton.AutoSize = true;
            this.liveActionRadioButton.Location = new System.Drawing.Point(153, 22);
            this.liveActionRadioButton.Name = "liveActionRadioButton";
            this.liveActionRadioButton.Size = new System.Drawing.Size(111, 24);
            this.liveActionRadioButton.TabIndex = 0;
            this.liveActionRadioButton.Text = "Live Action";
            this.liveActionRadioButton.UseVisualStyleBackColor = true;
            this.liveActionRadioButton.CheckedChanged += new System.EventHandler(this.liveActionRadioButton_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Classes Available:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 948);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Specify Payment Type:";
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(249, 947);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(71, 24);
            this.cashRadioButton.TabIndex = 4;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkRadioButton
            // 
            this.checkRadioButton.AutoSize = true;
            this.checkRadioButton.Location = new System.Drawing.Point(324, 947);
            this.checkRadioButton.Name = "checkRadioButton";
            this.checkRadioButton.Size = new System.Drawing.Size(79, 24);
            this.checkRadioButton.TabIndex = 5;
            this.checkRadioButton.TabStop = true;
            this.checkRadioButton.Text = "Check";
            this.checkRadioButton.UseVisualStyleBackColor = true;
            // 
            // receiptRequestCheckBox
            // 
            this.receiptRequestCheckBox.AutoSize = true;
            this.receiptRequestCheckBox.Location = new System.Drawing.Point(138, 987);
            this.receiptRequestCheckBox.Name = "receiptRequestCheckBox";
            this.receiptRequestCheckBox.Size = new System.Drawing.Size(216, 24);
            this.receiptRequestCheckBox.TabIndex = 6;
            this.receiptRequestCheckBox.Text = "Email Receipt Requested";
            this.receiptRequestCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(532, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gauthier_4.Properties.Resources.FilmSchool;
            this.pictureBox1.Location = new System.Drawing.Point(52, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 232);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 1018);
            this.Controls.Add(this.receiptRequestCheckBox);
            this.Controls.Add(this.checkRadioButton);
            this.Controls.Add(this.cashRadioButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.registrationInformationGroupBox);
            this.Controls.Add(this.registrantInfromationGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registrationDateMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hopkins Film School";
            this.Load += new System.EventHandler(this.HopkinsFilmSchool_Load);
            this.registrantInfromationGroupBox.ResumeLayout(false);
            this.registrantInfromationGroupBox.PerformLayout();
            this.registrationInformationGroupBox.ResumeLayout(false);
            this.registrationInformationGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox registrationDateMaskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox registrantInfromationGroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox registrantStatusComboBox;
        private System.Windows.Forms.MaskedTextBox dateOfBirthMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox emailMaskedTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox registrationInformationGroupBox;
        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.RadioButton liveActionRadioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox classTypeListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label classesSelectedLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label pricePerClassLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label registrationFeeLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton checkRadioButton;
        private System.Windows.Forms.CheckBox receiptRequestCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolTip toolTip1;
    }
}

