namespace MercadoOrion;

/// <summary>
/// Tela para cadastros ou visualização de clientes.
/// </summary>
public class CustomersForm : Form
{
    public CustomersForm()
    {
        Text = "Clientes";
        Width = 520;
        Height = 360;
        StartPosition = FormStartPosition.CenterParent;

        var info = new Label
        {
            AutoSize = true,
            Text = "Tela de clientes. Espaço reservado para cadastro e consulta.",
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point),
            Location = new Point(20, 20)
        };

        Controls.Add(info);
    }
}
