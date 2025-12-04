namespace MercadoOrion;

/// <summary>
/// Tela que representa relatórios gerenciais.
/// </summary>
public class ReportsForm : Form
{
    public ReportsForm()
    {
        Text = "Relatórios";
        Width = 560;
        Height = 380;
        StartPosition = FormStartPosition.CenterParent;

        var info = new Label
        {
            AutoSize = true,
            Text = "Área de relatórios (vendas, estoque, etc.).",
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point),
            Location = new Point(20, 20)
        };

        Controls.Add(info);
    }
}
