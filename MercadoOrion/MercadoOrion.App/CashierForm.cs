namespace MercadoOrion;

/// <summary>
/// Tela simulando um caixa aberto.
/// </summary>
public class CashierForm : Form
{
    public CashierForm()
    {
        Text = "Caixa - Operação";
        Width = 600;
        Height = 400;
        StartPosition = FormStartPosition.CenterParent;

        var info = new Label
        {
            AutoSize = true,
            Text = "Caixa em operação. Aqui ficaria o fluxo de vendas.",
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point),
            Location = new Point(20, 20)
        };

        Controls.Add(info);
    }
}
