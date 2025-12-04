namespace MercadoOrion;

partial class ProductEditorDialog
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
        nameLabel = new Label();
        nameInput = new TextBox();
        priceLabel = new Label();
        priceInput = new NumericUpDown();
        quantityLabel = new Label();
        quantityInput = new NumericUpDown();
        cancelButton = new Button();
        saveButton = new Button();
        ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
        ((System.ComponentModel.ISupportInitialize)quantityInput).BeginInit();
        SuspendLayout();
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.Location = new Point(16, 18);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(100, 20);
        nameLabel.TabIndex = 0;
        nameLabel.Text = "Nome do item";
        // 
        // nameInput
        // 
        nameInput.Location = new Point(16, 41);
        nameInput.Name = "nameInput";
        nameInput.Size = new Size(318, 27);
        nameInput.TabIndex = 1;
        // 
        // priceLabel
        // 
        priceLabel.AutoSize = true;
        priceLabel.Location = new Point(16, 82);
        priceLabel.Name = "priceLabel";
        priceLabel.Size = new Size(73, 20);
        priceLabel.TabIndex = 2;
        priceLabel.Text = "Preço (R$)";
        // 
        // priceInput
        // 
        priceInput.DecimalPlaces = 2;
        priceInput.Location = new Point(16, 105);
        priceInput.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
        priceInput.Name = "priceInput";
        priceInput.Size = new Size(150, 27);
        priceInput.TabIndex = 3;
        priceInput.TextAlign = HorizontalAlignment.Right;
        // 
        // quantityLabel
        // 
        quantityLabel.AutoSize = true;
        quantityLabel.Location = new Point(184, 82);
        quantityLabel.Name = "quantityLabel";
        quantityLabel.Size = new Size(84, 20);
        quantityLabel.TabIndex = 4;
        quantityLabel.Text = "Quantidade";
        // 
        // quantityInput
        // 
        quantityInput.Location = new Point(184, 105);
        quantityInput.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        quantityInput.Name = "quantityInput";
        quantityInput.Size = new Size(150, 27);
        quantityInput.TabIndex = 5;
        quantityInput.TextAlign = HorizontalAlignment.Right;
        // 
        // cancelButton
        // 
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Location = new Point(169, 152);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(94, 30);
        cancelButton.TabIndex = 7;
        cancelButton.Text = "Cancelar";
        cancelButton.UseVisualStyleBackColor = true;
        cancelButton.Click += Cancel;
        // 
        // saveButton
        // 
        saveButton.Location = new Point(270, 152);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(94, 30);
        saveButton.TabIndex = 6;
        saveButton.Text = "Salvar";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += Save;
        // 
        // ProductEditorDialog
        // 
        AcceptButton = saveButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelButton;
        ClientSize = new Size(380, 200);
        Controls.Add(saveButton);
        Controls.Add(cancelButton);
        Controls.Add(quantityInput);
        Controls.Add(quantityLabel);
        Controls.Add(priceInput);
        Controls.Add(priceLabel);
        Controls.Add(nameInput);
        Controls.Add(nameLabel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ProductEditorDialog";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Item";
        ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
        ((System.ComponentModel.ISupportInitialize)quantityInput).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label nameLabel;
    private TextBox nameInput;
    private Label priceLabel;
    private NumericUpDown priceInput;
    private Label quantityLabel;
    private NumericUpDown quantityInput;
    private Button cancelButton;
    private Button saveButton;
}
