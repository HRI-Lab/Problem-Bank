﻿namespace Es12_05_04
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 16);
            this.numericUpDown1.Maximum = new System.Decimal(new int[] {
                                                                           10000,
                                                                           0,
                                                                           0,
                                                                           0});
            this.numericUpDown1.Minimum = new System.Decimal(new int[] {
                                                                           1,
                                                                           0,
                                                                           0,
                                                                           0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 21);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new System.Decimal(new int[] {
                                                                         2007,
                                                                         0,
                                                                         0,
                                                                         0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.date_Changed);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
                                                           "1",
                                                           "2",
                                                           "3",
                                                           "4",
                                                           "5",
                                                           "6",
                                                           "7",
                                                           "8",
                                                           "9",
                                                           "10",
                                                           "11",
                                                           "12"});
            this.comboBox1.Location = new System.Drawing.Point(144, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.date_Changed);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Es12_05_04:Calendar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

