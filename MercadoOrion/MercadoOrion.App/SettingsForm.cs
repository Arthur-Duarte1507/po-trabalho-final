namespace MercadoOrion;

/// <summary>
/// Tela de configurações gerais do sistema.
/// </summary>
public class SettingsForm : Form
{
    public SettingsForm()
    {
        Text = "Configurações";
        Width = 480;
        Height = 340;
        StartPosition = FormStartPosition.CenterParent;

        var info = new Label
        {
            AutoSize = true,
            Text = "Configurações gerais do sistema (tema, impressora, etc.).",
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point),
            Location = new Point(20, 20)
        };

        Controls.Add(info);
    }
}
