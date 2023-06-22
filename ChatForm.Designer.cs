namespace FrontChat
{
    partial class FluentDesignForm1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            tileViewColumn1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            tileViewColumn2 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            Chat = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            txtMenssagem = new DevExpress.XtraEditors.TextEdit();
            layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            btnEnviar = new Button();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Chat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tileView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMenssagem.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl3).BeginInit();
            layoutControl3.SuspendLayout();
            SuspendLayout();
            // 
            // tileViewColumn1
            // 
            tileViewColumn1.Caption = "ID";
            tileViewColumn1.FieldName = "Id";
            tileViewColumn1.Name = "tileViewColumn1";
            tileViewColumn1.Visible = true;
            tileViewColumn1.VisibleIndex = 0;
            // 
            // tileViewColumn2
            // 
            tileViewColumn2.Caption = "Nome";
            tileViewColumn2.FieldName = "Name";
            tileViewColumn2.Name = "tileViewColumn2";
            tileViewColumn2.Visible = true;
            tileViewColumn2.VisibleIndex = 1;
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Location = new Point(0, 0);
            fluentDesignFormControl1.Manager = Chat;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new Size(691, 31);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            // 
            // Chat
            // 
            Chat.Form = this;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(gridControl1);
            layoutControl1.Dock = DockStyle.Left;
            layoutControl1.Location = new Point(0, 31);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(164, 442);
            layoutControl1.TabIndex = 3;
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(12, 12);
            gridControl1.MainView = tileView1;
            gridControl1.MenuManager = Chat;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(140, 418);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { tileView1 });
            // 
            // tileView1
            // 
            tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { tileViewColumn1, tileViewColumn2 });
            tileView1.GridControl = gridControl1;
            tileView1.Name = "tileView1";
            tileView1.OptionsTiles.GroupTextPadding = new Padding(12, 8, 12, 8);
            tileView1.OptionsTiles.IndentBetweenGroups = 0;
            tileView1.OptionsTiles.IndentBetweenItems = 0;
            tileView1.OptionsTiles.ItemSize = new Size(248, 55);
            tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            tileView1.OptionsTiles.Orientation = Orientation.Vertical;
            tileView1.OptionsTiles.Padding = new Padding(0);
            tileView1.OptionsTiles.RowCount = 0;
            tileView1.TileColumns.Add(tableColumnDefinition1);
            tileView1.TileColumns.Add(tableColumnDefinition2);
            tableRowDefinition1.Length.Value = 30D;
            tileView1.TileRows.Add(tableRowDefinition1);
            tileViewItemElement1.Column = tileViewColumn1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "tileViewColumn1";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = tileViewColumn2;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.Text = "tileViewColumn2";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileView1.TileTemplate.Add(tileViewItemElement1);
            tileView1.TileTemplate.Add(tileViewItemElement2);
            // 
            // Root
            // 
            Root.AppearanceGroup.BackColor = Color.MidnightBlue;
            Root.AppearanceGroup.Options.UseBackColor = true;
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1 });
            Root.Name = "Root";
            Root.Size = new Size(164, 442);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = gridControl1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(144, 422);
            layoutControlItem1.TextSize = new Size(0, 0);
            layoutControlItem1.TextVisible = false;
            // 
            // txtMenssagem
            // 
            txtMenssagem.Location = new Point(177, 412);
            txtMenssagem.MenuManager = Chat;
            txtMenssagem.Name = "txtMenssagem";
            txtMenssagem.Size = new Size(442, 20);
            txtMenssagem.StyleController = layoutControl3;
            txtMenssagem.TabIndex = 5;
            // 
            // layoutControl3
            // 
            layoutControl3.Controls.Add(btnEnviar);
            layoutControl3.Controls.Add(txtMenssagem);
            layoutControl3.Dock = DockStyle.Fill;
            layoutControl3.Location = new Point(0, 31);
            layoutControl3.Name = "layoutControl3";
            layoutControl3.Root = null;
            layoutControl3.Size = new Size(691, 442);
            layoutControl3.TabIndex = 5;
            layoutControl3.Text = "layoutControl3";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(626, 402);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(57, 36);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "button1";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FluentDesignForm1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 473);
            Controls.Add(layoutControl1);
            Controls.Add(layoutControl3);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FluentDesignForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat";
            Load += FluentDesignForm1_Load;
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Chat).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tileView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMenssagem.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl3).EndInit();
            layoutControl3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager Chat;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private Button btnEnviar;
        private DevExpress.XtraEditors.TextEdit txtMenssagem;
    }
}