namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.resultTxtBox = new System.Windows.Forms.TextBox();
            this.inputTxBox = new System.Windows.Forms.TextBox();
            this.allTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.programGBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.notEqualButton = new System.Windows.Forms.Button();
            this.lessEqualButton = new System.Windows.Forms.Button();
            this.aboveEqualButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.lessButton = new System.Windows.Forms.Button();
            this.aboveButton = new System.Windows.Forms.Button();
            this.matrixButton = new System.Windows.Forms.Button();
            this.rightShiftButton = new System.Windows.Forms.Button();
            this.leftShiftButton = new System.Windows.Forms.Button();
            this.notButton = new System.Windows.Forms.Button();
            this.orButton = new System.Windows.Forms.Button();
            this.andButton = new System.Windows.Forms.Button();
            this.xorButton = new System.Windows.Forms.Button();
            this.falseButton = new System.Windows.Forms.Button();
            this.trueButton = new System.Windows.Forms.Button();
            this.juniorGBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.subButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.MultiButton = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.ACButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.seniorGBox = new System.Windows.Forms.GroupBox();
            this.seniorTLPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tanhButton = new System.Windows.Forms.Button();
            this.coshButton = new System.Windows.Forms.Button();
            this.sinhButton = new System.Windows.Forms.Button();
            this.tanButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.radicalYButton = new System.Windows.Forms.Button();
            this.radical3Button = new System.Windows.Forms.Button();
            this.radicalButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.cubeButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.piButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.allTLPanel.SuspendLayout();
            this.buttonTLPanel.SuspendLayout();
            this.programGBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.juniorGBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.seniorGBox.SuspendLayout();
            this.seniorTLPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTxtBox.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultTxtBox.Location = new System.Drawing.Point(3, 45);
            this.resultTxtBox.Multiline = true;
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.ReadOnly = true;
            this.resultTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultTxtBox.Size = new System.Drawing.Size(808, 79);
            this.resultTxtBox.TabIndex = 1;
            this.resultTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputTxBox
            // 
            this.inputTxBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTxBox.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputTxBox.Location = new System.Drawing.Point(3, 3);
            this.inputTxBox.Multiline = true;
            this.inputTxBox.Name = "inputTxBox";
            this.inputTxBox.Size = new System.Drawing.Size(808, 36);
            this.inputTxBox.TabIndex = 0;
            // 
            // allTLPanel
            // 
            this.allTLPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allTLPanel.ColumnCount = 1;
            this.allTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.allTLPanel.Controls.Add(this.inputTxBox, 0, 0);
            this.allTLPanel.Controls.Add(this.resultTxtBox, 0, 1);
            this.allTLPanel.Controls.Add(this.buttonTLPanel, 0, 2);
            this.allTLPanel.Location = new System.Drawing.Point(12, 12);
            this.allTLPanel.Name = "allTLPanel";
            this.allTLPanel.RowCount = 3;
            this.allTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.allTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.allTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.allTLPanel.Size = new System.Drawing.Size(814, 426);
            this.allTLPanel.TabIndex = 0;
            // 
            // buttonTLPanel
            // 
            this.buttonTLPanel.ColumnCount = 3;
            this.buttonTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.buttonTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.buttonTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.buttonTLPanel.Controls.Add(this.programGBox, 2, 0);
            this.buttonTLPanel.Controls.Add(this.juniorGBox, 1, 0);
            this.buttonTLPanel.Controls.Add(this.seniorGBox, 0, 0);
            this.buttonTLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTLPanel.Location = new System.Drawing.Point(3, 130);
            this.buttonTLPanel.Name = "buttonTLPanel";
            this.buttonTLPanel.RowCount = 1;
            this.buttonTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonTLPanel.Size = new System.Drawing.Size(808, 293);
            this.buttonTLPanel.TabIndex = 2;
            // 
            // programGBox
            // 
            this.programGBox.Controls.Add(this.tableLayoutPanel1);
            this.programGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programGBox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.programGBox.Location = new System.Drawing.Point(555, 3);
            this.programGBox.Name = "programGBox";
            this.programGBox.Size = new System.Drawing.Size(250, 287);
            this.programGBox.TabIndex = 2;
            this.programGBox.TabStop = false;
            this.programGBox.Text = "程序";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.notEqualButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lessEqualButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.aboveEqualButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.equalButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lessButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.aboveButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.matrixButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.rightShiftButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.leftShiftButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.notButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.orButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.andButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.xorButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.falseButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trueButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 258);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // notEqualButton
            // 
            this.notEqualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notEqualButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.notEqualButton.Location = new System.Drawing.Point(165, 207);
            this.notEqualButton.Name = "notEqualButton";
            this.notEqualButton.Size = new System.Drawing.Size(76, 48);
            this.notEqualButton.TabIndex = 51;
            this.notEqualButton.Text = "!=";
            this.notEqualButton.UseVisualStyleBackColor = true;
            this.notEqualButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // lessEqualButton
            // 
            this.lessEqualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lessEqualButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lessEqualButton.Location = new System.Drawing.Point(84, 207);
            this.lessEqualButton.Name = "lessEqualButton";
            this.lessEqualButton.Size = new System.Drawing.Size(75, 48);
            this.lessEqualButton.TabIndex = 50;
            this.lessEqualButton.Text = "<=";
            this.lessEqualButton.UseVisualStyleBackColor = true;
            this.lessEqualButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // aboveEqualButton
            // 
            this.aboveEqualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboveEqualButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aboveEqualButton.Location = new System.Drawing.Point(3, 207);
            this.aboveEqualButton.Name = "aboveEqualButton";
            this.aboveEqualButton.Size = new System.Drawing.Size(75, 48);
            this.aboveEqualButton.TabIndex = 49;
            this.aboveEqualButton.Text = ">=";
            this.aboveEqualButton.UseVisualStyleBackColor = true;
            this.aboveEqualButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // equalButton
            // 
            this.equalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equalButton.Location = new System.Drawing.Point(165, 156);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(76, 45);
            this.equalButton.TabIndex = 48;
            this.equalButton.Text = "==";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // lessButton
            // 
            this.lessButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lessButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lessButton.Location = new System.Drawing.Point(84, 156);
            this.lessButton.Name = "lessButton";
            this.lessButton.Size = new System.Drawing.Size(75, 45);
            this.lessButton.TabIndex = 47;
            this.lessButton.Text = "<";
            this.lessButton.UseVisualStyleBackColor = true;
            this.lessButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // aboveButton
            // 
            this.aboveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboveButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aboveButton.Location = new System.Drawing.Point(3, 156);
            this.aboveButton.Name = "aboveButton";
            this.aboveButton.Size = new System.Drawing.Size(75, 45);
            this.aboveButton.TabIndex = 46;
            this.aboveButton.Text = ">";
            this.aboveButton.UseVisualStyleBackColor = true;
            this.aboveButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // matrixButton
            // 
            this.matrixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matrixButton.Location = new System.Drawing.Point(165, 105);
            this.matrixButton.Name = "matrixButton";
            this.matrixButton.Size = new System.Drawing.Size(76, 45);
            this.matrixButton.TabIndex = 45;
            this.matrixButton.Text = "矩阵";
            this.matrixButton.UseVisualStyleBackColor = true;
            this.matrixButton.Click += new System.EventHandler(this.matrixButton_Click);
            // 
            // rightShiftButton
            // 
            this.rightShiftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightShiftButton.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rightShiftButton.Location = new System.Drawing.Point(84, 105);
            this.rightShiftButton.Name = "rightShiftButton";
            this.rightShiftButton.Size = new System.Drawing.Size(75, 45);
            this.rightShiftButton.TabIndex = 44;
            this.rightShiftButton.Text = "→";
            this.rightShiftButton.UseVisualStyleBackColor = true;
            this.rightShiftButton.Click += new System.EventHandler(this.rightShiftButton_Click);
            // 
            // leftShiftButton
            // 
            this.leftShiftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftShiftButton.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftShiftButton.Location = new System.Drawing.Point(3, 105);
            this.leftShiftButton.Name = "leftShiftButton";
            this.leftShiftButton.Size = new System.Drawing.Size(75, 45);
            this.leftShiftButton.TabIndex = 43;
            this.leftShiftButton.Text = "←";
            this.leftShiftButton.UseVisualStyleBackColor = true;
            this.leftShiftButton.Click += new System.EventHandler(this.leftShiftButton_Click);
            // 
            // notButton
            // 
            this.notButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.notButton.Location = new System.Drawing.Point(165, 54);
            this.notButton.Name = "notButton";
            this.notButton.Size = new System.Drawing.Size(76, 45);
            this.notButton.TabIndex = 42;
            this.notButton.Text = "NOT";
            this.notButton.UseVisualStyleBackColor = true;
            this.notButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // orButton
            // 
            this.orButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.orButton.Location = new System.Drawing.Point(84, 54);
            this.orButton.Name = "orButton";
            this.orButton.Size = new System.Drawing.Size(75, 45);
            this.orButton.TabIndex = 41;
            this.orButton.Text = "OR";
            this.orButton.UseVisualStyleBackColor = true;
            this.orButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // andButton
            // 
            this.andButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.andButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.andButton.Location = new System.Drawing.Point(3, 54);
            this.andButton.Name = "andButton";
            this.andButton.Size = new System.Drawing.Size(75, 45);
            this.andButton.TabIndex = 40;
            this.andButton.Text = "AND";
            this.andButton.UseVisualStyleBackColor = true;
            this.andButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // xorButton
            // 
            this.xorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xorButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xorButton.Location = new System.Drawing.Point(165, 3);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(76, 45);
            this.xorButton.TabIndex = 39;
            this.xorButton.Text = "XOR";
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // falseButton
            // 
            this.falseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.falseButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.falseButton.Location = new System.Drawing.Point(84, 3);
            this.falseButton.Name = "falseButton";
            this.falseButton.Size = new System.Drawing.Size(75, 45);
            this.falseButton.TabIndex = 38;
            this.falseButton.Text = "False";
            this.falseButton.UseVisualStyleBackColor = true;
            this.falseButton.Click += new System.EventHandler(this.falseButton_Click);
            // 
            // trueButton
            // 
            this.trueButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trueButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trueButton.Location = new System.Drawing.Point(3, 3);
            this.trueButton.Name = "trueButton";
            this.trueButton.Size = new System.Drawing.Size(75, 45);
            this.trueButton.TabIndex = 37;
            this.trueButton.Text = "True";
            this.trueButton.UseVisualStyleBackColor = true;
            this.trueButton.Click += new System.EventHandler(this.trueButton_Click);
            // 
            // juniorGBox
            // 
            this.juniorGBox.Controls.Add(this.tableLayoutPanel2);
            this.juniorGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.juniorGBox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.juniorGBox.Location = new System.Drawing.Point(258, 3);
            this.juniorGBox.Name = "juniorGBox";
            this.juniorGBox.Size = new System.Drawing.Size(291, 287);
            this.juniorGBox.TabIndex = 1;
            this.juniorGBox.TabStop = false;
            this.juniorGBox.Text = "初级";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.subButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.MultiButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.percentButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ACButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.returnButton, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pointButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.addButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button0, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.eButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.divButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.delButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 258);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // subButton
            // 
            this.subButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.subButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subButton.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.subButton.Location = new System.Drawing.Point(216, 105);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(66, 45);
            this.subButton.TabIndex = 28;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = false;
            this.subButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(74, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 45);
            this.button5.TabIndex = 26;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.dight_Click);
            // 
            // MultiButton
            // 
            this.MultiButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MultiButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiButton.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MultiButton.Location = new System.Drawing.Point(216, 54);
            this.MultiButton.Name = "MultiButton";
            this.MultiButton.Size = new System.Drawing.Size(66, 45);
            this.MultiButton.TabIndex = 24;
            this.MultiButton.Text = "*";
            this.MultiButton.UseVisualStyleBackColor = false;
            this.MultiButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.Location = new System.Drawing.Point(74, 54);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 45);
            this.button8.TabIndex = 22;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.dight_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(74, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 45);
            this.button2.TabIndex = 30;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.dight_Click);
            // 
            // percentButton
            // 
            this.percentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.percentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percentButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.percentButton.Location = new System.Drawing.Point(145, 3);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(65, 45);
            this.percentButton.TabIndex = 19;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = false;
            this.percentButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // ACButton
            // 
            this.ACButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ACButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ACButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ACButton.Location = new System.Drawing.Point(3, 3);
            this.ACButton.Name = "ACButton";
            this.ACButton.Size = new System.Drawing.Size(65, 45);
            this.ACButton.TabIndex = 17;
            this.ACButton.Text = "AC";
            this.ACButton.UseVisualStyleBackColor = false;
            this.ACButton.Click += new System.EventHandler(this.ACButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Red;
            this.returnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnButton.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.returnButton.Location = new System.Drawing.Point(216, 207);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(66, 48);
            this.returnButton.TabIndex = 36;
            this.returnButton.Text = "=";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(145, 105);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 45);
            this.button6.TabIndex = 27;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.dight_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(145, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 45);
            this.button3.TabIndex = 31;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.dight_Click);
            // 
            // pointButton
            // 
            this.pointButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointButton.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pointButton.Location = new System.Drawing.Point(145, 207);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(65, 48);
            this.pointButton.TabIndex = 35;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.dight_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addButton.Location = new System.Drawing.Point(216, 156);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(66, 45);
            this.addButton.TabIndex = 32;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button0.Location = new System.Drawing.Point(74, 207);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(65, 48);
            this.button0.TabIndex = 34;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.dight_Click);
            // 
            // eButton
            // 
            this.eButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eButton.Location = new System.Drawing.Point(3, 207);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(65, 48);
            this.eButton.TabIndex = 33;
            this.eButton.Text = "e";
            this.eButton.UseVisualStyleBackColor = true;
            this.eButton.Click += new System.EventHandler(this.eButton_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(3, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 45);
            this.button4.TabIndex = 25;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.dight_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.divButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.divButton.Location = new System.Drawing.Point(216, 3);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(66, 45);
            this.divButton.TabIndex = 20;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(3, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 45);
            this.button1.TabIndex = 29;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.dight_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(3, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 45);
            this.button7.TabIndex = 21;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.dight_Click);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.delButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delButton.Location = new System.Drawing.Point(74, 3);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(65, 45);
            this.delButton.TabIndex = 18;
            this.delButton.Text = "DEL";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.Location = new System.Drawing.Point(145, 54);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 45);
            this.button9.TabIndex = 23;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.dight_Click);
            // 
            // seniorGBox
            // 
            this.seniorGBox.Controls.Add(this.seniorTLPanel);
            this.seniorGBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seniorGBox.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.seniorGBox.Location = new System.Drawing.Point(3, 3);
            this.seniorGBox.Name = "seniorGBox";
            this.seniorGBox.Size = new System.Drawing.Size(249, 287);
            this.seniorGBox.TabIndex = 0;
            this.seniorGBox.TabStop = false;
            this.seniorGBox.Text = "高级";
            // 
            // seniorTLPanel
            // 
            this.seniorTLPanel.ColumnCount = 3;
            this.seniorTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.seniorTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.seniorTLPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.seniorTLPanel.Controls.Add(this.tanhButton, 2, 4);
            this.seniorTLPanel.Controls.Add(this.coshButton, 1, 4);
            this.seniorTLPanel.Controls.Add(this.sinhButton, 0, 4);
            this.seniorTLPanel.Controls.Add(this.tanButton, 2, 3);
            this.seniorTLPanel.Controls.Add(this.cosButton, 1, 3);
            this.seniorTLPanel.Controls.Add(this.sinButton, 0, 3);
            this.seniorTLPanel.Controls.Add(this.radicalYButton, 2, 2);
            this.seniorTLPanel.Controls.Add(this.radical3Button, 1, 2);
            this.seniorTLPanel.Controls.Add(this.radicalButton, 0, 2);
            this.seniorTLPanel.Controls.Add(this.powerButton, 2, 1);
            this.seniorTLPanel.Controls.Add(this.cubeButton, 1, 1);
            this.seniorTLPanel.Controls.Add(this.squareButton, 0, 1);
            this.seniorTLPanel.Controls.Add(this.piButton, 2, 0);
            this.seniorTLPanel.Controls.Add(this.rightButton, 1, 0);
            this.seniorTLPanel.Controls.Add(this.leftButton, 0, 0);
            this.seniorTLPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seniorTLPanel.Location = new System.Drawing.Point(3, 26);
            this.seniorTLPanel.Name = "seniorTLPanel";
            this.seniorTLPanel.RowCount = 5;
            this.seniorTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.seniorTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.seniorTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.seniorTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.seniorTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.seniorTLPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.seniorTLPanel.Size = new System.Drawing.Size(243, 258);
            this.seniorTLPanel.TabIndex = 0;
            // 
            // tanhButton
            // 
            this.tanhButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanhButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tanhButton.Location = new System.Drawing.Point(165, 207);
            this.tanhButton.Name = "tanhButton";
            this.tanhButton.Size = new System.Drawing.Size(75, 48);
            this.tanhButton.TabIndex = 16;
            this.tanhButton.Text = "Tanh";
            this.tanhButton.UseVisualStyleBackColor = true;
            this.tanhButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // coshButton
            // 
            this.coshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coshButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coshButton.Location = new System.Drawing.Point(84, 207);
            this.coshButton.Name = "coshButton";
            this.coshButton.Size = new System.Drawing.Size(75, 48);
            this.coshButton.TabIndex = 15;
            this.coshButton.Text = "Cosh";
            this.coshButton.UseVisualStyleBackColor = true;
            this.coshButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // sinhButton
            // 
            this.sinhButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinhButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sinhButton.Location = new System.Drawing.Point(3, 207);
            this.sinhButton.Name = "sinhButton";
            this.sinhButton.Size = new System.Drawing.Size(75, 48);
            this.sinhButton.TabIndex = 14;
            this.sinhButton.Text = "Sinh";
            this.sinhButton.UseVisualStyleBackColor = true;
            this.sinhButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // tanButton
            // 
            this.tanButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tanButton.Location = new System.Drawing.Point(165, 156);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(75, 45);
            this.tanButton.TabIndex = 13;
            this.tanButton.Text = "Tan";
            this.tanButton.UseVisualStyleBackColor = true;
            this.tanButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // cosButton
            // 
            this.cosButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cosButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cosButton.Location = new System.Drawing.Point(84, 156);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(75, 45);
            this.cosButton.TabIndex = 12;
            this.cosButton.Text = "Cos";
            this.cosButton.UseVisualStyleBackColor = true;
            this.cosButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // sinButton
            // 
            this.sinButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sinButton.Location = new System.Drawing.Point(3, 156);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(75, 45);
            this.sinButton.TabIndex = 11;
            this.sinButton.Text = "Sin";
            this.sinButton.UseVisualStyleBackColor = true;
            this.sinButton.Click += new System.EventHandler(this.operator_Click);
            // 
            // radicalYButton
            // 
            this.radicalYButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radicalYButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radicalYButton.Location = new System.Drawing.Point(165, 105);
            this.radicalYButton.Name = "radicalYButton";
            this.radicalYButton.Size = new System.Drawing.Size(75, 45);
            this.radicalYButton.TabIndex = 10;
            this.radicalYButton.Text = "Y√X";
            this.radicalYButton.UseVisualStyleBackColor = true;
            this.radicalYButton.Click += new System.EventHandler(this.radicalYButton_Click);
            // 
            // radical3Button
            // 
            this.radical3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radical3Button.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radical3Button.Location = new System.Drawing.Point(84, 105);
            this.radical3Button.Name = "radical3Button";
            this.radical3Button.Size = new System.Drawing.Size(75, 45);
            this.radical3Button.TabIndex = 9;
            this.radical3Button.Text = "3√X";
            this.radical3Button.UseVisualStyleBackColor = true;
            this.radical3Button.Click += new System.EventHandler(this.radical3Button_Click);
            // 
            // radicalButton
            // 
            this.radicalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radicalButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radicalButton.Location = new System.Drawing.Point(3, 105);
            this.radicalButton.Name = "radicalButton";
            this.radicalButton.Size = new System.Drawing.Size(75, 45);
            this.radicalButton.TabIndex = 8;
            this.radicalButton.Text = "2√X";
            this.radicalButton.UseVisualStyleBackColor = true;
            this.radicalButton.Click += new System.EventHandler(this.radicalButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powerButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.powerButton.Location = new System.Drawing.Point(165, 54);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(75, 45);
            this.powerButton.TabIndex = 7;
            this.powerButton.Text = "X^Y";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // cubeButton
            // 
            this.cubeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cubeButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cubeButton.Location = new System.Drawing.Point(84, 54);
            this.cubeButton.Name = "cubeButton";
            this.cubeButton.Size = new System.Drawing.Size(75, 45);
            this.cubeButton.TabIndex = 6;
            this.cubeButton.Text = "X^3";
            this.cubeButton.UseVisualStyleBackColor = true;
            this.cubeButton.Click += new System.EventHandler(this.cubeButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squareButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.squareButton.Location = new System.Drawing.Point(3, 54);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(75, 45);
            this.squareButton.TabIndex = 5;
            this.squareButton.Text = "X^2";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // piButton
            // 
            this.piButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.piButton.Location = new System.Drawing.Point(165, 3);
            this.piButton.Name = "piButton";
            this.piButton.Size = new System.Drawing.Size(75, 45);
            this.piButton.TabIndex = 4;
            this.piButton.Text = "π";
            this.piButton.UseVisualStyleBackColor = true;
            this.piButton.Click += new System.EventHandler(this.piButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rightButton.Location = new System.Drawing.Point(84, 3);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 45);
            this.rightButton.TabIndex = 3;
            this.rightButton.Tag = ")";
            this.rightButton.Text = ")";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftButton.Location = new System.Drawing.Point(3, 3);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 45);
            this.leftButton.TabIndex = 2;
            this.leftButton.Tag = "(";
            this.leftButton.Text = "(";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.allTLPanel);
            this.MinimumSize = new System.Drawing.Size(860, 500);
            this.Name = "MainForm";
            this.Text = "科学计算器";
            this.allTLPanel.ResumeLayout(false);
            this.allTLPanel.PerformLayout();
            this.buttonTLPanel.ResumeLayout(false);
            this.programGBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.juniorGBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.seniorGBox.ResumeLayout(false);
            this.seniorTLPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox resultTxtBox;
        private System.Windows.Forms.TextBox inputTxBox;
        private System.Windows.Forms.TableLayoutPanel allTLPanel;
        private System.Windows.Forms.TableLayoutPanel buttonTLPanel;
        private System.Windows.Forms.GroupBox programGBox;
        private System.Windows.Forms.GroupBox juniorGBox;
        private System.Windows.Forms.GroupBox seniorGBox;
        private System.Windows.Forms.TableLayoutPanel seniorTLPanel;
        private System.Windows.Forms.Button tanhButton;
        private System.Windows.Forms.Button coshButton;
        private System.Windows.Forms.Button sinhButton;
        private System.Windows.Forms.Button tanButton;
        private System.Windows.Forms.Button cosButton;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button radicalYButton;
        private System.Windows.Forms.Button radical3Button;
        private System.Windows.Forms.Button radicalButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button cubeButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button piButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button notEqualButton;
        private System.Windows.Forms.Button lessEqualButton;
        private System.Windows.Forms.Button aboveEqualButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button lessButton;
        private System.Windows.Forms.Button aboveButton;
        private System.Windows.Forms.Button matrixButton;
        private System.Windows.Forms.Button rightShiftButton;
        private System.Windows.Forms.Button leftShiftButton;
        private System.Windows.Forms.Button notButton;
        private System.Windows.Forms.Button orButton;
        private System.Windows.Forms.Button andButton;
        private System.Windows.Forms.Button xorButton;
        private System.Windows.Forms.Button falseButton;
        private System.Windows.Forms.Button trueButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button MultiButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button ACButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button button9;
    }
}

