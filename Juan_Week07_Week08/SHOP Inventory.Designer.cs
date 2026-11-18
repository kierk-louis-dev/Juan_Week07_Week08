namespace Juan_Week07_Week08
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
            menuStrip1 = new MenuStrip();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            productListToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            TbDescription = new TextBox();
            tbAmount = new TextBox();
            cbPiece = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inventoryToolStripMenuItem, aboutUsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { homeToolStripMenuItem, productListToolStripMenuItem, exitToolStripMenuItem });
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(69, 20);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(68, 20);
            aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(180, 22);
            homeToolStripMenuItem.Text = "Home";
            // 
            // productListToolStripMenuItem
            // 
            productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            productListToolStripMenuItem.Size = new Size(180, 22);
            productListToolStripMenuItem.Text = "Product List";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbPiece);
            groupBox1.Controls.Add(tbAmount);
            groupBox1.Controls.Add(TbDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(84, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 87);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 19);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 51);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // TbDescription
            // 
            TbDescription.Location = new Point(109, 16);
            TbDescription.Name = "TbDescription";
            TbDescription.Size = new Size(421, 23);
            TbDescription.TabIndex = 2;
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(109, 48);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(168, 23);
            tbAmount.TabIndex = 3;
            // 
            // cbPiece
            // 
            cbPiece.FormattingEnabled = true;
            cbPiece.Location = new Point(283, 48);
            cbPiece.Name = "cbPiece";
            cbPiece.Size = new Size(121, 23);
            cbPiece.TabIndex = 4;
            cbPiece.Text = "Piece";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(652, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(652, 90);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(84, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 291);
            dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Shop Inventory";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem productListToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbPiece;
        private TextBox tbAmount;
        private TextBox TbDescription;
        private Label label2;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}
