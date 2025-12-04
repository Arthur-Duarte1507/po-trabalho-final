namespace MercadoOrion;

partial class MainWindow
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
        mainMenu = new MenuStrip();
        cashierMenuItem = new ToolStripMenuItem();
        customersMenuItem = new ToolStripMenuItem();
        reportsMenuItem = new ToolStripMenuItem();
        settingsMenuItem = new ToolStripMenuItem();
        headerPanel = new Panel();
        headerTitle = new Label();
        connectionGroup = new GroupBox();
        connectionStatus = new Label();
        databaseInput = new TextBox();
        databaseLabel = new Label();
        passwordInput = new TextBox();
        passwordLabel = new Label();
        userInput = new TextBox();
        userLabel = new Label();
        portInput = new TextBox();
        portLabel = new Label();
        hostInput = new TextBox();
        hostLabel = new Label();
        saveConnectionButton = new Button();
        gridTitle = new Label();
        productsGrid = new DataGridView();
        reloadButton = new Button();
        addButton = new Button();
        editButton = new Button();
        deleteButton = new Button();
        mainMenu.SuspendLayout();
        headerPanel.SuspendLayout();
        connectionGroup.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
        SuspendLayout();
        // 
        // mainMenu
        // 
        mainMenu.ImageScalingSize = new Size(20, 20);
        mainMenu.Items.AddRange(new ToolStripItem[] { cashierMenuItem, customersMenuItem, reportsMenuItem, settingsMenuItem });
        mainMenu.Location = new Point(0, 0);
        mainMenu.Name = "mainMenu";
        mainMenu.Size = new Size(982, 28);
        mainMenu.TabIndex = 0;
        mainMenu.Text = "menuStrip1";
        // 
        // cashierMenuItem
        // 
        cashierMenuItem.Name = "cashierMenuItem";
        cashierMenuItem.Size = new Size(62, 24);
        cashierMenuItem.Text = "Caixa";
        cashierMenuItem.Click += OpenCashier;
        // 
        // customersMenuItem
        // 
        customersMenuItem.Name = "customersMenuItem";
        customersMenuItem.Size = new Size(80, 24);
        customersMenuItem.Text = "Clientes";
        customersMenuItem.Click += OpenCustomers;
        // 
        // reportsMenuItem
        // 
        reportsMenuItem.Name = "reportsMenuItem";
        reportsMenuItem.Size = new Size(94, 24);
        reportsMenuItem.Text = "Relatórios";
        reportsMenuItem.Click += OpenReports;
        // 
        // settingsMenuItem
        // 
        settingsMenuItem.Name = "settingsMenuItem";
        settingsMenuItem.Size = new Size(120, 24);
        settingsMenuItem.Text = "Configurações";
        settingsMenuItem.Click += OpenSettings;
        // 
        // headerPanel
        // 
        headerPanel.BackColor = Color.FromArgb(27, 38, 59);
        headerPanel.Controls.Add(headerTitle);
        headerPanel.Dock = DockStyle.Top;
        headerPanel.Location = new Point(0, 28);
        headerPanel.Name = "headerPanel";
        headerPanel.Size = new Size(982, 72);
        headerPanel.TabIndex = 0;
        // 
        // headerTitle
        // 
        headerTitle.AutoSize = true;
        headerTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        headerTitle.ForeColor = Color.White;
        headerTitle.Location = new Point(20, 18);
        headerTitle.Name = "headerTitle";
        headerTitle.Size = new Size(243, 37);
        headerTitle.TabIndex = 0;
        headerTitle.Text = "Painel do Mercado";
        // 
        // connectionGroup
        // 
        connectionGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        connectionGroup.Controls.Add(connectionStatus);
        connectionGroup.Controls.Add(databaseInput);
        connectionGroup.Controls.Add(databaseLabel);
        connectionGroup.Controls.Add(passwordInput);
        connectionGroup.Controls.Add(passwordLabel);
        connectionGroup.Controls.Add(userInput);
        connectionGroup.Controls.Add(userLabel);
        connectionGroup.Controls.Add(portInput);
        connectionGroup.Controls.Add(portLabel);
        connectionGroup.Controls.Add(hostInput);
        connectionGroup.Controls.Add(hostLabel);
        connectionGroup.Controls.Add(saveConnectionButton);
        connectionGroup.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        connectionGroup.Location = new Point(20, 112);
        connectionGroup.Name = "connectionGroup";
        connectionGroup.Size = new Size(942, 164);
        connectionGroup.TabIndex = 1;
        connectionGroup.TabStop = false;
        connectionGroup.Text = "Conexão com PostgreSQL";
        // 
        // connectionStatus
        // 
        connectionStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        connectionStatus.AutoSize = true;
        connectionStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        connectionStatus.ForeColor = Color.FromArgb(94, 97, 110);
        connectionStatus.Location = new Point(716, 113);
        connectionStatus.Name = "connectionStatus";
        connectionStatus.Size = new Size(161, 20);
        connectionStatus.TabIndex = 11;
        connectionStatus.Text = "Conexão não definida";
        // 
        // databaseInput
        // 
        databaseInput.Location = new Point(92, 118);
        databaseInput.Name = "databaseInput";
        databaseInput.Size = new Size(200, 30);
        databaseInput.TabIndex = 5;
        // 
        // databaseLabel
        // 
        databaseLabel.AutoSize = true;
        databaseLabel.Location = new Point(16, 121);
        databaseLabel.Name = "databaseLabel";
        databaseLabel.Size = new Size(70, 23);
        databaseLabel.TabIndex = 10;
        databaseLabel.Text = "Banco*";
        // 
        // passwordInput
        // 
        passwordInput.Location = new Point(378, 72);
        passwordInput.Name = "passwordInput";
        passwordInput.PasswordChar = '●';
        passwordInput.Size = new Size(180, 30);
        passwordInput.TabIndex = 4;
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Location = new Point(304, 75);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new Size(68, 23);
        passwordLabel.TabIndex = 8;
        passwordLabel.Text = "Senha*";
        // 
        // userInput
        // 
        userInput.Location = new Point(92, 72);
        userInput.Name = "userInput";
        userInput.PlaceholderText = "postgres";
        userInput.Text = "postgres";
        userInput.Size = new Size(200, 30);
        userInput.TabIndex = 3;
        // 
        // userLabel
        // 
        userLabel.AutoSize = true;
        userLabel.Location = new Point(16, 75);
        userLabel.Name = "userLabel";
        userLabel.Size = new Size(70, 23);
        userLabel.TabIndex = 6;
        userLabel.Text = "Usuário";
        // 
        // portInput
        // 
        portInput.Location = new Point(378, 32);
        portInput.Name = "portInput";
        portInput.PlaceholderText = "5432";
        portInput.Text = "5432";
        portInput.Size = new Size(80, 30);
        portInput.TabIndex = 2;
        // 
        // portLabel
        // 
        portLabel.AutoSize = true;
        portLabel.Location = new Point(330, 35);
        portLabel.Name = "portLabel";
        portLabel.Size = new Size(42, 23);
        portLabel.TabIndex = 4;
        portLabel.Text = "Port";
        // 
        // hostInput
        // 
        hostInput.Location = new Point(92, 32);
        hostInput.Name = "hostInput";
        hostInput.PlaceholderText = "localhost";
        hostInput.Text = "localhost";
        hostInput.Size = new Size(200, 30);
        hostInput.TabIndex = 1;
        // 
        // hostLabel
        // 
        hostLabel.AutoSize = true;
        hostLabel.Location = new Point(16, 35);
        hostLabel.Name = "hostLabel";
        hostLabel.Size = new Size(47, 23);
        hostLabel.TabIndex = 2;
        hostLabel.Text = "Host";
        // 
        // saveConnectionButton
        // 
        saveConnectionButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        saveConnectionButton.BackColor = Color.FromArgb(75, 123, 236);
        saveConnectionButton.FlatAppearance.BorderSize = 0;
        saveConnectionButton.FlatStyle = FlatStyle.Flat;
        saveConnectionButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        saveConnectionButton.ForeColor = Color.White;
        saveConnectionButton.Location = new Point(694, 32);
        saveConnectionButton.Name = "saveConnectionButton";
        saveConnectionButton.Size = new Size(220, 60);
        saveConnectionButton.TabIndex = 6;
        saveConnectionButton.Text = "Guardar conexão";
        saveConnectionButton.UseVisualStyleBackColor = false;
        saveConnectionButton.Click += SaveConnection;
        // 
        // gridTitle
        // 
        gridTitle.AutoSize = true;
        gridTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
        gridTitle.Location = new Point(20, 289);
        gridTitle.Name = "gridTitle";
        gridTitle.Size = new Size(162, 25);
        gridTitle.TabIndex = 2;
        gridTitle.Text = "Itens cadastrados";
        // 
        // productsGrid
        // 
        productsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        productsGrid.BackgroundColor = Color.White;
        productsGrid.BorderStyle = BorderStyle.Fixed3D;
        productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        productsGrid.Location = new Point(20, 317);
        productsGrid.Name = "productsGrid";
        productsGrid.RowHeadersWidth = 51;
        productsGrid.RowTemplate.Height = 29;
        productsGrid.Size = new Size(942, 226);
        productsGrid.TabIndex = 3;
        // 
        // reloadButton
        // 
        reloadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        reloadButton.BackColor = Color.FromArgb(235, 239, 245);
        reloadButton.FlatAppearance.BorderColor = Color.FromArgb(200, 206, 217);
        reloadButton.FlatStyle = FlatStyle.Flat;
        reloadButton.Location = new Point(20, 565);
        reloadButton.Name = "reloadButton";
        reloadButton.Size = new Size(120, 34);
        reloadButton.TabIndex = 7;
        reloadButton.Text = "Atualizar";
        reloadButton.UseVisualStyleBackColor = false;
        reloadButton.Click += LoadProducts;
        // 
        // addButton
        // 
        addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        addButton.BackColor = Color.FromArgb(75, 191, 115);
        addButton.FlatAppearance.BorderSize = 0;
        addButton.FlatStyle = FlatStyle.Flat;
        addButton.ForeColor = Color.White;
        addButton.Location = new Point(164, 565);
        addButton.Name = "addButton";
        addButton.Size = new Size(120, 34);
        addButton.TabIndex = 8;
        addButton.Text = "Adicionar";
        addButton.UseVisualStyleBackColor = false;
        addButton.Click += AddProduct;
        // 
        // editButton
        // 
        editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        editButton.BackColor = Color.FromArgb(247, 193, 71);
        editButton.FlatAppearance.BorderSize = 0;
        editButton.FlatStyle = FlatStyle.Flat;
        editButton.ForeColor = Color.FromArgb(47, 41, 28);
        editButton.Location = new Point(308, 565);
        editButton.Name = "editButton";
        editButton.Size = new Size(120, 34);
        editButton.TabIndex = 9;
        editButton.Text = "Editar";
        editButton.UseVisualStyleBackColor = false;
        editButton.Click += EditProduct;
        // 
        // deleteButton
        // 
        deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        deleteButton.BackColor = Color.FromArgb(235, 87, 87);
        deleteButton.FlatAppearance.BorderSize = 0;
        deleteButton.FlatStyle = FlatStyle.Flat;
        deleteButton.ForeColor = Color.White;
        deleteButton.Location = new Point(452, 565);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new Size(120, 34);
        deleteButton.TabIndex = 10;
        deleteButton.Text = "Remover";
        deleteButton.UseVisualStyleBackColor = false;
        deleteButton.Click += DeleteProduct;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(982, 640);
        Controls.Add(deleteButton);
        Controls.Add(editButton);
        Controls.Add(addButton);
        Controls.Add(reloadButton);
        Controls.Add(productsGrid);
        Controls.Add(gridTitle);
        Controls.Add(connectionGroup);
        Controls.Add(headerPanel);
        Controls.Add(mainMenu);
        MainMenuStrip = mainMenu;
        MinimumSize = new Size(820, 600);
        Name = "MainWindow";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Super Duper Market - Estoque";
        mainMenu.ResumeLayout(false);
        mainMenu.PerformLayout();
        headerPanel.ResumeLayout(false);
        headerPanel.PerformLayout();
        connectionGroup.ResumeLayout(false);
        connectionGroup.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel headerPanel;
    private Label headerTitle;
    private GroupBox connectionGroup;
    private TextBox hostInput;
    private Label hostLabel;
    private Button saveConnectionButton;
    private TextBox portInput;
    private Label portLabel;
    private TextBox userInput;
    private Label userLabel;
    private TextBox passwordInput;
    private Label passwordLabel;
    private TextBox databaseInput;
    private Label databaseLabel;
    private Label connectionStatus;
    private Label gridTitle;
    private DataGridView productsGrid;
    private Button reloadButton;
    private Button addButton;
    private Button editButton;
    private Button deleteButton;
}
