namespace Test1
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
            components = new System.ComponentModel.Container();
            lstPackages = new ListBox();
            label1 = new Label();
            lblShippingCost = new Label();
            label2 = new Label();
            txtTrackingNumber = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtRecipient = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtPostalCode = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtShipDate = new TextBox();
            txtDeliveryDate = new TextBox();
            txtWeight = new TextBox();
            cboCarrier = new ComboBox();
            grpShippingMode = new GroupBox();
            radOvernight = new RadioButton();
            radExpress = new RadioButton();
            radStandard = new RadioButton();
            label14 = new Label();
            chkFragile = new CheckBox();
            btnAdd = new Button();
            btnCalculate = new Button();
            btnExit = new Button();
            epValidate = new ErrorProvider(components);
            grpShippingMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epValidate).BeginInit();
            SuspendLayout();
            // 
            // lstPackages
            // 
            lstPackages.FormattingEnabled = true;
            lstPackages.Location = new Point(35, 79);
            lstPackages.Name = "lstPackages";
            lstPackages.Size = new Size(215, 264);
            lstPackages.TabIndex = 1;
            lstPackages.SelectedIndexChanged += lstPackages_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Packages";
            // 
            // lblShippingCost
            // 
            lblShippingCost.AutoSize = true;
            lblShippingCost.Location = new Point(35, 392);
            lblShippingCost.Name = "lblShippingCost";
            lblShippingCost.Size = new Size(104, 20);
            lblShippingCost.TabIndex = 2;
            lblShippingCost.Text = "Shipping Cost:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 80);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Tracking #";
            // 
            // txtTrackingNumber
            // 
            txtTrackingNumber.Location = new Point(416, 76);
            txtTrackingNumber.Name = "txtTrackingNumber";
            txtTrackingNumber.Size = new Size(193, 27);
            txtTrackingNumber.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 115);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Recipient";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 150);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 185);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 7;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 220);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 8;
            label6.Text = "State";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(320, 255);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 9;
            label7.Text = "Postal Code";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(320, 290);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 10;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(320, 325);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 11;
            label9.Text = "Phone";
            // 
            // txtRecipient
            // 
            txtRecipient.Location = new Point(416, 112);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(193, 27);
            txtRecipient.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(416, 147);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(292, 27);
            txtAddress.TabIndex = 4;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(416, 182);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(193, 27);
            txtCity.TabIndex = 5;
            // 
            // txtState
            // 
            txtState.Location = new Point(416, 217);
            txtState.Name = "txtState";
            txtState.Size = new Size(162, 27);
            txtState.TabIndex = 6;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(416, 252);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(162, 27);
            txtPostalCode.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(416, 287);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(292, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(416, 322);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(193, 27);
            txtPhone.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(800, 80);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 19;
            label10.Text = "Ship Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(800, 115);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 20;
            label11.Text = "Delivery Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(800, 150);
            label12.Name = "label12";
            label12.Size = new Size(92, 20);
            label12.TabIndex = 21;
            label12.Text = "Weight (lbs.)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(800, 185);
            label13.Name = "label13";
            label13.Size = new Size(53, 20);
            label13.TabIndex = 22;
            label13.Text = "Carrier";
            // 
            // txtShipDate
            // 
            txtShipDate.Location = new Point(910, 76);
            txtShipDate.Name = "txtShipDate";
            txtShipDate.Size = new Size(162, 27);
            txtShipDate.TabIndex = 10;
            // 
            // txtDeliveryDate
            // 
            txtDeliveryDate.Location = new Point(910, 112);
            txtDeliveryDate.Name = "txtDeliveryDate";
            txtDeliveryDate.Size = new Size(162, 27);
            txtDeliveryDate.TabIndex = 11;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(910, 147);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(162, 27);
            txtWeight.TabIndex = 12;
            // 
            // cboCarrier
            // 
            cboCarrier.FormattingEnabled = true;
            cboCarrier.Items.AddRange(new object[] { "FedEx", "USPS", "UPS" });
            cboCarrier.Location = new Point(910, 182);
            cboCarrier.Name = "cboCarrier";
            cboCarrier.Size = new Size(162, 28);
            cboCarrier.TabIndex = 13;
            // 
            // grpShippingMode
            // 
            grpShippingMode.Controls.Add(radOvernight);
            grpShippingMode.Controls.Add(radExpress);
            grpShippingMode.Controls.Add(radStandard);
            grpShippingMode.Location = new Point(800, 234);
            grpShippingMode.Name = "grpShippingMode";
            grpShippingMode.Size = new Size(250, 125);
            grpShippingMode.TabIndex = 14;
            grpShippingMode.TabStop = false;
            grpShippingMode.Text = "Shipping Mode";
            // 
            // radOvernight
            // 
            radOvernight.AutoSize = true;
            radOvernight.Location = new Point(25, 91);
            radOvernight.Name = "radOvernight";
            radOvernight.Size = new Size(95, 24);
            radOvernight.TabIndex = 2;
            radOvernight.TabStop = true;
            radOvernight.Text = "Overnight";
            radOvernight.UseVisualStyleBackColor = true;
            // 
            // radExpress
            // 
            radExpress.AutoSize = true;
            radExpress.Location = new Point(25, 58);
            radExpress.Name = "radExpress";
            radExpress.Size = new Size(79, 24);
            radExpress.TabIndex = 1;
            radExpress.TabStop = true;
            radExpress.Text = "Express";
            radExpress.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            radStandard.AutoSize = true;
            radStandard.Location = new Point(25, 26);
            radStandard.Name = "radStandard";
            radStandard.Size = new Size(90, 24);
            radStandard.TabIndex = 0;
            radStandard.TabStop = true;
            radStandard.Text = "Standard";
            radStandard.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(800, 381);
            label14.Name = "label14";
            label14.Size = new Size(54, 20);
            label14.TabIndex = 28;
            label14.Text = "Fragile";
            // 
            // chkFragile
            // 
            chkFragile.AutoSize = true;
            chkFragile.Location = new Point(874, 384);
            chkFragile.Name = "chkFragile";
            chkFragile.Size = new Size(18, 17);
            chkFragile.TabIndex = 15;
            chkFragile.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(320, 429);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add Package";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(474, 429);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(194, 29);
            btnCalculate.TabIndex = 17;
            btnCalculate.Text = "Calculate Shipping Cost";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(708, 429);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 29);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // epValidate
            // 
            epValidate.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            epValidate.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 484);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(btnAdd);
            Controls.Add(chkFragile);
            Controls.Add(label14);
            Controls.Add(grpShippingMode);
            Controls.Add(cboCarrier);
            Controls.Add(txtWeight);
            Controls.Add(txtDeliveryDate);
            Controls.Add(txtShipDate);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtPostalCode);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtRecipient);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTrackingNumber);
            Controls.Add(label2);
            Controls.Add(lblShippingCost);
            Controls.Add(label1);
            Controls.Add(lstPackages);
            Name = "Form1";
            Text = "Shipping Tracker";
            grpShippingMode.ResumeLayout(false);
            grpShippingMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epValidate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPackages;
        private Label label1;
        private Label lblShippingCost;
        private Label label2;
        private TextBox txtTrackingNumber;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtRecipient;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtPostalCode;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtShipDate;
        private TextBox txtDeliveryDate;
        private TextBox txtWeight;
        private ComboBox cboCarrier;
        private GroupBox grpShippingMode;
        private RadioButton radOvernight;
        private RadioButton radExpress;
        private RadioButton radStandard;
        private Label label14;
        private CheckBox chkFragile;
        private Button btnAdd;
        private Button btnCalculate;
        private Button btnExit;
        private ErrorProvider epValidate;
    }
}
