namespace Hi_Tech_Order_Management_System.GUI
{
    partial class CustomerForm
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.credit = new System.Windows.Forms.TextBox();
            this.fax = new System.Windows.Forms.TextBox();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.postal = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.hitechDBDataSet = new Hi_Tech_Order_Management_System.HitechDBDataSet();
            this.hitechDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hitechDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hitechDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitechDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitechDBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox8.Controls.Add(this.comboBox2);
            this.groupBox8.Controls.Add(this.textBox12);
            this.groupBox8.Controls.Add(this.SearchButton);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Location = new System.Drawing.Point(1478, 781);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox8.Size = new System.Drawing.Size(774, 424);
            this.groupBox8.TabIndex = 28;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Search Customer";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Select the search Option",
            "Employee ID",
            "First Name",
            "Last Name",
            "Job Title"});
            this.comboBox2.Location = new System.Drawing.Point(206, 60);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(366, 39);
            this.comboBox2.TabIndex = 14;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(206, 178);
            this.textBox12.Margin = new System.Windows.Forms.Padding(6);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(366, 38);
            this.textBox12.TabIndex = 8;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(272, 271);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(200, 97);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(212, 120);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 32);
            this.label18.TabIndex = 17;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox9.Controls.Add(this.dataGridView);
            this.groupBox9.Controls.Add(this.button11);
            this.groupBox9.Location = new System.Drawing.Point(115, 595);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox9.Size = new System.Drawing.Size(1176, 700);
            this.groupBox9.TabIndex = 30;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "List Of Customers";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DataSource = this.hitechDBDataSetBindingSource1;
            this.dataGridView.Location = new System.Drawing.Point(71, 261);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1050, 331);
            this.dataGridView.TabIndex = 17;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(105, 94);
            this.button11.Margin = new System.Windows.Forms.Padding(6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(400, 58);
            this.button11.TabIndex = 15;
            this.button11.Text = "List Of Customers";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.UpdateBtn);
            this.groupBox7.Controls.Add(this.DeleteBtn);
            this.groupBox7.Controls.Add(this.button8);
            this.groupBox7.Controls.Add(this.credit);
            this.groupBox7.Controls.Add(this.fax);
            this.groupBox7.Controls.Add(this.phoneno);
            this.groupBox7.Controls.Add(this.postal);
            this.groupBox7.Controls.Add(this.city);
            this.groupBox7.Controls.Add(this.street);
            this.groupBox7.Controls.Add(this.name);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(153, 58);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox7.Size = new System.Drawing.Size(2110, 484);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Customer Information";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(1440, 329);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(200, 97);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(884, 329);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(200, 97);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(368, 329);
            this.button8.Margin = new System.Windows.Forms.Padding(6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 97);
            this.button8.TabIndex = 14;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // credit
            // 
            this.credit.Location = new System.Drawing.Point(1386, 234);
            this.credit.Margin = new System.Windows.Forms.Padding(6);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(368, 38);
            this.credit.TabIndex = 13;
            // 
            // fax
            // 
            this.fax.Location = new System.Drawing.Point(756, 234);
            this.fax.Margin = new System.Windows.Forms.Padding(6);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(498, 38);
            this.fax.TabIndex = 12;
            // 
            // phoneno
            // 
            this.phoneno.Location = new System.Drawing.Point(172, 234);
            this.phoneno.Margin = new System.Windows.Forms.Padding(6);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(392, 38);
            this.phoneno.TabIndex = 11;
            // 
            // postal
            // 
            this.postal.Location = new System.Drawing.Point(1542, 89);
            this.postal.Margin = new System.Windows.Forms.Padding(6);
            this.postal.Name = "postal";
            this.postal.Size = new System.Drawing.Size(474, 38);
            this.postal.TabIndex = 10;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(1010, 89);
            this.city.Margin = new System.Windows.Forms.Padding(6);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(416, 38);
            this.city.TabIndex = 9;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(426, 89);
            this.street.Margin = new System.Windows.Forms.Padding(6);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(470, 38);
            this.street.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 89);
            this.name.Margin = new System.Windows.Forms.Padding(6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(306, 38);
            this.name.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1490, 196);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 32);
            this.label17.TabIndex = 6;
            this.label17.Text = "Credit Limit";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(908, 196);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 32);
            this.label16.TabIndex = 5;
            this.label16.Text = "Fax Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(266, 196);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 32);
            this.label15.TabIndex = 4;
            this.label15.Text = "Phone Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1702, 50);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 32);
            this.label14.TabIndex = 3;
            this.label14.Text = "Postal Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1196, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 32);
            this.label13.TabIndex = 2;
            this.label13.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(610, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "Street";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Name";
            // 
            // hitechDBDataSet
            // 
            this.hitechDBDataSet.DataSetName = "HitechDBDataSet";
            this.hitechDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hitechDBDataSetBindingSource
            // 
            this.hitechDBDataSetBindingSource.DataSource = this.hitechDBDataSet;
            this.hitechDBDataSetBindingSource.Position = 0;
            // 
            // hitechDBDataSetBindingSource1
            // 
            this.hitechDBDataSetBindingSource1.DataSource = this.hitechDBDataSet;
            this.hitechDBDataSetBindingSource1.Position = 0;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(2469, 1331);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hitechDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitechDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hitechDBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox credit;
        private System.Windows.Forms.TextBox fax;
        private System.Windows.Forms.TextBox phoneno;
        private System.Windows.Forms.TextBox postal;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource hitechDBDataSetBindingSource;
        private HitechDBDataSet hitechDBDataSet;
        private System.Windows.Forms.BindingSource hitechDBDataSetBindingSource1;
    }
}