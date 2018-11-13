﻿namespace Program.Forms
{
  partial class FormStatsHome
  {

    private System.ComponentModel.IContainer components = null;
    
    
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    
    private void InitializeComponent()
    {
      this.check_dia = new MaterialSkin.Controls.MaterialCheckBox();
      this.combo_dia = new System.Windows.Forms.ComboBox();
      this.check_mes = new MaterialSkin.Controls.MaterialCheckBox();
      this.check_año = new MaterialSkin.Controls.MaterialCheckBox();
      this.combo_mes = new System.Windows.Forms.ComboBox();
      this.combo_año = new System.Windows.Forms.ComboBox();
      this.rad_filter_personalized = new MaterialSkin.Controls.MaterialRadioButton();
      this.rad_filter_historic = new MaterialSkin.Controls.MaterialRadioButton();
      this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
      this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
      this.rad_filter_period = new MaterialSkin.Controls.MaterialRadioButton();
      this.label_from = new MaterialSkin.Controls.MaterialLabel();
      this.field_from = new MaterialSkin.Controls.MaterialSingleLineMaskedTextField();
      this.field_to = new MaterialSkin.Controls.MaterialSingleLineMaskedTextField();
      this.label_to = new MaterialSkin.Controls.MaterialLabel();
      this.radio_origin = new MaterialSkin.Controls.MaterialRadioButton();
      this.radio_quantity = new MaterialSkin.Controls.MaterialRadioButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel_filter = new System.Windows.Forms.Panel();
      this.cmb_month = new System.Windows.Forms.ComboBox();
      this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
      this.cmb_year = new System.Windows.Forms.ComboBox();
      this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
      this.panel1.SuspendLayout();
      this.panel_filter.SuspendLayout();
      this.SuspendLayout();
      // 
      // check_dia
      // 
      this.check_dia.Depth = 0;
      this.check_dia.Font = new System.Drawing.Font("Roboto", 10F);
      this.check_dia.Location = new System.Drawing.Point(166, 105);
      this.check_dia.Margin = new System.Windows.Forms.Padding(0);
      this.check_dia.MouseLocation = new System.Drawing.Point(-1, -1);
      this.check_dia.MouseState = MaterialSkin.MouseState.HOVER;
      this.check_dia.Name = "check_dia";
      this.check_dia.Ripple = true;
      this.check_dia.Size = new System.Drawing.Size(60, 24);
      this.check_dia.TabIndex = 45;
      this.check_dia.Text = "Dia";
      this.check_dia.UseVisualStyleBackColor = true;
      this.check_dia.Visible = false;
      this.check_dia.CheckedChanged += new System.EventHandler(this.Check_diaCheckedChanged);
      // 
      // combo_dia
      // 
      this.combo_dia.Enabled = false;
      this.combo_dia.FormattingEnabled = true;
      this.combo_dia.Location = new System.Drawing.Point(229, 106);
      this.combo_dia.Name = "combo_dia";
      this.combo_dia.Size = new System.Drawing.Size(121, 21);
      this.combo_dia.TabIndex = 44;
      this.combo_dia.Visible = false;
      // 
      // check_mes
      // 
      this.check_mes.Depth = 0;
      this.check_mes.Font = new System.Drawing.Font("Roboto", 10F);
      this.check_mes.Location = new System.Drawing.Point(166, 73);
      this.check_mes.Margin = new System.Windows.Forms.Padding(0);
      this.check_mes.MouseLocation = new System.Drawing.Point(-1, -1);
      this.check_mes.MouseState = MaterialSkin.MouseState.HOVER;
      this.check_mes.Name = "check_mes";
      this.check_mes.Ripple = true;
      this.check_mes.Size = new System.Drawing.Size(60, 24);
      this.check_mes.TabIndex = 43;
      this.check_mes.Text = "Mes";
      this.check_mes.UseVisualStyleBackColor = true;
      this.check_mes.Visible = false;
      this.check_mes.CheckedChanged += new System.EventHandler(this.Check_mesCheckedChanged);
      // 
      // check_año
      // 
      this.check_año.Depth = 0;
      this.check_año.Font = new System.Drawing.Font("Roboto", 10F);
      this.check_año.Location = new System.Drawing.Point(166, 41);
      this.check_año.Margin = new System.Windows.Forms.Padding(0);
      this.check_año.MouseLocation = new System.Drawing.Point(-1, -1);
      this.check_año.MouseState = MaterialSkin.MouseState.HOVER;
      this.check_año.Name = "check_año";
      this.check_año.Ripple = true;
      this.check_año.Size = new System.Drawing.Size(60, 24);
      this.check_año.TabIndex = 42;
      this.check_año.Text = "Año";
      this.check_año.UseVisualStyleBackColor = true;
      this.check_año.Visible = false;
      this.check_año.CheckedChanged += new System.EventHandler(this.Check_añoCheckedChanged);
      // 
      // combo_mes
      // 
      this.combo_mes.Enabled = false;
      this.combo_mes.FormattingEnabled = true;
      this.combo_mes.Items.AddRange(new object[] {
                  "Enero",
                  "Febrero",
                  "Marzo",
                  "Abril",
                  "Mayo",
                  "Junio",
                  "Julio",
                  "Agosto",
                  "Septiembre",
                  "Octubre",
                  "Noviembre",
                  "Diciembre"});
      this.combo_mes.Location = new System.Drawing.Point(229, 74);
      this.combo_mes.Name = "combo_mes";
      this.combo_mes.Size = new System.Drawing.Size(121, 21);
      this.combo_mes.TabIndex = 41;
      this.combo_mes.Visible = false;
      // 
      // combo_año
      // 
      this.combo_año.Enabled = false;
      this.combo_año.FormattingEnabled = true;
      this.combo_año.Location = new System.Drawing.Point(229, 42);
      this.combo_año.Name = "combo_año";
      this.combo_año.Size = new System.Drawing.Size(121, 21);
      this.combo_año.TabIndex = 40;
      this.combo_año.Visible = false;
      // 
      // rad_filter_personalized
      // 
      this.rad_filter_personalized.Depth = 0;
      this.rad_filter_personalized.Font = new System.Drawing.Font("Roboto", 10F);
      this.rad_filter_personalized.Location = new System.Drawing.Point(9, 68);
      this.rad_filter_personalized.Margin = new System.Windows.Forms.Padding(0);
      this.rad_filter_personalized.MouseLocation = new System.Drawing.Point(-1, -1);
      this.rad_filter_personalized.MouseState = MaterialSkin.MouseState.HOVER;
      this.rad_filter_personalized.Name = "rad_filter_personalized";
      this.rad_filter_personalized.Ripple = true;
      this.rad_filter_personalized.Size = new System.Drawing.Size(184, 30);
      this.rad_filter_personalized.TabIndex = 39;
      this.rad_filter_personalized.TabStop = true;
      this.rad_filter_personalized.Text = "Personalizado";
      this.rad_filter_personalized.UseVisualStyleBackColor = true;
      this.rad_filter_personalized.CheckedChanged += new System.EventHandler(this.filterChanged);
      // 
      // rad_filter_historic
      // 
      this.rad_filter_historic.Depth = 0;
      this.rad_filter_historic.Font = new System.Drawing.Font("Roboto", 10F);
      this.rad_filter_historic.Location = new System.Drawing.Point(9, 37);
      this.rad_filter_historic.Margin = new System.Windows.Forms.Padding(0);
      this.rad_filter_historic.MouseLocation = new System.Drawing.Point(-1, -1);
      this.rad_filter_historic.MouseState = MaterialSkin.MouseState.HOVER;
      this.rad_filter_historic.Name = "rad_filter_historic";
      this.rad_filter_historic.Ripple = true;
      this.rad_filter_historic.Size = new System.Drawing.Size(184, 30);
      this.rad_filter_historic.TabIndex = 38;
      this.rad_filter_historic.TabStop = true;
      this.rad_filter_historic.Text = "Histórico";
      this.rad_filter_historic.UseVisualStyleBackColor = true;
      this.rad_filter_historic.CheckedChanged += new System.EventHandler(this.filterChanged);
      // 
      // materialLabel2
      // 
      this.materialLabel2.Depth = 0;
      this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel2.Location = new System.Drawing.Point(8, 13);
      this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel2.Name = "materialLabel2";
      this.materialLabel2.Size = new System.Drawing.Size(126, 23);
      this.materialLabel2.TabIndex = 37;
      this.materialLabel2.Text = "Criterio de filtro";
      // 
      // materialLabel1
      // 
      this.materialLabel1.Depth = 0;
      this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel1.Location = new System.Drawing.Point(19, 115);
      this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel1.Name = "materialLabel1";
      this.materialLabel1.Size = new System.Drawing.Size(96, 23);
      this.materialLabel1.TabIndex = 48;
      this.materialLabel1.Text = "Estadísticas";
      // 
      // materialFlatButton2
      // 
      this.materialFlatButton2.Depth = 0;
      this.materialFlatButton2.Icon = null;
      this.materialFlatButton2.Location = new System.Drawing.Point(234, 326);
      this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialFlatButton2.Name = "materialFlatButton2";
      this.materialFlatButton2.Primary = false;
      this.materialFlatButton2.selected = false;
      this.materialFlatButton2.Size = new System.Drawing.Size(219, 50);
      this.materialFlatButton2.TabIndex = 49;
      this.materialFlatButton2.Text = "Visualizar";
      this.materialFlatButton2.UseVisualStyleBackColor = true;
      this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2Click);
      // 
      // rad_filter_period
      // 
      this.rad_filter_period.Depth = 0;
      this.rad_filter_period.Font = new System.Drawing.Font("Roboto", 10F);
      this.rad_filter_period.Location = new System.Drawing.Point(9, 100);
      this.rad_filter_period.Margin = new System.Windows.Forms.Padding(0);
      this.rad_filter_period.MouseLocation = new System.Drawing.Point(-1, -1);
      this.rad_filter_period.MouseState = MaterialSkin.MouseState.HOVER;
      this.rad_filter_period.Name = "rad_filter_period";
      this.rad_filter_period.Ripple = true;
      this.rad_filter_period.Size = new System.Drawing.Size(145, 30);
      this.rad_filter_period.TabIndex = 50;
      this.rad_filter_period.TabStop = true;
      this.rad_filter_period.Text = "Período";
      this.rad_filter_period.UseVisualStyleBackColor = true;
      this.rad_filter_period.CheckedChanged += new System.EventHandler(this.filterChanged);
      // 
      // label_from
      // 
      this.label_from.Depth = 0;
      this.label_from.Font = new System.Drawing.Font("Roboto", 11F);
      this.label_from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label_from.Location = new System.Drawing.Point(166, 75);
      this.label_from.MouseState = MaterialSkin.MouseState.HOVER;
      this.label_from.Name = "label_from";
      this.label_from.Size = new System.Drawing.Size(96, 23);
      this.label_from.TabIndex = 51;
      this.label_from.Text = "desde";
      this.label_from.Visible = false;
      // 
      // field_from
      // 
      this.field_from.Depth = 0;
      this.field_from.Hint = "";
      this.field_from.Location = new System.Drawing.Point(166, 53);
      this.field_from.Mask = "";
      this.field_from.MaxLength = 32767;
      this.field_from.MouseState = MaterialSkin.MouseState.HOVER;
      this.field_from.Name = "field_from";
      this.field_from.PasswordChar = '\0';
      this.field_from.SelectedText = "";
      this.field_from.SelectionLength = 0;
      this.field_from.SelectionStart = 0;
      this.field_from.Size = new System.Drawing.Size(109, 23);
      this.field_from.TabIndex = 52;
      this.field_from.TabStop = false;
      this.field_from.UseSystemPasswordChar = false;
      this.field_from.Visible = false;
      // 
      // field_to
      // 
      this.field_to.Depth = 0;
      this.field_to.Hint = "";
      this.field_to.Location = new System.Drawing.Point(166, 107);
      this.field_to.Mask = "";
      this.field_to.MaxLength = 32767;
      this.field_to.MouseState = MaterialSkin.MouseState.HOVER;
      this.field_to.Name = "field_to";
      this.field_to.PasswordChar = '\0';
      this.field_to.SelectedText = "";
      this.field_to.SelectionLength = 0;
      this.field_to.SelectionStart = 0;
      this.field_to.Size = new System.Drawing.Size(109, 23);
      this.field_to.TabIndex = 54;
      this.field_to.TabStop = false;
      this.field_to.UseSystemPasswordChar = false;
      this.field_to.Visible = false;
      // 
      // label_to
      // 
      this.label_to.Depth = 0;
      this.label_to.Font = new System.Drawing.Font("Roboto", 11F);
      this.label_to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label_to.Location = new System.Drawing.Point(168, 32);
      this.label_to.MouseState = MaterialSkin.MouseState.HOVER;
      this.label_to.Name = "label_to";
      this.label_to.Size = new System.Drawing.Size(96, 23);
      this.label_to.TabIndex = 53;
      this.label_to.Text = "hasta";
      this.label_to.Visible = false;
      // 
      // radio_origin
      // 
      this.radio_origin.Depth = 0;
      this.radio_origin.Font = new System.Drawing.Font("Roboto", 10F);
      this.radio_origin.Location = new System.Drawing.Point(6, 5);
      this.radio_origin.Margin = new System.Windows.Forms.Padding(0);
      this.radio_origin.MouseLocation = new System.Drawing.Point(-1, -1);
      this.radio_origin.MouseState = MaterialSkin.MouseState.HOVER;
      this.radio_origin.Name = "radio_origin";
      this.radio_origin.Ripple = true;
      this.radio_origin.Size = new System.Drawing.Size(211, 24);
      this.radio_origin.TabIndex = 55;
      this.radio_origin.TabStop = true;
      this.radio_origin.Text = "ORIGEN DE LOS HUÉSPEDES";
      this.radio_origin.UseVisualStyleBackColor = true;
      // 
      // radio_quantity
      // 
      this.radio_quantity.Depth = 0;
      this.radio_quantity.Font = new System.Drawing.Font("Roboto", 10F);
      this.radio_quantity.Location = new System.Drawing.Point(6, 45);
      this.radio_quantity.Margin = new System.Windows.Forms.Padding(0);
      this.radio_quantity.MouseLocation = new System.Drawing.Point(-1, -1);
      this.radio_quantity.MouseState = MaterialSkin.MouseState.HOVER;
      this.radio_quantity.Name = "radio_quantity";
      this.radio_quantity.Ripple = true;
      this.radio_quantity.Size = new System.Drawing.Size(255, 24);
      this.radio_quantity.TabIndex = 56;
      this.radio_quantity.TabStop = true;
      this.radio_quantity.Text = "CANTIDAD DE HUÉSPEDES DIARIOS";
      this.radio_quantity.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.radio_origin);
      this.panel1.Controls.Add(this.radio_quantity);
      this.panel1.Location = new System.Drawing.Point(20, 145);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(277, 76);
      this.panel1.TabIndex = 59;
      // 
      // panel_filter
      // 
      this.panel_filter.Controls.Add(this.field_to);
      this.panel_filter.Controls.Add(this.label_to);
      this.panel_filter.Controls.Add(this.field_from);
      this.panel_filter.Controls.Add(this.label_from);
      this.panel_filter.Controls.Add(this.rad_filter_period);
      this.panel_filter.Controls.Add(this.check_dia);
      this.panel_filter.Controls.Add(this.combo_dia);
      this.panel_filter.Controls.Add(this.check_mes);
      this.panel_filter.Controls.Add(this.check_año);
      this.panel_filter.Controls.Add(this.combo_mes);
      this.panel_filter.Controls.Add(this.combo_año);
      this.panel_filter.Controls.Add(this.rad_filter_personalized);
      this.panel_filter.Controls.Add(this.rad_filter_historic);
      this.panel_filter.Controls.Add(this.materialLabel2);
      this.panel_filter.Location = new System.Drawing.Point(319, 105);
      this.panel_filter.Name = "panel_filter";
      this.panel_filter.Size = new System.Drawing.Size(364, 145);
      this.panel_filter.TabIndex = 60;
      // 
      // cmb_month
      // 
      this.cmb_month.Enabled = false;
      this.cmb_month.FormattingEnabled = true;
      this.cmb_month.Items.AddRange(new object[] {
                  "Enero",
                  "Febrero",
                  "Marzo",
                  "Abril",
                  "Mayo",
                  "Junio",
                  "Julio",
                  "Agosto",
                  "Septiembre",
                  "Octubre",
                  "Noviembre",
                  "Diciembre"});
      this.cmb_month.Location = new System.Drawing.Point(548, 282);
      this.cmb_month.Name = "cmb_month";
      this.cmb_month.Size = new System.Drawing.Size(121, 21);
      this.cmb_month.TabIndex = 55;
      this.cmb_month.SelectedIndexChanged += new System.EventHandler(this.Cmb_monthSelectedIndexChanged);
      // 
      // materialLabel3
      // 
      this.materialLabel3.Depth = 0;
      this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel3.Location = new System.Drawing.Point(412, 282);
      this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel3.Name = "materialLabel3";
      this.materialLabel3.Size = new System.Drawing.Size(100, 23);
      this.materialLabel3.TabIndex = 61;
      this.materialLabel3.Text = "Mes";
      // 
      // cmb_year
      // 
      this.cmb_year.FormattingEnabled = true;
      this.cmb_year.Location = new System.Drawing.Point(548, 255);
      this.cmb_year.Name = "cmb_year";
      this.cmb_year.Size = new System.Drawing.Size(121, 21);
      this.cmb_year.TabIndex = 62;
      this.cmb_year.SelectedIndexChanged += new System.EventHandler(this.Cmb_yearSelectedIndexChanged);
      // 
      // materialLabel4
      // 
      this.materialLabel4.Depth = 0;
      this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel4.Location = new System.Drawing.Point(412, 253);
      this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel4.Name = "materialLabel4";
      this.materialLabel4.Size = new System.Drawing.Size(100, 23);
      this.materialLabel4.TabIndex = 63;
      this.materialLabel4.Text = "Año";
      // 
      // FormStatsHome
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(741, 518);
      this.Controls.Add(this.materialLabel4);
      this.Controls.Add(this.cmb_year);
      this.Controls.Add(this.materialLabel3);
      this.Controls.Add(this.cmb_month);
      this.Controls.Add(this.panel_filter);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.materialFlatButton2);
      this.Controls.Add(this.materialLabel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormStatsHome";
      this.Text = "FormStatsHome";
      this.panel1.ResumeLayout(false);
      this.panel_filter.ResumeLayout(false);
      this.ResumeLayout(false);
    }
    private MaterialSkin.Controls.MaterialLabel materialLabel4;
    private System.Windows.Forms.ComboBox cmb_year;
    private MaterialSkin.Controls.MaterialLabel materialLabel3;
    private System.Windows.Forms.ComboBox cmb_month;
    private System.Windows.Forms.Panel panel_filter;
    private System.Windows.Forms.Panel panel1;
    private MaterialSkin.Controls.MaterialRadioButton radio_quantity;
    private MaterialSkin.Controls.MaterialRadioButton radio_origin;
    private MaterialSkin.Controls.MaterialLabel label_to;
    private MaterialSkin.Controls.MaterialSingleLineMaskedTextField field_to;
    private MaterialSkin.Controls.MaterialSingleLineMaskedTextField field_from;
    private MaterialSkin.Controls.MaterialLabel label_from;
    private MaterialSkin.Controls.MaterialRadioButton rad_filter_period;
    private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialRadioButton rad_filter_historic;
    private MaterialSkin.Controls.MaterialRadioButton rad_filter_personalized;
    private System.Windows.Forms.ComboBox combo_año;
    private System.Windows.Forms.ComboBox combo_mes;
    private MaterialSkin.Controls.MaterialCheckBox check_año;
    private MaterialSkin.Controls.MaterialCheckBox check_mes;
    private System.Windows.Forms.ComboBox combo_dia;
    private MaterialSkin.Controls.MaterialCheckBox check_dia;
  }
}
