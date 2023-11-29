namespace ElectricityBillingApp
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
            panel1 = new Panel();
            exitbtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            calBtn = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            totalTxt = new TextBox();
            unitPriceTxt = new TextBox();
            unitTxt = new TextBox();
            clientNameTxt = new TextBox();
            clientIdTxt = new TextBox();
            deleteBtn = new Button();
            newBtn = new Button();
            addBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LawnGreen;
            panel1.Controls.Add(exitbtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1461, 61);
            panel1.TabIndex = 0;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.DarkGreen;
            exitbtn.Location = new Point(1407, 3);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(51, 55);
            exitbtn.TabIndex = 9;
            exitbtn.Text = " X";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(390, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(490, 13);
            label1.Name = "label1";
            label1.Size = new Size(437, 31);
            label1.TabIndex = 0;
            label1.Text = "Electricity Billing System Software";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(calBtn);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(totalTxt);
            panel2.Controls.Add(unitPriceTxt);
            panel2.Controls.Add(unitTxt);
            panel2.Controls.Add(clientNameTxt);
            panel2.Controls.Add(clientIdTxt);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(newBtn);
            panel2.Controls.Add(addBtn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(11, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(1438, 599);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 547);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 38);
            textBox1.TabIndex = 18;
            // 
            // calBtn
            // 
            calBtn.Location = new Point(452, 471);
            calBtn.Name = "calBtn";
            calBtn.Size = new Size(157, 84);
            calBtn.TabIndex = 17;
            calBtn.Text = "Calculate Total";
            calBtn.UseVisualStyleBackColor = true;
            calBtn.Click += calBtn_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(191, 484);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(216, 38);
            textBox7.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(191, 426);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(216, 38);
            textBox6.TabIndex = 14;
            // 
            // totalTxt
            // 
            totalTxt.Location = new Point(280, 233);
            totalTxt.Name = "totalTxt";
            totalTxt.Size = new Size(216, 38);
            totalTxt.TabIndex = 13;
            // 
            // unitPriceTxt
            // 
            unitPriceTxt.Location = new Point(280, 181);
            unitPriceTxt.Name = "unitPriceTxt";
            unitPriceTxt.Size = new Size(216, 38);
            unitPriceTxt.TabIndex = 12;
            // 
            // unitTxt
            // 
            unitTxt.Location = new Point(280, 121);
            unitTxt.Name = "unitTxt";
            unitTxt.Size = new Size(216, 38);
            unitTxt.TabIndex = 11;
            // 
            // clientNameTxt
            // 
            clientNameTxt.Location = new Point(280, 68);
            clientNameTxt.Name = "clientNameTxt";
            clientNameTxt.Size = new Size(216, 38);
            clientNameTxt.TabIndex = 10;
            // 
            // clientIdTxt
            // 
            clientIdTxt.Location = new Point(280, 19);
            clientIdTxt.Name = "clientIdTxt";
            clientIdTxt.Size = new Size(216, 38);
            clientIdTxt.TabIndex = 9;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(355, 324);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(158, 44);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // newBtn
            // 
            newBtn.Location = new Point(192, 324);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(130, 44);
            newBtn.TabIndex = 7;
            newBtn.Text = "NEW";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(23, 324);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(130, 44);
            addBtn.TabIndex = 6;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 236);
            label6.Name = "label6";
            label6.Size = new Size(79, 31);
            label6.TabIndex = 5;
            label6.Text = "Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 184);
            label5.Name = "label5";
            label5.Size = new Size(146, 31);
            label5.TabIndex = 4;
            label5.Text = "Unit_Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 128);
            label4.Name = "label4";
            label4.Size = new Size(68, 31);
            label4.TabIndex = 3;
            label4.Text = "Unit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 77);
            label3.Name = "label3";
            label3.Size = new Size(172, 31);
            label3.TabIndex = 2;
            label3.Text = "Client_Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 23);
            label2.Name = "label2";
            label2.Size = new Size(136, 31);
            label2.TabIndex = 1;
            label2.Text = "Client_ID";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(525, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(893, 377);
            dataGridView1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 550);
            label7.Name = "label7";
            label7.Size = new Size(79, 31);
            label7.TabIndex = 19;
            label7.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 429);
            label8.Name = "label8";
            label8.Size = new Size(68, 31);
            label8.TabIndex = 20;
            label8.Text = "Unit";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 484);
            label9.Name = "label9";
            label9.Size = new Size(146, 31);
            label9.TabIndex = 21;
            label9.Text = "Unit_Price";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1461, 680);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Elephant", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button exitbtn;
        private Button deleteBtn;
        private Button newBtn;
        private Button addBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Button calBtn;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox totalTxt;
        private TextBox unitPriceTxt;
        private TextBox unitTxt;
        private TextBox clientNameTxt;
        private TextBox clientIdTxt;
        private TextBox textBox1;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}