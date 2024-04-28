namespace conversionChange
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button0 = new Button();
            buttonDel = new Button();
            buttonPoint = new Button();
            montant = new TextBox();
            buttonEuro = new Button();
            buttonDCAN = new Button();
            buttonDUS = new Button();
            unit = new Label();
            tauxActu = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(12, 105);
            button1.Name = "button1";
            button1.Size = new Size(97, 77);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Location = new Point(129, 105);
            button2.Name = "button2";
            button2.Size = new Size(97, 77);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Location = new Point(244, 105);
            button3.Name = "button3";
            button3.Size = new Size(97, 77);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLight;
            button6.Location = new Point(244, 188);
            button6.Name = "button6";
            button6.Size = new Size(97, 77);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Location = new Point(129, 188);
            button5.Name = "button5";
            button5.Size = new Size(97, 77);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Location = new Point(12, 188);
            button4.Name = "button4";
            button4.Size = new Size(97, 77);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLight;
            button9.Location = new Point(244, 271);
            button9.Name = "button9";
            button9.Size = new Size(97, 77);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlLight;
            button8.Location = new Point(129, 271);
            button8.Name = "button8";
            button8.Size = new Size(97, 77);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLight;
            button7.Location = new Point(12, 271);
            button7.Name = "button7";
            button7.Size = new Size(97, 77);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ControlLight;
            button0.Location = new Point(244, 354);
            button0.Name = "button0";
            button0.Size = new Size(97, 77);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackColor = SystemColors.ControlLight;
            buttonDel.Location = new Point(129, 354);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(97, 77);
            buttonDel.TabIndex = 10;
            buttonDel.Text = "Del";
            buttonDel.UseVisualStyleBackColor = false;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonPoint
            // 
            buttonPoint.BackColor = SystemColors.ControlLight;
            buttonPoint.Location = new Point(12, 354);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(97, 77);
            buttonPoint.TabIndex = 9;
            buttonPoint.Text = ",";
            buttonPoint.UseVisualStyleBackColor = false;
            buttonPoint.Click += button_Click;
            // 
            // montant
            // 
            montant.Font = new Font("Segoe UI", 20F);
            montant.Location = new Point(12, 36);
            montant.Name = "montant";
            montant.Size = new Size(266, 43);
            montant.TabIndex = 12;
            montant.Text = "0";
            montant.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonEuro
            // 
            buttonEuro.BackColor = SystemColors.ControlLight;
            buttonEuro.Location = new Point(244, 457);
            buttonEuro.Name = "buttonEuro";
            buttonEuro.Size = new Size(97, 43);
            buttonEuro.TabIndex = 15;
            buttonEuro.Text = "Euro";
            buttonEuro.UseVisualStyleBackColor = false;
            buttonEuro.Click += buttonEuro_Click;
            // 
            // buttonDCAN
            // 
            buttonDCAN.BackColor = SystemColors.ControlLight;
            buttonDCAN.Location = new Point(129, 457);
            buttonDCAN.Name = "buttonDCAN";
            buttonDCAN.Size = new Size(97, 43);
            buttonDCAN.TabIndex = 14;
            buttonDCAN.Text = "Dollars CAN";
            buttonDCAN.UseVisualStyleBackColor = false;
            buttonDCAN.Click += buttonDCAN_Click;
            // 
            // buttonDUS
            // 
            buttonDUS.BackColor = SystemColors.ControlLight;
            buttonDUS.Location = new Point(12, 457);
            buttonDUS.Name = "buttonDUS";
            buttonDUS.Size = new Size(97, 43);
            buttonDUS.TabIndex = 13;
            buttonDUS.Text = "Dollars US";
            buttonDUS.UseVisualStyleBackColor = false;
            buttonDUS.Click += buttonDUS_Click;
            // 
            // unit
            // 
            unit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unit.ImageAlign = ContentAlignment.MiddleLeft;
            unit.Location = new Point(284, 36);
            unit.Name = "unit";
            unit.Size = new Size(57, 43);
            unit.TabIndex = 16;
            unit.Text = "EUR";
            unit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tauxActu
            // 
            tauxActu.AutoSize = true;
            tauxActu.Location = new Point(12, 9);
            tauxActu.Name = "tauxActu";
            tauxActu.Size = new Size(109, 15);
            tauxActu.TabIndex = 17;
            tauxActu.Text = "Taux non actualisés";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(358, 504);
            Controls.Add(tauxActu);
            Controls.Add(unit);
            Controls.Add(buttonEuro);
            Controls.Add(buttonDCAN);
            Controls.Add(buttonDUS);
            Controls.Add(montant);
            Controls.Add(button0);
            Controls.Add(buttonDel);
            Controls.Add(buttonPoint);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Conversion de Taux de Change";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button0;
        private Button buttonDel;
        private Button buttonPoint;
        private TextBox montant;
        private Button buttonEuro;
        private Button buttonDCAN;
        private Button buttonDUS;
        private Label label1;
        private Label unit;
        private Label tauxActu;
    }
}
