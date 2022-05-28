using DesafioCSharpRest.Utils;
using DesafioCSharpRest.Domain.Services;
using DesafioCSharpRest.Domain.Models;

namespace DesafioCSharpRest.Views
{
    partial class ProductForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSaveProduct = new System.Windows.Forms.Button();
            this.tableLayoutPanelButtonFields = new System.Windows.Forms.TableLayoutPanel();
            this.maskedTextBoxVAT = new System.Windows.Forms.MaskedTextBox();
            this.labelIdentifier = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDescriptionEN = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelVAT = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxIdentifier = new System.Windows.Forms.TextBox();
            this.textBoxDescriptionEN = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelActions.SuspendLayout();
            this.tableLayoutPanelButtonFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.buttonCancel);
            this.panelActions.Controls.Add(this.buttonSaveProduct);
            this.panelActions.Location = new System.Drawing.Point(3, 3);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(256, 443);
            this.panelActions.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(3, 400);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(250, 40);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancelar Registo e Voltar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSaveProduct
            // 
            this.buttonSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.buttonSaveProduct.FlatAppearance.BorderSize = 0;
            this.buttonSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveProduct.ForeColor = System.Drawing.Color.White;
            this.buttonSaveProduct.Location = new System.Drawing.Point(3, 3);
            this.buttonSaveProduct.Name = "buttonSaveProduct";
            this.buttonSaveProduct.Size = new System.Drawing.Size(250, 40);
            this.buttonSaveProduct.TabIndex = 1;
            this.buttonSaveProduct.Text = "Registar";
            this.buttonSaveProduct.UseVisualStyleBackColor = false;
            this.buttonSaveProduct.Click += new System.EventHandler(this.buttonSaveProduct_Click);
            // 
            // tableLayoutPanelButtonFields
            // 
            this.tableLayoutPanelButtonFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelButtonFields.ColumnCount = 2;
            this.tableLayoutPanelButtonFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.35437F));
            this.tableLayoutPanelButtonFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.64563F));
            this.tableLayoutPanelButtonFields.Controls.Add(this.maskedTextBoxVAT, 1, 6);
            this.tableLayoutPanelButtonFields.Controls.Add(this.labelIdentifier, 0, 1);
            this.tableLayoutPanelButtonFields.Controls.Add(this.labelDescription, 0, 2);
            this.tableLayoutPanelButtonFields.Controls.Add(this.labelDescriptionEN, 0, 3);
            this.tableLayoutPanelButtonFields.Controls.Add(this.labelPrice, 0, 4);
            this.tableLayoutPanelButtonFields.Controls.Add(this.labelUnit, 0, 5);
            this.tableLayoutPanelButtonFields.Controls.Add(this.labelVAT, 0, 6);
            this.tableLayoutPanelButtonFields.Controls.Add(this.textBoxDescription, 1, 2);
            this.tableLayoutPanelButtonFields.Controls.Add(this.textBoxIdentifier, 1, 1);
            this.tableLayoutPanelButtonFields.Controls.Add(this.textBoxDescriptionEN, 1, 3);
            this.tableLayoutPanelButtonFields.Controls.Add(this.textBoxUnit, 1, 5);
            this.tableLayoutPanelButtonFields.Controls.Add(this.maskedTextBoxPrice, 1, 4);
            this.tableLayoutPanelButtonFields.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanelButtonFields.Location = new System.Drawing.Point(265, 6);
            this.tableLayoutPanelButtonFields.Name = "tableLayoutPanelButtonFields";
            this.tableLayoutPanelButtonFields.RowCount = 8;
            this.tableLayoutPanelButtonFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelButtonFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelButtonFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelButtonFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelButtonFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelButtonFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelButtonFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelButtonFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelButtonFields.Size = new System.Drawing.Size(824, 437);
            this.tableLayoutPanelButtonFields.TabIndex = 1;
            // 
            // maskedTextBoxVAT
            // 
            this.maskedTextBoxVAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxVAT.Culture = new System.Globalization.CultureInfo("pt-MZ");
            this.maskedTextBoxVAT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxVAT.Location = new System.Drawing.Point(146, 360);
            this.maskedTextBoxVAT.Mask = "00000";
            this.maskedTextBoxVAT.Name = "maskedTextBoxVAT";
            this.maskedTextBoxVAT.Size = new System.Drawing.Size(675, 29);
            this.maskedTextBoxVAT.TabIndex = 13;
            this.maskedTextBoxVAT.ValidatingType = typeof(int);
            // 
            // labelIdentifier
            // 
            this.labelIdentifier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelIdentifier.AutoSize = true;
            this.labelIdentifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdentifier.Location = new System.Drawing.Point(3, 77);
            this.labelIdentifier.Name = "labelIdentifier";
            this.labelIdentifier.Size = new System.Drawing.Size(97, 21);
            this.labelIdentifier.TabIndex = 0;
            this.labelIdentifier.Text = "Identificador";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(3, 152);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(77, 21);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Descrição";
            // 
            // labelDescriptionEN
            // 
            this.labelDescriptionEN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDescriptionEN.AutoSize = true;
            this.labelDescriptionEN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescriptionEN.Location = new System.Drawing.Point(3, 214);
            this.labelDescriptionEN.Name = "labelDescriptionEN";
            this.labelDescriptionEN.Size = new System.Drawing.Size(131, 21);
            this.labelDescriptionEN.TabIndex = 2;
            this.labelDescriptionEN.Text = "Descrição English";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(3, 264);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(49, 21);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Preço";
            // 
            // labelUnit
            // 
            this.labelUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUnit.Location = new System.Drawing.Point(3, 314);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(68, 21);
            this.labelUnit.TabIndex = 4;
            this.labelUnit.Text = "Unidade";
            // 
            // labelVAT
            // 
            this.labelVAT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelVAT.AutoSize = true;
            this.labelVAT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVAT.Location = new System.Drawing.Point(3, 364);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(36, 21);
            this.labelVAT.TabIndex = 5;
            this.labelVAT.Text = "VAT";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(146, 128);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(675, 69);
            this.textBoxDescription.TabIndex = 6;
            // 
            // textBoxIdentifier
            // 
            this.textBoxIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdentifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIdentifier.Location = new System.Drawing.Point(146, 73);
            this.textBoxIdentifier.Name = "textBoxIdentifier";
            this.textBoxIdentifier.Size = new System.Drawing.Size(675, 29);
            this.textBoxIdentifier.TabIndex = 7;
            // 
            // textBoxDescriptionEN
            // 
            this.textBoxDescriptionEN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescriptionEN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescriptionEN.Location = new System.Drawing.Point(146, 203);
            this.textBoxDescriptionEN.Multiline = true;
            this.textBoxDescriptionEN.Name = "textBoxDescriptionEN";
            this.textBoxDescriptionEN.Size = new System.Drawing.Size(675, 44);
            this.textBoxDescriptionEN.TabIndex = 8;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUnit.Location = new System.Drawing.Point(146, 310);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(675, 29);
            this.textBoxUnit.TabIndex = 10;
            // 
            // maskedTextBoxPrice
            // 
            this.maskedTextBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxPrice.Culture = new System.Globalization.CultureInfo("pt-MZ");
            this.maskedTextBoxPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxPrice.Location = new System.Drawing.Point(146, 260);
            this.maskedTextBoxPrice.Mask = "000.000.000 00 MZN";
            this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            this.maskedTextBoxPrice.Size = new System.Drawing.Size(675, 29);
            this.maskedTextBoxPrice.TabIndex = 12;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.tableLayoutPanelButtonFields.SetColumnSpan(this.labelTitle, 2);
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(818, 50);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Registo de Produto";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanelButtonFields);
            this.Controls.Add(this.panelActions);
            this.Name = "ProductForm";
            this.Size = new System.Drawing.Size(1092, 449);
            this.panelActions.ResumeLayout(false);
            this.tableLayoutPanelButtonFields.ResumeLayout(false);
            this.tableLayoutPanelButtonFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelActions;
        private Button buttonSaveProduct;
        private Button buttonCancel;
        private TableLayoutPanel tableLayoutPanelButtonFields;
        private Label labelIdentifier;
        private Label labelDescription;
        private Label labelDescriptionEN;
        private Label labelPrice;
        private Label labelUnit;
        private Label labelVAT;
        private TextBox textBoxDescription;
        private TextBox textBoxIdentifier;
        private TextBox textBoxDescriptionEN;
        private TextBox textBoxUnit;
        private MaskedTextBox maskedTextBoxVAT;
        private MaskedTextBox maskedTextBoxPrice;
        private Label labelTitle;

        #region Events
        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {
            ProductService productService = ProductService.getInsance();

            String identifier = this.textBoxIdentifier.Text;
            String description = this.textBoxDescription.Text;
            String descriptionEN = this.textBoxDescriptionEN.Text;
            String bearerPrice = this.maskedTextBoxPrice.Text;
            bearerPrice = FormatUtils.stringToParseableNumber(bearerPrice);
            Decimal price;
            bool priceParsed = Decimal.TryParse(bearerPrice, out price);
            if (!priceParsed)
            {
                this.maskedTextBoxPrice.BackColor = Color.FromArgb(248, 188, 188);
                MessageBoxUtils.showWarningBox(this, "Deves informar o preço!");
                return;
            }

            String unit = this.textBoxUnit.Text;
            String bearerVAT = FormatUtils.stringToParseableNumber(this.maskedTextBoxVAT.Text);
            Double vat;
            bool vatParsed = Double.TryParse(bearerVAT, out vat);
            if (!vatParsed)
            {
                this.maskedTextBoxVAT.BackColor = Color.FromArgb(248, 188, 188);
                MessageBoxUtils.showWarningBox(this, "Deves informar o VAT!");
                return;
            }

            Product newProduct = new Product();
            newProduct.Identifier = identifier;
            newProduct.Description = description;
            newProduct.DescriptionEN = descriptionEN;
            newProduct.Price = price;
            newProduct.Unit = unit;
            newProduct.VAT = vat;

            Product savedProduct = productService.saveProduct(newProduct);
            MessageBoxUtils.showInformationBox(this, String.Format("O producto\nID:{0}\nNome: {1} \nfoi ragistado com sucesso.", savedProduct.Id, savedProduct.Identifier));
        }
        public void buttonCancel_Click(object sender, EventArgs e){
            if (MessageBoxUtils.showQuestionBox(this, "Deseja cancelar o registo do produto?"))
            {
                this.clearFields();
                Panel mainPanel = ((Panel)this.Parent);
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(Welcome.getInstance());
            }
        }
        
        private void clearFields()
        {
            this.textBoxIdentifier.Clear();
            this.textBoxDescription.Clear();
            this.textBoxDescriptionEN.Clear();
            this.textBoxUnit.Clear();
            this.maskedTextBoxVAT.Clear();
            this.maskedTextBoxPrice.Clear();
            this.maskedTextBoxPrice.BackColor = Color.White;
            this.maskedTextBoxVAT.BackColor = Color.White;
        }
        #endregion
        }
    }
