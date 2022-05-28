namespace DesafioCSharpRest.Views
{
    partial class Welcome
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
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifierProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionENProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableSTKProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonUpdateProductForm = new System.Windows.Forms.Button();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.buttonSaveProductForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.identifierProduct,
            this.descriptionProduct,
            this.descriptionENProduct,
            this.priceProduct,
            this.unitProduct,
            this.availableSTKProduct,
            this.vatProduct});
            this.dataGridViewProduct.Location = new System.Drawing.Point(262, 0);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowTemplate.Height = 25;
            this.dataGridViewProduct.Size = new System.Drawing.Size(830, 449);
            this.dataGridViewProduct.TabIndex = 4;
            // 
            // idProduct
            // 
            this.idProduct.HeaderText = "ID";
            this.idProduct.Name = "idProduct";
            this.idProduct.ReadOnly = true;
            // 
            // identifierProduct
            // 
            this.identifierProduct.HeaderText = "Identificador";
            this.identifierProduct.Name = "identifierProduct";
            this.identifierProduct.ReadOnly = true;
            // 
            // descriptionProduct
            // 
            this.descriptionProduct.HeaderText = "Descrição";
            this.descriptionProduct.Name = "descriptionProduct";
            this.descriptionProduct.ReadOnly = true;
            // 
            // descriptionENProduct
            // 
            this.descriptionENProduct.HeaderText = "Descrição English";
            this.descriptionENProduct.Name = "descriptionENProduct";
            this.descriptionENProduct.ReadOnly = true;
            // 
            // priceProduct
            // 
            this.priceProduct.HeaderText = "Preço";
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.ReadOnly = true;
            // 
            // unitProduct
            // 
            this.unitProduct.HeaderText = "Unidade";
            this.unitProduct.Name = "unitProduct";
            this.unitProduct.ReadOnly = true;
            // 
            // availableSTKProduct
            // 
            this.availableSTKProduct.HeaderText = "STK Disponível";
            this.availableSTKProduct.Name = "availableSTKProduct";
            this.availableSTKProduct.ReadOnly = true;
            // 
            // vatProduct
            // 
            this.vatProduct.HeaderText = "VAT";
            this.vatProduct.Name = "vatProduct";
            this.vatProduct.ReadOnly = true;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.buttonUpdateProductForm);
            this.panelActions.Controls.Add(this.buttonRefreshList);
            this.panelActions.Controls.Add(this.buttonSaveProductForm);
            this.panelActions.Location = new System.Drawing.Point(0, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(256, 449);
            this.panelActions.TabIndex = 3;
            // 
            // buttonUpdateProductForm
            // 
            this.buttonUpdateProductForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.buttonUpdateProductForm.FlatAppearance.BorderSize = 0;
            this.buttonUpdateProductForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateProductForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdateProductForm.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateProductForm.Location = new System.Drawing.Point(3, 49);
            this.buttonUpdateProductForm.Name = "buttonUpdateProductForm";
            this.buttonUpdateProductForm.Size = new System.Drawing.Size(250, 40);
            this.buttonUpdateProductForm.TabIndex = 2;
            this.buttonUpdateProductForm.Text = "Editar Produto";
            this.buttonUpdateProductForm.UseVisualStyleBackColor = false;
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.buttonRefreshList.FlatAppearance.BorderSize = 0;
            this.buttonRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefreshList.ForeColor = System.Drawing.Color.White;
            this.buttonRefreshList.Location = new System.Drawing.Point(3, 95);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(250, 40);
            this.buttonRefreshList.TabIndex = 1;
            this.buttonRefreshList.Text = "Actualizar Lista";
            this.buttonRefreshList.UseVisualStyleBackColor = false;
            // 
            // buttonSaveProductForm
            // 
            this.buttonSaveProductForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.buttonSaveProductForm.FlatAppearance.BorderSize = 0;
            this.buttonSaveProductForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveProductForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveProductForm.ForeColor = System.Drawing.Color.White;
            this.buttonSaveProductForm.Location = new System.Drawing.Point(3, 3);
            this.buttonSaveProductForm.Name = "buttonSaveProductForm";
            this.buttonSaveProductForm.Size = new System.Drawing.Size(250, 40);
            this.buttonSaveProductForm.TabIndex = 0;
            this.buttonSaveProductForm.Text = "Registar Novo Produto";
            this.buttonSaveProductForm.UseVisualStyleBackColor = false;
            this.buttonSaveProductForm.Click += new System.EventHandler(this.buttonSaveProductForm_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.panelActions);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(1092, 449);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

            
        }

        #endregion

        private DataGridView dataGridViewProduct;
        private DataGridViewTextBoxColumn idProduct;
        private DataGridViewTextBoxColumn identifierProduct;
        private DataGridViewTextBoxColumn descriptionProduct;
        private DataGridViewTextBoxColumn descriptionENProduct;
        private DataGridViewTextBoxColumn priceProduct;
        private DataGridViewTextBoxColumn unitProduct;
        private DataGridViewTextBoxColumn availableSTKProduct;
        private DataGridViewTextBoxColumn vatProduct;
        private Panel panelActions;
        private Button buttonUpdateProductForm;
        private Button buttonRefreshList;
        private Button buttonSaveProductForm;

        #region Events
            private void buttonSaveProductForm_Click(object sender, EventArgs e)
        {
            Panel mainPanel = ((Panel)this.Parent);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(ProductForm.getInstance());
        }
        #endregion
    }
}
