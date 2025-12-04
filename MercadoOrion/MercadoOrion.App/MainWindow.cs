namespace MercadoOrion;

public partial class MainWindow : Form
{
    public MainWindow()
    {
        InitializeComponent();
        ConfigureGrid();
        ToggleProductActions(false);
    }

    private void ConfigureGrid()
    {
        productsGrid.AutoGenerateColumns = false;
        productsGrid.AllowUserToAddRows = false;
        productsGrid.AllowUserToDeleteRows = false;
        productsGrid.ReadOnly = true;
        productsGrid.MultiSelect = false;
        productsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        productsGrid.RowHeadersVisible = false;

        productsGrid.Columns.Clear();
        productsGrid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "IdColumn",
            HeaderText = "ID",
            Width = 60
        });
        productsGrid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "NameColumn",
            HeaderText = "Produto",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });
        productsGrid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "PriceColumn",
            HeaderText = "Preço (R$)",
            Width = 110,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
        });
        productsGrid.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "QuantityColumn",
            HeaderText = "Qtd.",
            Width = 80,
            DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
        });
    }

    private void ToggleProductActions(bool enabled)
    {
        productsGrid.Enabled = enabled;
        addButton.Enabled = enabled;
        editButton.Enabled = enabled;
        deleteButton.Enabled = enabled;
        reloadButton.Enabled = enabled;
    }

    private void SaveConnection(object sender, EventArgs e)
    {
        if (!int.TryParse(portInput.Text, out var port) || port <= 0)
        {
            MessageBox.Show("Porta inválida.", "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            DatabaseSession.Configure(hostInput.Text.Trim(), port, userInput.Text.Trim(), passwordInput.Text, databaseInput.Text.Trim());
            DatabaseSession.TestConnection();
            connectionStatus.Text = "Conexão ativa";
            connectionStatus.ForeColor = Color.DarkGreen;
            ToggleProductActions(true);
            LoadProducts();
        }
        catch (Exception ex)
        {
            connectionStatus.Text = "Erro de conexão";
            connectionStatus.ForeColor = Color.DarkRed;
            ToggleProductActions(false);
            DatabaseSession.Reset();
            MessageBox.Show($"Não foi possível conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadProducts(object? sender = null, EventArgs? e = null)
    {
        if (!DatabaseSession.HasConnection)
        {
            return;
        }

        try
        {
            var produtos = ProductRepository.GetAll();
            productsGrid.Rows.Clear();
            foreach (var produto in produtos)
            {
                var rowIndex = productsGrid.Rows.Add(produto.Id, produto.Name, produto.Price.ToString("F2"), produto.Quantity);
                productsGrid.Rows[rowIndex].Tag = produto;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao buscar itens: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void AddProduct(object sender, EventArgs e)
    {
        var dialog = new ProductEditorDialog("Adicionar item");
        if (dialog.ShowDialog(this) == DialogResult.OK && dialog.EditedProduct is { } produto)
        {
            try
            {
                var inserted = ProductRepository.Insert(produto.Name, produto.Price, produto.Quantity);
                LoadProducts();
                SelectRow(inserted.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void EditProduct(object sender, EventArgs e)
    {
        var selected = GetSelectedProduct();
        if (selected is null)
        {
            MessageBox.Show("Selecione um item para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var dialog = new ProductEditorDialog("Editar item", selected);
        if (dialog.ShowDialog(this) == DialogResult.OK && dialog.EditedProduct is { } atualizado)
        {
            try
            {
                ProductRepository.Update(atualizado);
                LoadProducts();
                SelectRow(atualizado.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void DeleteProduct(object sender, EventArgs e)
    {
        var selected = GetSelectedProduct();
        if (selected is null)
        {
            MessageBox.Show("Escolha um item para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirm = MessageBox.Show($"Remover '{selected.Name}' do estoque?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (confirm != DialogResult.Yes)
        {
            return;
        }

        try
        {
            ProductRepository.Delete(selected.Id);
            LoadProducts();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao remover: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private ProductRecord? GetSelectedProduct()
    {
        if (productsGrid.SelectedRows.Count == 0)
        {
            return null;
        }

        return productsGrid.SelectedRows[0].Tag as ProductRecord;
    }

    private void SelectRow(int id)
    {
        foreach (DataGridViewRow row in productsGrid.Rows)
        {
            if (row.Cells[0].Value is int rowId && rowId == id)
            {
                row.Selected = true;
                productsGrid.FirstDisplayedScrollingRowIndex = row.Index;
                break;
            }
        }
    }

    private void OpenCashier(object? sender, EventArgs e)
    {
        using var window = new CashierForm();
        window.ShowDialog(this);
    }

    private void OpenCustomers(object? sender, EventArgs e)
    {
        using var window = new CustomersForm();
        window.ShowDialog(this);
    }

    private void OpenReports(object? sender, EventArgs e)
    {
        using var window = new ReportsForm();
        window.ShowDialog(this);
    }

    private void OpenSettings(object? sender, EventArgs e)
    {
        using var window = new SettingsForm();
        window.ShowDialog(this);
    }
}
