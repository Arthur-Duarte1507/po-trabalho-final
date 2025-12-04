namespace MercadoOrion;

public partial class ProductEditorDialog : Form
{
    private readonly int _productId;

    public ProductEditorDialog(string title, ProductRecord? original = null)
    {
        InitializeComponent();
        Text = title;
        _productId = original?.Id ?? 0;
        nameInput.Text = original?.Name ?? string.Empty;
        priceInput.Value = original is null ? 0 : Convert.ToDecimal(original.Price);
        quantityInput.Value = original?.Quantity ?? 0;
    }

    public ProductRecord? EditedProduct { get; private set; }

    private void Save(object? sender, EventArgs e)
    {
        var name = nameInput.Text.Trim();
        if (string.IsNullOrWhiteSpace(name))
        {
            MessageBox.Show("Informe o nome do item.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var price = Convert.ToDouble(priceInput.Value);
        var quantity = Convert.ToInt32(quantityInput.Value);
        EditedProduct = new ProductRecord(_productId, name, price, quantity);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void Cancel(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
