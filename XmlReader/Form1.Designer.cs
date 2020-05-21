namespace XmlReader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShowSchemaButton = new System.Windows.Forms.Button();
            this.XmlDataSet = new System.Data.DataSet();
            this.DownloadXmlButton = new System.Windows.Forms.Button();
            this.Excel = new System.Windows.Forms.Button();
            this.Word = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XmlDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ShowSchemaButton
            // 
            resources.ApplyResources(this.ShowSchemaButton, "ShowSchemaButton");
            this.ShowSchemaButton.Name = "ShowSchemaButton";
            this.ShowSchemaButton.UseVisualStyleBackColor = true;
            this.ShowSchemaButton.Click += new System.EventHandler(this.ShowSchemaButton_Click);
            // 
            // XmlDataSet
            // 
            this.XmlDataSet.DataSetName = "XmlDataSet";
            // 
            // DownloadXmlButton
            // 
            resources.ApplyResources(this.DownloadXmlButton, "DownloadXmlButton");
            this.DownloadXmlButton.Name = "DownloadXmlButton";
            this.DownloadXmlButton.UseVisualStyleBackColor = true;
            this.DownloadXmlButton.Click += new System.EventHandler(this.DownloadXmlButton_Click);
            // 
            // Excel
            // 
            resources.ApplyResources(this.Excel, "Excel");
            this.Excel.Name = "Excel";
            this.Excel.UseVisualStyleBackColor = true;
            this.Excel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Word
            // 
            resources.ApplyResources(this.Word, "Word");
            this.Word.Name = "Word";
            this.Word.UseVisualStyleBackColor = true;
            this.Word.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.DownloadXmlButton);
            this.Controls.Add(this.ShowSchemaButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XmlDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ShowSchemaButton;
        private System.Data.DataSet XmlDataSet;
        private System.Windows.Forms.Button DownloadXmlButton;
        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.Button Word;
    }
}

