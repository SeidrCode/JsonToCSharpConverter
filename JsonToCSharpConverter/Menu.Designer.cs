namespace JsonToCSharp;

partial class Menu
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
        JsonTextBox = new TextBox();
        CSharpTextBox = new TextBox();
        label1 = new Label();
        label2 = new Label();
        TransformButton = new Button();
        ClearButton = new Button();
        FromFileButton = new Button();
        openFileDialog1 = new OpenFileDialog();
        SaveButton = new Button();
        SuspendLayout();
        // 
        // JsonTextBox
        // 
        JsonTextBox.BorderStyle = BorderStyle.FixedSingle;
        JsonTextBox.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        JsonTextBox.Location = new Point(42, 59);
        JsonTextBox.MaxLength = 999999;
        JsonTextBox.Multiline = true;
        JsonTextBox.Name = "JsonTextBox";
        JsonTextBox.Size = new Size(640, 679);
        JsonTextBox.TabIndex = 0;
        // 
        // CSharpTextBox
        // 
        CSharpTextBox.BorderStyle = BorderStyle.FixedSingle;
        CSharpTextBox.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        CSharpTextBox.Location = new Point(688, 59);
        CSharpTextBox.MaxLength = 999999;
        CSharpTextBox.Multiline = true;
        CSharpTextBox.Name = "CSharpTextBox";
        CSharpTextBox.Size = new Size(640, 679);
        CSharpTextBox.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label1.Location = new Point(307, 23);
        label1.Name = "label1";
        label1.Size = new Size(79, 28);
        label1.TabIndex = 2;
        label1.Text = "JSON";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label2.Location = new Point(980, 23);
        label2.Name = "label2";
        label2.Size = new Size(42, 28);
        label2.TabIndex = 3;
        label2.Text = "C#";
        // 
        // TransformButton
        // 
        TransformButton.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        TransformButton.Location = new Point(541, 752);
        TransformButton.Name = "TransformButton";
        TransformButton.Size = new Size(141, 40);
        TransformButton.TabIndex = 4;
        TransformButton.Text = "Transform";
        TransformButton.UseVisualStyleBackColor = true;
        TransformButton.Click += TransformButton_Click;
        // 
        // ClearButton
        // 
        ClearButton.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        ClearButton.Location = new Point(835, 752);
        ClearButton.Name = "ClearButton";
        ClearButton.Size = new Size(141, 40);
        ClearButton.TabIndex = 5;
        ClearButton.Text = "Clear";
        ClearButton.UseVisualStyleBackColor = true;
        ClearButton.Click += ClearButton_Click;
        // 
        // FromFileButton
        // 
        FromFileButton.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        FromFileButton.Location = new Point(394, 752);
        FromFileButton.Name = "FromFileButton";
        FromFileButton.Size = new Size(141, 40);
        FromFileButton.TabIndex = 6;
        FromFileButton.Text = "From File";
        FromFileButton.UseVisualStyleBackColor = true;
        FromFileButton.Click += FromFileButton_Click;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // SaveButton
        // 
        SaveButton.Font = new Font("Century", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        SaveButton.Location = new Point(688, 752);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(141, 40);
        SaveButton.TabIndex = 8;
        SaveButton.Text = "Save";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // Menu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Linen;
        ClientSize = new Size(1353, 804);
        Controls.Add(SaveButton);
        Controls.Add(FromFileButton);
        Controls.Add(ClearButton);
        Controls.Add(TransformButton);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(CSharpTextBox);
        Controls.Add(JsonTextBox);
        Name = "Menu";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Menu";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox JsonTextBox;
    private TextBox CSharpTextBox;
    private Label label1;
    private Label label2;
    private Button TransformButton;
    private Button ClearButton;
    private Button FromFileButton;
    private OpenFileDialog openFileDialog1;
    private Button SaveButton;
}