namespace Riversand.Desktop;

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
            this.label_SKU = new System.Windows.Forms.Label();
            this.textBox_SKU = new System.Windows.Forms.TextBox();
            this.label_StartDate = new System.Windows.Forms.Label();
            this.label_EndDate = new System.Windows.Forms.Label();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.button_Search = new System.Windows.Forms.Button();
            this.listBox_Output = new System.Windows.Forms.ListBox();
            this.label_WorkDir = new System.Windows.Forms.Label();
            this.timePortionDateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.timePortionDateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_SKU
            // 
            this.label_SKU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_SKU.Location = new System.Drawing.Point(21, 29);
            this.label_SKU.Name = "label_SKU";
            this.label_SKU.Size = new System.Drawing.Size(80, 27);
            this.label_SKU.TabIndex = 0;
            this.label_SKU.Text = "SKU";
            this.label_SKU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_SKU
            // 
            this.textBox_SKU.Location = new System.Drawing.Point(107, 29);
            this.textBox_SKU.Name = "textBox_SKU";
            this.textBox_SKU.Size = new System.Drawing.Size(250, 27);
            this.textBox_SKU.TabIndex = 1;
            // 
            // label_StartDate
            // 
            this.label_StartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_StartDate.Location = new System.Drawing.Point(21, 68);
            this.label_StartDate.Name = "label_StartDate";
            this.label_StartDate.Size = new System.Drawing.Size(80, 27);
            this.label_StartDate.TabIndex = 2;
            this.label_StartDate.Text = "StartDate";
            this.label_StartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_EndDate
            // 
            this.label_EndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_EndDate.Location = new System.Drawing.Point(21, 107);
            this.label_EndDate.Name = "label_EndDate";
            this.label_EndDate.Size = new System.Drawing.Size(80, 27);
            this.label_EndDate.TabIndex = 3;
            this.label_EndDate.Text = "EndDate";
            this.label_EndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(107, 68);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_StartDate.TabIndex = 4;
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(107, 107);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_EndDate.TabIndex = 5;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(694, 127);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(94, 29);
            this.button_Search.TabIndex = 7;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // listBox_Output
            // 
            this.listBox_Output.FormattingEnabled = true;
            this.listBox_Output.ItemHeight = 20;
            this.listBox_Output.Location = new System.Drawing.Point(12, 167);
            this.listBox_Output.Name = "listBox_Output";
            this.listBox_Output.Size = new System.Drawing.Size(776, 264);
            this.listBox_Output.TabIndex = 8;
            // 
            // label_WorkDir
            // 
            this.label_WorkDir.Location = new System.Drawing.Point(12, 438);
            this.label_WorkDir.Name = "label_WorkDir";
            this.label_WorkDir.Size = new System.Drawing.Size(776, 25);
            this.label_WorkDir.TabIndex = 9;
            this.label_WorkDir.Text = "label1";
            this.label_WorkDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timePortionDateTimePicker_StartDate
            // 
            this.timePortionDateTimePicker_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePortionDateTimePicker_StartDate.Location = new System.Drawing.Point(363, 68);
            this.timePortionDateTimePicker_StartDate.Name = "timePortionDateTimePicker_StartDate";
            this.timePortionDateTimePicker_StartDate.ShowUpDown = true;
            this.timePortionDateTimePicker_StartDate.Size = new System.Drawing.Size(85, 27);
            this.timePortionDateTimePicker_StartDate.TabIndex = 10;
            // 
            // timePortionDateTimePicker_EndDate
            // 
            this.timePortionDateTimePicker_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePortionDateTimePicker_EndDate.Location = new System.Drawing.Point(363, 105);
            this.timePortionDateTimePicker_EndDate.Name = "timePortionDateTimePicker_EndDate";
            this.timePortionDateTimePicker_EndDate.ShowUpDown = true;
            this.timePortionDateTimePicker_EndDate.Size = new System.Drawing.Size(85, 27);
            this.timePortionDateTimePicker_EndDate.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.timePortionDateTimePicker_EndDate);
            this.Controls.Add(this.timePortionDateTimePicker_StartDate);
            this.Controls.Add(this.label_WorkDir);
            this.Controls.Add(this.listBox_Output);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.dateTimePicker_EndDate);
            this.Controls.Add(this.dateTimePicker_StartDate);
            this.Controls.Add(this.label_EndDate);
            this.Controls.Add(this.label_StartDate);
            this.Controls.Add(this.textBox_SKU);
            this.Controls.Add(this.label_SKU);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label_SKU;
    private TextBox textBox_SKU;
    private Label label_StartDate;
    private Label label_EndDate;
    private DateTimePicker dateTimePicker_StartDate;
    private DateTimePicker dateTimePicker_EndDate;
    private Button button_Search;
    private ListBox listBox_Output;
    private Label label_WorkDir;
    private DateTimePicker timePortionDateTimePicker_StartDate;
    private DateTimePicker timePortionDateTimePicker_EndDate;
}