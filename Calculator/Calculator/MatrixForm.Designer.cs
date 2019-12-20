namespace Calculator
{
    partial class MatrixForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MatrixATextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            this.matrixBTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.matrixAddBtn = new System.Windows.Forms.Button();
            this.matrixMinusBtn = new System.Windows.Forms.Button();
            this.matrixMultiBtn = new System.Windows.Forms.Button();
            this.matrixDivBtn = new System.Windows.Forms.Button();
            this.matrixDotMultiBtn = new System.Windows.Forms.Button();
            this.matrixDotDivBtn = new System.Windows.Forms.Button();
            this.matrixDotPowerBtn = new System.Windows.Forms.Button();
            this.matrixTransBtn = new System.Windows.Forms.Button();
            this.matrixPowerBtn = new System.Windows.Forms.Button();
            this.matrixInvBtn = new System.Windows.Forms.Button();
            this.matrixDetBtn = new System.Windows.Forms.Button();
            this.matrixAdjBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MatrixATextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.matrixBTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.resultTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MatrixATextBox
            // 
            this.MatrixATextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatrixATextBox.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MatrixATextBox.Location = new System.Drawing.Point(3, 52);
            this.MatrixATextBox.Multiline = true;
            this.MatrixATextBox.Name = "MatrixATextBox";
            this.MatrixATextBox.Size = new System.Drawing.Size(394, 193);
            this.MatrixATextBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.tipTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 43);
            this.panel1.TabIndex = 3;
            // 
            // tipTextBox
            // 
            this.tipTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipTextBox.Location = new System.Drawing.Point(0, 0);
            this.tipTextBox.Multiline = true;
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.ReadOnly = true;
            this.tipTextBox.Size = new System.Drawing.Size(794, 43);
            this.tipTextBox.TabIndex = 0;
            this.tipTextBox.Text = "在第一个文本区输入矩阵A, 在第二个文本区输入矩阵B.每列数据用英文分号隔开, 每行用换行隔开.";
            // 
            // matrixBTextBox
            // 
            this.matrixBTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixBTextBox.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixBTextBox.Location = new System.Drawing.Point(403, 52);
            this.matrixBTextBox.Multiline = true;
            this.matrixBTextBox.Name = "matrixBTextBox";
            this.matrixBTextBox.Size = new System.Drawing.Size(394, 193);
            this.matrixBTextBox.TabIndex = 4;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTextBox.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultTextBox.Location = new System.Drawing.Point(3, 251);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(394, 196);
            this.resultTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.matrixAdjBtn, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.matrixDetBtn, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.matrixInvBtn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.matrixPowerBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.matrixTransBtn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.matrixDotPowerBtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.matrixDotDivBtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.matrixDotMultiBtn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.matrixDivBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.matrixMultiBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.matrixMinusBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.matrixAddBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(403, 251);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 196);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // matrixAddBtn
            // 
            this.matrixAddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixAddBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixAddBtn.Location = new System.Drawing.Point(3, 3);
            this.matrixAddBtn.Name = "matrixAddBtn";
            this.matrixAddBtn.Size = new System.Drawing.Size(92, 59);
            this.matrixAddBtn.TabIndex = 0;
            this.matrixAddBtn.Text = "A+B";
            this.matrixAddBtn.UseVisualStyleBackColor = true;
            // 
            // matrixMinusBtn
            // 
            this.matrixMinusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixMinusBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixMinusBtn.Location = new System.Drawing.Point(101, 3);
            this.matrixMinusBtn.Name = "matrixMinusBtn";
            this.matrixMinusBtn.Size = new System.Drawing.Size(92, 59);
            this.matrixMinusBtn.TabIndex = 1;
            this.matrixMinusBtn.Text = "A-B";
            this.matrixMinusBtn.UseVisualStyleBackColor = true;
            // 
            // matrixMultiBtn
            // 
            this.matrixMultiBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixMultiBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixMultiBtn.Location = new System.Drawing.Point(199, 3);
            this.matrixMultiBtn.Name = "matrixMultiBtn";
            this.matrixMultiBtn.Size = new System.Drawing.Size(92, 59);
            this.matrixMultiBtn.TabIndex = 2;
            this.matrixMultiBtn.Text = "A*B";
            this.matrixMultiBtn.UseVisualStyleBackColor = true;
            // 
            // matrixDivBtn
            // 
            this.matrixDivBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixDivBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixDivBtn.Location = new System.Drawing.Point(297, 3);
            this.matrixDivBtn.Name = "matrixDivBtn";
            this.matrixDivBtn.Size = new System.Drawing.Size(94, 59);
            this.matrixDivBtn.TabIndex = 3;
            this.matrixDivBtn.Text = "A/B";
            this.matrixDivBtn.UseVisualStyleBackColor = true;
            // 
            // matrixDotMultiBtn
            // 
            this.matrixDotMultiBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixDotMultiBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixDotMultiBtn.Location = new System.Drawing.Point(101, 68);
            this.matrixDotMultiBtn.Name = "matrixDotMultiBtn";
            this.matrixDotMultiBtn.Size = new System.Drawing.Size(92, 59);
            this.matrixDotMultiBtn.TabIndex = 5;
            this.matrixDotMultiBtn.Text = "A.*B";
            this.matrixDotMultiBtn.UseVisualStyleBackColor = true;
            // 
            // matrixDotDivBtn
            // 
            this.matrixDotDivBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixDotDivBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixDotDivBtn.Location = new System.Drawing.Point(199, 68);
            this.matrixDotDivBtn.Name = "matrixDotDivBtn";
            this.matrixDotDivBtn.Size = new System.Drawing.Size(92, 59);
            this.matrixDotDivBtn.TabIndex = 6;
            this.matrixDotDivBtn.Text = "A./B";
            this.matrixDotDivBtn.UseVisualStyleBackColor = true;
            // 
            // matrixDotPowerBtn
            // 
            this.matrixDotPowerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixDotPowerBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixDotPowerBtn.Location = new System.Drawing.Point(297, 68);
            this.matrixDotPowerBtn.Name = "matrixDotPowerBtn";
            this.matrixDotPowerBtn.Size = new System.Drawing.Size(94, 59);
            this.matrixDotPowerBtn.TabIndex = 7;
            this.matrixDotPowerBtn.Text = "A.^b";
            this.matrixDotPowerBtn.UseVisualStyleBackColor = true;
            // 
            // matrixTransBtn
            // 
            this.matrixTransBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixTransBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixTransBtn.Location = new System.Drawing.Point(3, 133);
            this.matrixTransBtn.Name = "matrixTransBtn";
            this.matrixTransBtn.Size = new System.Drawing.Size(92, 60);
            this.matrixTransBtn.TabIndex = 8;
            this.matrixTransBtn.Text = "A.\'";
            this.matrixTransBtn.UseVisualStyleBackColor = true;
            // 
            // matrixPowerBtn
            // 
            this.matrixPowerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixPowerBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixPowerBtn.Location = new System.Drawing.Point(3, 68);
            this.matrixPowerBtn.Name = "matrixPowerBtn";
            this.matrixPowerBtn.Size = new System.Drawing.Size(92, 59);
            this.matrixPowerBtn.TabIndex = 4;
            this.matrixPowerBtn.Text = "A^b";
            this.matrixPowerBtn.UseVisualStyleBackColor = true;
            // 
            // matrixInvBtn
            // 
            this.matrixInvBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixInvBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixInvBtn.Location = new System.Drawing.Point(101, 133);
            this.matrixInvBtn.Name = "matrixInvBtn";
            this.matrixInvBtn.Size = new System.Drawing.Size(92, 60);
            this.matrixInvBtn.TabIndex = 9;
            this.matrixInvBtn.Text = "A^-1";
            this.matrixInvBtn.UseVisualStyleBackColor = true;
            // 
            // matrixDetBtn
            // 
            this.matrixDetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixDetBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixDetBtn.Location = new System.Drawing.Point(199, 133);
            this.matrixDetBtn.Name = "matrixDetBtn";
            this.matrixDetBtn.Size = new System.Drawing.Size(92, 60);
            this.matrixDetBtn.TabIndex = 10;
            this.matrixDetBtn.Text = "|A|";
            this.matrixDetBtn.UseVisualStyleBackColor = true;
            // 
            // matrixAdjBtn
            // 
            this.matrixAdjBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixAdjBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixAdjBtn.Location = new System.Drawing.Point(297, 133);
            this.matrixAdjBtn.Name = "matrixAdjBtn";
            this.matrixAdjBtn.Size = new System.Drawing.Size(94, 60);
            this.matrixAdjBtn.TabIndex = 11;
            this.matrixAdjBtn.Text = "A*";
            this.matrixAdjBtn.UseVisualStyleBackColor = true;
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "MatrixForm";
            this.Text = "矩阵运算";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox MatrixATextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tipTextBox;
        private System.Windows.Forms.TextBox matrixBTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button matrixAdjBtn;
        private System.Windows.Forms.Button matrixDetBtn;
        private System.Windows.Forms.Button matrixInvBtn;
        private System.Windows.Forms.Button matrixPowerBtn;
        private System.Windows.Forms.Button matrixTransBtn;
        private System.Windows.Forms.Button matrixDotPowerBtn;
        private System.Windows.Forms.Button matrixDotDivBtn;
        private System.Windows.Forms.Button matrixDotMultiBtn;
        private System.Windows.Forms.Button matrixDivBtn;
        private System.Windows.Forms.Button matrixMultiBtn;
        private System.Windows.Forms.Button matrixMinusBtn;
        private System.Windows.Forms.Button matrixAddBtn;
    }
}